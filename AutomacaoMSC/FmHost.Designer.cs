namespace AutomacaoMSC
{
    partial class FmHost
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmHost));
            this.lbHost2 = new System.Windows.Forms.Label();
            this.tbHost2 = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHost2
            // 
            this.lbHost2.AutoSize = true;
            this.lbHost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHost2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lbHost2.Location = new System.Drawing.Point(9, 13);
            this.lbHost2.Name = "lbHost2";
            this.lbHost2.Size = new System.Drawing.Size(191, 33);
            this.lbHost2.TabIndex = 0;
            this.lbHost2.Text = "Defina o Host";
            // 
            // tbHost2
            // 
            this.tbHost2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbHost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHost2.Location = new System.Drawing.Point(54, 67);
            this.tbHost2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHost2.MaxLength = 10;
            this.tbHost2.Name = "tbHost2";
            this.tbHost2.Size = new System.Drawing.Size(116, 31);
            this.tbHost2.TabIndex = 1;
            this.tbHost2.TextChanged += new System.EventHandler(this.TbHost2_TextChanged);
            this.tbHost2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbHost2_KeyDown);
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Enabled = false;
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btOk.Location = new System.Drawing.Point(81, 106);
            this.btOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(64, 27);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbHost2);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 146);
            this.panel1.TabIndex = 3;
            // 
            // FmHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(224, 159);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbHost2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(224, 159);
            this.MinimumSize = new System.Drawing.Size(224, 159);
            this.Name = "FmHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E o Host, meu chapa?";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lbHost2;
        private System.Windows.Forms.Button btOk;
        public System.Windows.Forms.TextBox tbHost2;
        private System.Windows.Forms.Panel panel1;
    }
}