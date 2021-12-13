using System;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static AutomacaoMSC.Metodos;

namespace AutomacaoMSC
{
    public partial class AutomacaoMSC : Form
    {
        private static ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
        public AutomacaoMSC()
        {
            InitializeComponent();
            lbSistema.Text += Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion")?.GetValue("productName");
            lbArquitetura.Text = "Arquitetura: " + architecture;
            SetIpButtonColor(cbIpTeste, !GetIpStatus());
            foreach (var item in GetMacs())
            {
                tbMacs.Text += item.Key;
                tbMacs.Text += "\t" + item.Value + Environment.NewLine + Environment.NewLine;
            }

            //foreach (ManagementObject queryObj in baseboardSearcher.Get())
            //{
            //    string s = queryObj["SerialNumber"].ToString();
            //    string[] ab = s.Split('/');
            //    //foreach (string item in ab)
            //    //{
            //    //    if(item.Contains("BR"))
            //    //}
            //    MessageBox.Show(queryObj["SerialNumber"].ToString());
            //}
            
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtInstalar_Click(object sender, EventArgs e)
        {
            if (!(cbInstalar.Checked || cbHost.Checked || cbDominio.Checked || cbRDP.Checked || cbPerformance.Checked || cbWSUS.Checked))
            {
                //new FmSelecOp().ShowDialog(this);
            }
            else
            {
                tbLog.Text = "";
                if (cbHost.Checked == true || cbDominio.Checked == true)
                {
                    if (cbHost.Checked == true)
                    {
                        ChangeHost(tbLog, cbHost);
                    }
                    if (cbHost.Checked == true && cbDominio.Checked == true)
                    {
                        WriteTempFile();
                    }
                    else
                    {
                      DomainIngress(tbLog, cbDominio);
                    }
                }
                if (cbRDP.Checked == true)
                {
                    RdpConfig(tbLog);
                }
                if (cbPerformance.Checked == true)
                {
                    HighPerformance(tbLog);
                }
                if (cbWSUS.Checked == true)
                {
                    WsusConfig(tbLog);
                }
                if (cbInstalar.Checked == true)
                {
                    InstallAll(tbLog);
                }
                CheckBoxHide(true);
                new FmFeito().ShowDialog(this);
                AddLog(tbLog, "PRONTO!");
            }
        }

        private void BtNenhum_Click(object sender, EventArgs e)
        {
            CheckBoxHide(true);
        }

        private void BtTodos_Click(object sender, EventArgs e)
        {
            CheckBoxHide(false);
        }

        private void CheckBoxHide(Boolean hide)
        {
            if (hide)
            {
                cbWSUS.Checked = false;
                cbPerformance.Checked = false;
                cbRDP.Checked = false;
                cbDominio.Checked = false;
                cbHost.Checked = false;
                cbInstalar.Checked = false;
            }
            else
            {
                cbWSUS.Checked = true;
                cbPerformance.Checked = true;
                cbRDP.Checked = true;
                cbDominio.Checked = true;
                cbHost.Checked = true;
                cbInstalar.Checked = true;
            }
        }

        private void LbGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/abnercanellas/AutomacaoMSC/tree/master/AutomacaoMSC");
        }

        private void BtReiniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O computador reiniciará após clicar em Ok!");
            Process.Start("shutdown", "/r /t 1");
        }

        private void BtDelWsus_Click(object sender, EventArgs e)
        {
            //RemWsusConfig(tbLog);
            GetAllIps();
        }

        private void CbIpTeste_CheckedChanged(object sender, EventArgs e)
        {
            SetIpButton(cbIpTeste, tbLog);
        }

        public void GetAllIps()
        {
            // Get host name
            String strHostName = Dns.GetHostName(), msg="";

            // Find host by name
            IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);
            // Enumerate IP addresses
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                msg += ipaddress.ToString() + Environment.NewLine;
            }
            MessageBox.Show(msg);
        }

    }
}

