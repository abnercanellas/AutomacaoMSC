using System;
using System.Windows.Forms;
using static AutomacaoMSC.Metodos;

namespace AutomacaoMSC
{
    public partial class AutomacaoMSC : Form
    {
        public AutomacaoMSC()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtInstalar_Click(object sender, EventArgs e)
        {
            if (cbInstalar.Checked == true)
            {
                InstallAll(tbLog);
            }
            if (cbHost.Checked == true || cbDominio.Checked == true)
            {
                if (cbHost.Checked == true)
                {
                    ChangeHost(tbLog, cbHost);
                }
                if (cbHost.Checked == true && cbDominio.Checked == true)
                {
                    WriteTemp();
                }
                else
                {
                    Domain(tbLog, cbDominio);
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
            CheckBoxHide(true);
            new FmAviso().ShowDialog(this);
            AddLog(tbLog, "PRONTO!");
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
    }
}

