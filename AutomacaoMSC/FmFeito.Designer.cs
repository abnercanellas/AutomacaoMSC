namespace AutomacaoMSC
{
    partial class FmFeito
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmFeito));
            this.lbFeito = new System.Windows.Forms.Label();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFeito
            // 
            this.lbFeito.AutoSize = true;
            this.lbFeito.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lbFeito.Location = new System.Drawing.Point(63, 34);
            this.lbFeito.Name = "lbFeito";
            this.lbFeito.Size = new System.Drawing.Size(79, 30);
            this.lbFeito.TabIndex = 0;
            this.lbFeito.Text = "Feito!";
            // 
            // btReiniciar
            // 
            this.btReiniciar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btReiniciar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btReiniciar.FlatAppearance.BorderSize = 0;
            this.btReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReiniciar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReiniciar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btReiniciar.Location = new System.Drawing.Point(111, 88);
            this.btReiniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(71, 27);
            this.btReiniciar.TabIndex = 2;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = false;
            this.btReiniciar.Click += new System.EventHandler(this.BtReiniciar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btReiniciar);
            this.panel1.Controls.Add(this.btSair3);
            this.panel1.Controls.Add(this.lbFeito);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 146);
            this.panel1.TabIndex = 3;
            // 
            // btSair3
            // 
            this.btSair3.BackColor = System.Drawing.Color.LightSlateGray;
            this.btSair3.FlatAppearance.BorderSize = 0;
            this.btSair3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btSair3.Location = new System.Drawing.Point(30, 88);
            this.btSair3.Name = "btSair3";
            this.btSair3.Size = new System.Drawing.Size(64, 27);
            this.btSair3.TabIndex = 1;
            this.btSair3.Text = "Sair";
            this.btSair3.UseVisualStyleBackColor = false;
            this.btSair3.Click += new System.EventHandler(this.BtSair3_Click);
            // 
            // FmFeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(224, 159);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(224, 159);
            this.MinimumSize = new System.Drawing.Size(224, 159);
            this.Name = "FmFeito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dá-lheee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFeito;
        private System.Windows.Forms.Button btReiniciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSair3;
    }
}
