
namespace AutomacaoMSC
{
    partial class FmInstaladores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clbInstaladores = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btInstalar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbInstaladores
            // 
            this.clbInstaladores.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clbInstaladores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbInstaladores.CheckOnClick = true;
            this.clbInstaladores.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbInstaladores.ForeColor = System.Drawing.Color.Black;
            this.clbInstaladores.FormattingEnabled = true;
            this.clbInstaladores.Location = new System.Drawing.Point(35, 79);
            this.clbInstaladores.Name = "clbInstaladores";
            this.clbInstaladores.Size = new System.Drawing.Size(351, 16);
            this.clbInstaladores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(132, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btInstalar
            // 
            this.btInstalar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btInstalar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btInstalar.FlatAppearance.BorderSize = 0;
            this.btInstalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInstalar.Location = new System.Drawing.Point(339, 107);
            this.btInstalar.Name = "btInstalar";
            this.btInstalar.Size = new System.Drawing.Size(64, 27);
            this.btInstalar.TabIndex = 2;
            this.btInstalar.Text = "Instalar";
            this.btInstalar.UseVisualStyleBackColor = false;
            this.btInstalar.Click += new System.EventHandler(this.BtInstalar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Location = new System.Drawing.Point(258, 107);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(64, 27);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clbInstaladores);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btInstalar);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 145);
            this.panel1.TabIndex = 4;
            // 
            // FmInstaladores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(442, 161);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmInstaladores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Instaladores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox clbInstaladores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btInstalar;
        private System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.Panel panel1;
    }
}