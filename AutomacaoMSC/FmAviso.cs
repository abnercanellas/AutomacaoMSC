using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AutomacaoMSC
{
    public partial class FmAviso : Form
    {
        public FmAviso()
        {
            InitializeComponent();
        }

        private void BtSair3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtReiniciar_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 1");
        }
    }
}
