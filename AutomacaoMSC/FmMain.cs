﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using static AutomacaoMSC.Metodos;

namespace AutomacaoMSC
{
    public partial class AutomacaoMSC : Form
    {
        public AutomacaoMSC()
        {
            InitializeComponent();
            lbSistema.Text += Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion")?.GetValue("productName");
            lbArquitetura.Text = "Arquitetura: " + architecture;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtInstalar_Click(object sender, EventArgs e)
        {
            if (!(cbInstalar.Checked || cbHost.Checked || cbDominio.Checked || cbRDP.Checked || cbPerformance.Checked || cbWSUS.Checked))
            {
                new FmSelecOp().ShowDialog(this);
            }
            else
            {
                tbLog.Text = "";
                if (cbHost.Checked == true || cbDominio.Checked == true)
                {
                    //FmMigracao fmm = new FmMigracao();
                    //if (fmm.ShowDialog() == DialogResult.OK)
                    //{
                    //    MessageBox.Show("yahuu");
                    //}
                    //else
                    //{
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
                    //}
                    //fmm.Dispose();
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
    }
}

