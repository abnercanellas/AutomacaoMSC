using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AutomacaoMSC
{
    public partial class FmFeito : Form
    {
        public FmFeito()
        {
            InitializeComponent();
        }

        private void BtSair3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtReiniciar_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 3");
        }
    }
}
