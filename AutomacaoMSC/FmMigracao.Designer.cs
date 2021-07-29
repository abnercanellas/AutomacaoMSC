
namespace AutomacaoMSC
{
    partial class FmMigracao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMigracao));
            this.btNao = new System.Windows.Forms.Button();
            this.btSim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMigracao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNao
            // 
            this.btNao.BackColor = System.Drawing.Color.LightSlateGray;
            this.btNao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNao.FlatAppearance.BorderSize = 0;
            this.btNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNao.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btNao.Location = new System.Drawing.Point(100, 88);
            this.btNao.Name = "btNao";
            this.btNao.Size = new System.Drawing.Size(64, 27);
            this.btNao.TabIndex = 0;
            this.btNao.Text = "Não";
            this.btNao.UseVisualStyleBackColor = false;
            // 
            // btSim
            // 
            this.btSim.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btSim.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSim.FlatAppearance.BorderSize = 0;
            this.btSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSim.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btSim.Location = new System.Drawing.Point(190, 88);
            this.btSim.Name = "btSim";
            this.btSim.Size = new System.Drawing.Size(64, 27);
            this.btSim.TabIndex = 1;
            this.btSim.Text = "Sim";
            this.btSim.UseVisualStyleBackColor = false;
            this.btSim.Click += new System.EventHandler(this.BtSim_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbMigracao);
            this.panel1.Controls.Add(this.btNao);
            this.panel1.Controls.Add(this.btSim);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 135);
            this.panel1.TabIndex = 2;
            // 
            // lbMigracao
            // 
            this.lbMigracao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMigracao.AutoSize = true;
            this.lbMigracao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMigracao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lbMigracao.Location = new System.Drawing.Point(17, 13);
            this.lbMigracao.Name = "lbMigracao";
            this.lbMigracao.Size = new System.Drawing.Size(322, 44);
            this.lbMigracao.TabIndex = 2;
            this.lbMigracao.Text = "Isso é uma migração de máquina \npara o Domínio?";
            this.lbMigracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmMigracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btNao;
            this.ClientSize = new System.Drawing.Size(369, 146);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FmMigracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Isso é uma migração?";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btNao;
        private System.Windows.Forms.Button btSim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMigracao;
    }
}