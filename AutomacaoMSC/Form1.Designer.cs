namespace AutomacaoMSC
{
    partial class FmSeleciona
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCompleta = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.cbInstalar = new System.Windows.Forms.CheckBox();
            this.cbHost = new System.Windows.Forms.CheckBox();
            this.cbDominio = new System.Windows.Forms.CheckBox();
            this.cbRDP = new System.Windows.Forms.CheckBox();
            this.cbPerformance = new System.Windows.Forms.CheckBox();
            this.cbWSUS = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCompleta);
            this.panel1.Controls.Add(this.btLimpar);
            this.panel1.Controls.Add(this.cbInstalar);
            this.panel1.Controls.Add(this.cbHost);
            this.panel1.Controls.Add(this.cbDominio);
            this.panel1.Controls.Add(this.cbRDP);
            this.panel1.Controls.Add(this.cbPerformance);
            this.panel1.Controls.Add(this.cbWSUS);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(50, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 131);
            this.panel1.TabIndex = 3;
            // 
            // btCompleta
            // 
            this.btCompleta.BackColor = System.Drawing.Color.LightSlateGray;
            this.btCompleta.FlatAppearance.BorderSize = 0;
            this.btCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCompleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompleta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btCompleta.Location = new System.Drawing.Point(222, 12);
            this.btCompleta.Name = "btCompleta";
            this.btCompleta.Size = new System.Drawing.Size(75, 23);
            this.btCompleta.TabIndex = 3;
            this.btCompleta.Text = "Completa";
            this.btCompleta.UseVisualStyleBackColor = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btLimpar.Location = new System.Drawing.Point(127, 12);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            // 
            // cbInstalar
            // 
            this.cbInstalar.Checked = true;
            this.cbInstalar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInstalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstalar.Location = new System.Drawing.Point(42, 100);
            this.cbInstalar.Name = "cbInstalar";
            this.cbInstalar.Size = new System.Drawing.Size(124, 19);
            this.cbInstalar.TabIndex = 6;
            this.cbInstalar.Text = "Instalar programas";
            this.cbInstalar.UseVisualStyleBackColor = true;
            // 
            // cbHost
            // 
            this.cbHost.Checked = true;
            this.cbHost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHost.Location = new System.Drawing.Point(189, 75);
            this.cbHost.Name = "cbHost";
            this.cbHost.Size = new System.Drawing.Size(140, 19);
            this.cbHost.TabIndex = 8;
            this.cbHost.Text = "Renomear Host";
            this.cbHost.UseVisualStyleBackColor = true;
            // 
            // cbDominio
            // 
            this.cbDominio.Checked = true;
            this.cbDominio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDominio.Location = new System.Drawing.Point(189, 100);
            this.cbDominio.Name = "cbDominio";
            this.cbDominio.Size = new System.Drawing.Size(221, 19);
            this.cbDominio.TabIndex = 9;
            this.cbDominio.Text = "Ingressar no Dominio ad.lit.inpe.br";
            this.cbDominio.UseVisualStyleBackColor = true;
            // 
            // cbRDP
            // 
            this.cbRDP.Checked = true;
            this.cbRDP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRDP.Location = new System.Drawing.Point(42, 75);
            this.cbRDP.Name = "cbRDP";
            this.cbRDP.Size = new System.Drawing.Size(91, 19);
            this.cbRDP.TabIndex = 5;
            this.cbRDP.Text = "Ativar RDP";
            this.cbRDP.UseVisualStyleBackColor = true;
            // 
            // cbPerformance
            // 
            this.cbPerformance.Checked = true;
            this.cbPerformance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerformance.Location = new System.Drawing.Point(189, 50);
            this.cbPerformance.Name = "cbPerformance";
            this.cbPerformance.Size = new System.Drawing.Size(221, 19);
            this.cbPerformance.TabIndex = 7;
            this.cbPerformance.Text = "Ativar plano de alta performance";
            this.cbPerformance.UseVisualStyleBackColor = true;
            // 
            // cbWSUS
            // 
            this.cbWSUS.Checked = true;
            this.cbWSUS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWSUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWSUS.Location = new System.Drawing.Point(42, 50);
            this.cbWSUS.Name = "cbWSUS";
            this.cbWSUS.Size = new System.Drawing.Size(117, 19);
            this.cbWSUS.TabIndex = 4;
            this.cbWSUS.Text = "Configurar WSUS";
            this.cbWSUS.UseVisualStyleBackColor = true;
            // 
            // FmSeleciona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 272);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmSeleciona";
            this.Text = "Selecione...";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCompleta;
        private System.Windows.Forms.Button btLimpar;
        public System.Windows.Forms.CheckBox cbInstalar;
        public System.Windows.Forms.CheckBox cbHost;
        public System.Windows.Forms.CheckBox cbDominio;
        public System.Windows.Forms.CheckBox cbRDP;
        public System.Windows.Forms.CheckBox cbPerformance;
        public System.Windows.Forms.CheckBox cbWSUS;
    }
}