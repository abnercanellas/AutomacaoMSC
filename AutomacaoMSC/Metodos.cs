using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Windows.Forms;

namespace AutomacaoMSC
{
    class Metodos
    {

        public static string architecture = Environment.Is64BitOperatingSystem? "x64":"x86";
        public static string msg;
        public static string Ethernet = "Ethernet";



        public static Dictionary<string, string> GetMacs()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                string mac2 = nic.GetPhysicalAddress().ToString();
                int len = mac2.Length;
                string aux = "";
                for (int i = 0; i < len; i += 2)
                {
                    aux += mac2.Substring(i, 2);
                    if (i < len - 2)
                        aux += ":";
                }

                foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                       aux += " " + ip.Address.ToString();
                    }
                }

                dic.Add(nic.Name, aux );

                if (nic.Name.Contains("Ethernet") && nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet) Ethernet = nic.Name;
            }

            return dic;
        }

        //adiciona o evento ao painel de log
        public static void AddLog(RichTextBox tb, string msg)
        {
            tb.Visible = true; //garante que o painel esteja visivel
            tb.AppendText("-> " + msg + " ..." + Environment.NewLine); //adiciona o evento na ultima linha
        }

        //comandos relativos à edição do registro do windows
        public static void EditReg(RichTextBox tb, string userRoot, string key, string sValue, int iValue, RegistryValueKind type)
        {
            string value = sValue;//receberá o valor da chave
            if (sValue == null) //caso a chave não seja passada como string, então int
            {
                Registry.SetValue(userRoot, key, iValue, type);
                value = iValue.ToString();
            }
            else Registry.SetValue(userRoot, key, sValue, type); //caso contrario
            AddLog(tb, "RegEdit " + type + " " + key + " " + value);
        }

        //criação do arquivo bat na pasta de inicialização do windows para executar o comando de entrada no dominio
        //este comando é chamado quando ambos, mudança de host e entrada no dominio são selecionados, primeiro ocorre a 
        //alteração do host, reinicia-se e então o processo do domínio. Isto para que não ocorra erro com o domínio
        public static void WriteTempFile()
        {
            string[] aux ={"@echo off",">nul 2>&1 \"%SYSTEMROOT%\\system32\\cacls.exe\" \"%SYSTEMROOT%\\system32\\config\\system\"",
                    "if '%errorlevel%' NEQ '0' (","\tgoto UACPrompt",") else ( goto gotAdmin )",":UACPrompt",
                    "\techo Set UAC = CreateObject^(\"Shell.Application\"^) > \"%temp%\\getadmin.vbs\"","\tset params = %*:\"=\"\"",
                    "\techo UAC.ShellExecute \"cmd.exe\", \"/c %~s0 %params%\", \"\", \"runas\", 1 >> \"%temp%\\getadmin.vbs\"",
                    "\t\"%temp%\\getadmin.vbs\"","\tdel \"%temp%\\getadmin.vbs\"","\texit /B",":gotAdmin","\tpushd \"%CD%\"",
                    "\tCD /D \"%~dp0\"","\tgoto DOM",":DOM","powershell.exe add-computer -domainname ad.lit.inpe.br -credential LIT\\msc", 
                    "if %ERRORLEVEL% GEQ 1 goto DOM", "shutdown /r -t 3","(goto) 2>nul & del \"%~f0\""
                    };
            File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Microsoft\Windows\Start Menu\Programs\StartUp\Dominio.bat"), aux);
        }

        //chama janela que exige um nome para o Host, caso ele não tenha sido inserido
        public static void HostDialBox(RichTextBox tbLog, CheckBox cbHost)
        {
            FmHost testDialog = new FmHost();
            if (testDialog.ShowDialog() == DialogResult.OK)
            {
                msg = FileExec("cmd.exe", "/c wmic computersystem where name=\"%computername%\" call rename " + testDialog.tbHost2.Text, true) == 0 ? "Host alterado para " + testDialog.tbHost2.Text : "Operação cancelada";
                AddLog(tbLog, msg);
                cbHost.Enabled = true;
            }
            testDialog.Dispose();
        }

        //Comando de troca do Host
        public static void ChangeHost(RichTextBox tbLog, CheckBox cbHost)
        {
            
            HostDialBox(tbLog, cbHost);
            
        }

        //comando de entrada no dominio
        public static void DomainIngress(RichTextBox tbLog, CheckBox cbDominio)
        {
            if (cbDominio.Checked == true)
            {
                msg = FileExec("powershell.exe", @"/c add-computer -domainname ad.lit.inpe.br -credential LIT\msc", true) == 0 ? "Ingressando no Domínio: ad.lit.inpe.br" : "Operação cancelada";
                AddLog(tbLog, msg);
            }
        }

        //Edição dos registros do WSUS
        public static void WsusConfig(RichTextBox tbLog)
        {
            string userRoot = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate";
            EditReg(tbLog, userRoot, "ElevateNonAdmins", null, 1, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "ExcludeWUDriversInQualityUpdate", null, 1, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "SetProxyBehaviorForUpdateDetection", null, 0, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "WUServer", @"http://wsus.lit.inpe.br", 0, RegistryValueKind.ExpandString);
            EditReg(tbLog, userRoot, "WUStatusServer", @"http://wsus.lit.inpe.br", 0, RegistryValueKind.ExpandString);
            EditReg(tbLog, userRoot, "UpdateServiceUrlAlternate", @"http://wsus.lit.inpe.br", 0, RegistryValueKind.ExpandString);

            userRoot = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU";
            EditReg(tbLog, userRoot, "AUOptions", null, 3, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "UseWUServer", null, 1, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "NoAutoUpdate", null, 0, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "DetectionFrequency", null, 16, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "ScheduledInstallDay", null, 0, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "ScheduledInstallTime", null, 12, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "AutoInstallMinorUpdates", null, 1, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "DetectionFrequencyEnabled", null, 1, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "ScheduledInstallEveryWeek", null, 1, RegistryValueKind.DWord);
            EditReg(tbLog, userRoot, "NoAutoRebootWithLoggedOnUsers", null, 1, RegistryValueKind.DWord);
        }

        //Edição dos registros do WSUS
        public static void RemWsusConfig(RichTextBox tbLog)
        {
            string userRoot = @"SOFTWARE\Policies\Microsoft\Windows";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(userRoot, true))
            {
                if (key.OpenSubKey("WindowsUpdate") == null)
                {
                    MessageBox.Show("WSUS não consta na máquina");
                    AddLog(tbLog, "Não há o que remover");
                }
                else
                {
                    key.DeleteSubKeyTree("WindowsUpdate");
                    AddLog(tbLog, "WSUS deletado");
                }
            }

        }
        //ativa o RDP
        public static void RdpConfig(RichTextBox tbLog)
        {
            EditReg(tbLog, @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server", "fDenyTSConnections", null, 0, RegistryValueKind.DWord);
            msg = FileExec("powershell.exe", "/c netsh advfirewall firewall set rule group='Área de Trabalho Remota' new enable=yes", true) == 0 ? "Liberando Firewall de RDP" : "Operação cancelada";
            AddLog(tbLog, msg);
        }

        //ativa plano de alta performance
        public static void HighPerformance(RichTextBox tbLog)
        {
            EditReg(tbLog, @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server", "fDenyTSConnections", null, 0, RegistryValueKind.DWord);
            msg = FileExec("cmd.exe", "/c powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", true) == 0 ? "Ativando plano de alta performance" : "Operação cancelada";
            AddLog(tbLog, msg);
        }

        //instala os programas da pasta \\msc1\d\Automação\Programas
        public static void InstallAll(RichTextBox tbLog)
        {
            string dir = @"Automação\Programas" + architecture;
            //dir = @"\\msc1\d\Automação\Programas" + architecture;
            string[] mainDir = Directory.GetDirectories(dir);
            var file = new List<string>();
            string vnc = "";

            foreach (string subDir in mainDir)
            {
                foreach(string exec in Directory.GetFiles(subDir))
                {
                    if (exec.ToLower().Contains("setup") || exec.ToLower().Contains("ninite") || exec.ToLower().Contains("serial"))
                    {
                        if (exec.ToLower().Contains(".exe") || exec.ToLower().Contains(".msi") || exec.ToLower().Contains("serial.txt") || exec.ToLower().Contains(".bat"))
                        {
                            if (exec.ToLower().Contains("vnc"))
                            {
                                vnc = exec;
                            }
                            else
                            {
                                file.Add(exec);
                            }
                        }
                    }
                }
            }
            if (vnc != "") //executar o vnc com prioridade
            {
                AddLog(tbLog, "Instalando: " + Directory.GetParent(vnc).Name);
                FileExec(vnc, null, false);
            }
            foreach (string exec in file) //executa demais instaladores
            {
                if (exec.ToLower().Contains("serial.txt"))
                {
                    try
                    {
                        var content = File.ReadAllText(exec);
                        Clipboard.SetDataObject(content, false, 5, 200);
                    }
                    catch (System.ComponentModel.Win32Exception e) 
                    {
                        AddLog(tbLog, e.Message); 
                    }
                }
                else
                {
                    try
                    {
                        AddLog(tbLog, "Instalando: " + Directory.GetParent(exec).Name);
                        FileExec(exec, null, false);
                    }
                    catch (System.ComponentModel.Win32Exception e)
                    {
                        AddLog(tbLog, e.Message);
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }

        public static int FileExec(string filePath, string args, bool isPrompt)
        {
            if (args == null)
            {
                args = (Directory.GetParent(filePath)) + "/args.txt";
                if (File.Exists(args))
                {
                    args = File.ReadAllText(args);
                }
                else args = "";
            }
            try
            {
                bool op = true;
                Process process = new Process();
                do
                {
                    //MessageBox.Show(filePath + " " + args);
                    process.StartInfo.FileName = filePath;
                    process.StartInfo.Arguments = args;
                    process.EnableRaisingEvents = true;
                    if (isPrompt) process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();
                    process.WaitForExit();
                    if (process.ExitCode != 0) {
                        FmMigracao aviso = new FmMigracao();
                        op = aviso.ShowDialog() != DialogResult.OK;
                        aviso.Dispose();
                    }
                    else
                    {
                        op = true;
                    }

                } while (op != true);
            }
            catch (InvalidOperationException iex)
            {
                Interaction.MsgBox(iex.Message, MsgBoxStyle.OkOnly, MethodBase.GetCurrentMethod().Name);
                return 1;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, MethodBase.GetCurrentMethod().Name);
                return 1;
            }
            return 0;
        }

        public static bool GetIpStatus()
        {
            try
            {
                IPAddress endPoint = IPAddress.Parse("0.0.0.0");
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        endPoint = ip;
                    }
                }
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.Name.Contains("Ethernet") && nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    {

                        if (IPAddress.Parse("10.1.47.170").Equals(endPoint))
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            
            
            return true;
        }

        public static void SetIpButtonColor(CheckBox cbIpTeste, bool color)
        {
            if (color)
            {
                cbIpTeste.BackColor = Color.MediumTurquoise;
                cbIpTeste.FlatAppearance.BorderSize = 0;
            }
            else
            {
                cbIpTeste.BackColor = Color.WhiteSmoke;
                cbIpTeste.FlatAppearance.BorderSize = 1;
            }
        }

        public static void SetIpButton(CheckBox cbIpTeste, RichTextBox tbLog)
        {
            bool resul = GetIpStatus();
            SetIpButtonColor(cbIpTeste, resul);
            if (resul)
            {
                //MessageBox.Show($"netsh interface ipv4 set address {Ethernet} static 10.1.47.170 255.255.0.0 10.1.0.254");
                FileExec("netsh", $"interface ipv4 set address \"{Ethernet}\" static 10.1.47.170 255.255.0.0 10.1.0.254", true);
                FileExec("netsh", $"interface ipv4 set dns \"{Ethernet}\" static 10.1.0.30", true);
                AddLog(tbLog, "Ethernet:\nIP: 10.1.47.170 Mas: 255.255.0.0\nGW: 10.1.0.254 DNS: 10.1.0.30");
            }
            else
            {
                FileExec("netsh", $"interface ipv4 set address \"{Ethernet}\" dhcp", true);
                FileExec("netsh", $"interface ipv4 set dns \"{Ethernet}\" dhcp", true);
                AddLog(tbLog, "Ethernet:\nIP: DHCP Mas: DHCP \nGW: DHCP DNS: DHCP");

            }
        }
    }
}
