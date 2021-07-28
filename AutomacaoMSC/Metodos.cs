using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AutomacaoMSC
{
    class Metodos
    {
        //adiciona o evento ao painel de log
        public static void AddLog(TextBox tb, string msg)
        {
            tb.Visible = true; //garante que o painel esteja visivel
            tb.AppendText("-> " + msg + " ..." + Environment.NewLine); //adiciona o evento na ultima linha
        }

        //comandos relativos à edição do registro do windows
        public static void EditReg(TextBox tb, string userRoot, string key, string sValue, int iValue, RegistryValueKind type)
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
        public static void WriteTemp()
        {
            string[] aux ={"@echo off",">nul 2>&1 \"%SYSTEMROOT%\\system32\\cacls.exe\" \"%SYSTEMROOT%\\system32\\config\\system\"",
                    "if '%errorlevel%' NEQ '0' (","\tgoto UACPrompt",") else ( goto gotAdmin )",":UACPrompt",
                    "\techo Set UAC = CreateObject^(\"Shell.Application\"^) > \"%temp%\\getadmin.vbs\"","\tset params = %*:\"=\"\"",
                    "\techo UAC.ShellExecute \"cmd.exe\", \"/c %~s0 %params%\", \"\", \"runas\", 1 >> \"%temp%\\getadmin.vbs\"",
                    "\t\"%temp%\\getadmin.vbs\"","\tdel \"%temp%\\getadmin.vbs\"","\texit /B",":gotAdmin","\tpushd \"%CD%\"",
                    "\tCD /D \"%~dp0\"","\tgoto DOM",":DOM","powershell.exe add-computer -domainname ad.lit.inpe.br -credential LIT\\msc",
                    "shutdown /r -t 3","(goto) 2>nul & del \"%~f0\""
                    };
            File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Microsoft\Windows\Start Menu\Programs\StartUp\Dominio.bat"), aux);
        }

        //chama janela que exige um nome para o Host, caso ele não tenha sido inserido
        public static void HostDialBox(TextBox tbLog, CheckBox cbHost)
        {
            FmHost testDialog = new FmHost();
            if (testDialog.ShowDialog() == DialogResult.OK)
            {
                Process.Start("cmd.exe", "/c wmic computersystem where name=\"%computername%\" call rename " + testDialog.tbHost2.Text).WaitForExit();
                AddLog(tbLog, "Host alterado para " + testDialog.tbHost2.Text);
                cbHost.Enabled = true;
            }
            testDialog.Dispose();
        }

        //Comando de troca do Host
        public static void ChangeHost(TextBox tbLog, CheckBox cbHost)
        {
            
            HostDialBox(tbLog, cbHost);
            
        }

        //comando de entrada no dominio
        public static void Domain(TextBox tbLog, CheckBox cbDominio)
        {
            if (cbDominio.Checked == true)
            {
                Process.Start("powershell.exe", @"/c add-computer -domainname ad.lit.inpe.br -credential LIT\msc").WaitForExit();
                AddLog(tbLog, "Ingressando no Domínio: ad.lit.inpe.br");
            }
        }

        //Edição dos registros do WSUS
        public static void WsusConfig(TextBox tbLog)
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

        //ativa o RDP
        public static void RdpConfig(TextBox tbLog)
        {
            EditReg(tbLog, @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server", "fDenyTSConnections", null, 0, RegistryValueKind.DWord);
            Process.Start("powershell.exe", "/c netsh advfirewall firewall set rule group='Área de Trabalho Remota' new enable=yes").WaitForExit();
            AddLog(tbLog, "Firewall de RDP liberado");
        }

        //ativa plano de alta performance
        public static void HighPerformance(TextBox tbLog)
        {
            Process.Start("cmd.exe", "/c powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c").WaitForExit();
            AddLog(tbLog, "Ativando plano de alta performance");
        }

        //seleciona e instala os programas da pasta
        public static void InstallAll(TextBox tbLog)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "\\msc1\\d";
            dialog.IsFolderPicker = true;
            dialog.Title = "instaladores";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] fileEntries = Directory.GetFiles(dialog.FileName);
                FmInstaladores fmInst = new FmInstaladores();
                int i = 0;
                foreach (var f in fileEntries)
                {
                    fmInst.clbInstaladores.Items.Add(Path.GetFileName(f) + i);
                    fmInst.clbInstaladores.SetItemChecked(i++, true);
                }
                fmInst.clbInstaladores.Height = fmInst.clbInstaladores.GetItemRectangle(0).Height * fmInst.clbInstaladores.Items.Count;
                fmInst.clbInstaladores.MaximumSize = new System.Drawing.Size(fmInst.Width, 500);
                fmInst.Height += fmInst.clbInstaladores.Height;
                fmInst.panel1.Height += fmInst.clbInstaladores.Height;
                if (fmInst.ShowDialog() == DialogResult.OK)
                {

                }
                fmInst.Dispose();
                //foreach (string fileName in fileEntries)
                //{
                //    MessageBox.Show("You selected: " + Path.GetFileName(fileName));
                //}

            }
        }
    }
}
