using System;
using System.Windows.Forms;

namespace AutomacaoMSC
{
    public partial class FmHost : Form
    {
        public FmHost()
        {
            InitializeComponent();
        }

        private void TbHost2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btOk.PerformClick();
            }
        }

        private void TbHost2_TextChanged(object sender, EventArgs e)
        {
            btOk.Enabled = !string.IsNullOrEmpty(tbHost2.Text);
        }
    }
}
