using System.Windows.Forms;

namespace AutomacaoMSC
{
    partial class AutomacaoMSC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomacaoMSC));
            this.btExecutar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lbMSC = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTodos = new System.Windows.Forms.Button();
            this.btNenhum = new System.Windows.Forms.Button();
            this.cbInstalar = new System.Windows.Forms.CheckBox();
            this.cbHost = new System.Windows.Forms.CheckBox();
            this.cbDominio = new System.Windows.Forms.CheckBox();
            this.cbRDP = new System.Windows.Forms.CheckBox();
            this.cbPerformance = new System.Windows.Forms.CheckBox();
            this.cbWSUS = new System.Windows.Forms.CheckBox();
            this.lbVersao = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabExecutar = new System.Windows.Forms.TabPage();
            this.ImgInpeMain = new System.Windows.Forms.Panel();
            this.tabSobre = new System.Windows.Forms.TabPage();
            this.ImgInpeSobre = new System.Windows.Forms.Panel();
            this.lbMSCSobre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabExecutar.SuspendLayout();
            this.tabSobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExecutar
            // 
            this.btExecutar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExecutar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btExecutar.FlatAppearance.BorderSize = 0;
            this.btExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExecutar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btExecutar.Location = new System.Drawing.Point(351, 353);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(75, 23);
            this.btExecutar.TabIndex = 4;
            this.btExecutar.Text = "Executar";
            this.btExecutar.UseVisualStyleBackColor = false;
            this.btExecutar.Click += new System.EventHandler(this.BtInstalar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.LightSlateGray;
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btSair.Location = new System.Drawing.Point(270, 353);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // lbMSC
            // 
            this.lbMSC.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbMSC.Location = new System.Drawing.Point(82, 6);
            this.lbMSC.Name = "lbMSC";
            this.lbMSC.Size = new System.Drawing.Size(354, 68);
            this.lbMSC.TabIndex = 5;
            this.lbMSC.Text = "Automação MSC - LIT";
            this.lbMSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(0, 353);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(169, 20);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btTodos);
            this.panel1.Controls.Add(this.btNenhum);
            this.panel1.Controls.Add(this.cbInstalar);
            this.panel1.Controls.Add(this.cbHost);
            this.panel1.Controls.Add(this.cbDominio);
            this.panel1.Controls.Add(this.cbRDP);
            this.panel1.Controls.Add(this.cbPerformance);
            this.panel1.Controls.Add(this.cbWSUS);
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 131);
            this.panel1.TabIndex = 2;
            // 
            // btTodos
            // 
            this.btTodos.BackColor = System.Drawing.Color.LightSlateGray;
            this.btTodos.FlatAppearance.BorderSize = 0;
            this.btTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTodos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btTodos.Location = new System.Drawing.Point(235, 12);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(75, 23);
            this.btTodos.TabIndex = 8;
            this.btTodos.Text = "Todos";
            this.btTodos.UseVisualStyleBackColor = false;
            this.btTodos.Click += new System.EventHandler(this.BtTodos_Click);
            // 
            // btNenhum
            // 
            this.btNenhum.BackColor = System.Drawing.Color.LightSlateGray;
            this.btNenhum.FlatAppearance.BorderSize = 0;
            this.btNenhum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNenhum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btNenhum.Location = new System.Drawing.Point(131, 12);
            this.btNenhum.Name = "btNenhum";
            this.btNenhum.Size = new System.Drawing.Size(75, 23);
            this.btNenhum.TabIndex = 7;
            this.btNenhum.Text = "Nenhum";
            this.btNenhum.UseVisualStyleBackColor = false;
            this.btNenhum.Click += new System.EventHandler(this.BtNenhum_Click);
            // 
            // cbInstalar
            // 
            this.cbInstalar.Checked = true;
            this.cbInstalar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInstalar.Location = new System.Drawing.Point(55, 100);
            this.cbInstalar.Name = "cbInstalar";
            this.cbInstalar.Size = new System.Drawing.Size(124, 19);
            this.cbInstalar.TabIndex = 1;
            this.cbInstalar.Text = "Instalar programas";
            this.cbInstalar.UseVisualStyleBackColor = true;
            // 
            // cbHost
            // 
            this.cbHost.Checked = true;
            this.cbHost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHost.Location = new System.Drawing.Point(202, 75);
            this.cbHost.Name = "cbHost";
            this.cbHost.Size = new System.Drawing.Size(108, 19);
            this.cbHost.TabIndex = 2;
            this.cbHost.Text = "Renomear Host";
            this.cbHost.UseVisualStyleBackColor = true;
            // 
            // cbDominio
            // 
            this.cbDominio.Checked = true;
            this.cbDominio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDominio.Location = new System.Drawing.Point(202, 100);
            this.cbDominio.Name = "cbDominio";
            this.cbDominio.Size = new System.Drawing.Size(208, 19);
            this.cbDominio.TabIndex = 3;
            this.cbDominio.Text = "Ingressar no Dominio ad.lit.inpe.br";
            this.cbDominio.UseVisualStyleBackColor = true;
            // 
            // cbRDP
            // 
            this.cbRDP.Checked = true;
            this.cbRDP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRDP.Location = new System.Drawing.Point(55, 75);
            this.cbRDP.Name = "cbRDP";
            this.cbRDP.Size = new System.Drawing.Size(82, 19);
            this.cbRDP.TabIndex = 4;
            this.cbRDP.Text = "Ativar RDP";
            this.cbRDP.UseVisualStyleBackColor = true;
            // 
            // cbPerformance
            // 
            this.cbPerformance.Checked = true;
            this.cbPerformance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPerformance.Location = new System.Drawing.Point(202, 50);
            this.cbPerformance.Name = "cbPerformance";
            this.cbPerformance.Size = new System.Drawing.Size(199, 19);
            this.cbPerformance.TabIndex = 5;
            this.cbPerformance.Text = "Ativar plano de alta performance";
            this.cbPerformance.UseVisualStyleBackColor = true;
            // 
            // cbWSUS
            // 
            this.cbWSUS.Checked = true;
            this.cbWSUS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWSUS.Location = new System.Drawing.Point(55, 50);
            this.cbWSUS.Name = "cbWSUS";
            this.cbWSUS.Size = new System.Drawing.Size(117, 19);
            this.cbWSUS.TabIndex = 6;
            this.cbWSUS.Text = "Configurar WSUS";
            this.cbWSUS.UseVisualStyleBackColor = true;
            // 
            // lbVersao
            // 
            this.lbVersao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lbVersao.Location = new System.Drawing.Point(111, 322);
            this.lbVersao.Name = "lbVersao";
            this.lbVersao.Size = new System.Drawing.Size(218, 54);
            this.lbVersao.TabIndex = 0;
            this.lbVersao.Text = "BETA v0.00000013548  AbnerCanellas";
            this.lbVersao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(0, 215);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(436, 132);
            this.tbLog.TabIndex = 6;
            this.tbLog.Visible = false;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabExecutar);
            this.tabMain.Controls.Add(this.tabSobre);
            this.tabMain.Location = new System.Drawing.Point(12, 5);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(450, 405);
            this.tabMain.TabIndex = 7;
            // 
            // tabExecutar
            // 
            this.tabExecutar.BackColor = System.Drawing.Color.Transparent;
            this.tabExecutar.Controls.Add(this.ImgInpeMain);
            this.tabExecutar.Controls.Add(this.tbLog);
            this.tabExecutar.Controls.Add(this.btExecutar);
            this.tabExecutar.Controls.Add(this.progressBar1);
            this.tabExecutar.Controls.Add(this.btSair);
            this.tabExecutar.Controls.Add(this.panel1);
            this.tabExecutar.Controls.Add(this.lbMSC);
            this.tabExecutar.Location = new System.Drawing.Point(4, 22);
            this.tabExecutar.Name = "tabExecutar";
            this.tabExecutar.Padding = new System.Windows.Forms.Padding(3);
            this.tabExecutar.Size = new System.Drawing.Size(442, 379);
            this.tabExecutar.TabIndex = 1;
            this.tabExecutar.Text = "Executar";
            // 
            // ImgInpeMain
            // 
            this.ImgInpeMain.BackgroundImage = global::AutomacaoMSC.Properties.Resources.inpe_logo1;
            this.ImgInpeMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgInpeMain.Location = new System.Drawing.Point(16, 6);
            this.ImgInpeMain.Name = "ImgInpeMain";
            this.ImgInpeMain.Size = new System.Drawing.Size(73, 68);
            this.ImgInpeMain.TabIndex = 7;
            // 
            // tabSobre
            // 
            this.tabSobre.Controls.Add(this.lbVersao);
            this.tabSobre.Controls.Add(this.ImgInpeSobre);
            this.tabSobre.Controls.Add(this.lbMSCSobre);
            this.tabSobre.Location = new System.Drawing.Point(4, 22);
            this.tabSobre.Name = "tabSobre";
            this.tabSobre.Padding = new System.Windows.Forms.Padding(3);
            this.tabSobre.Size = new System.Drawing.Size(442, 379);
            this.tabSobre.TabIndex = 0;
            this.tabSobre.Text = "Sobre";
            this.tabSobre.UseVisualStyleBackColor = true;
            // 
            // ImgInpeSobre
            // 
            this.ImgInpeSobre.BackgroundImage = global::AutomacaoMSC.Properties.Resources.inpe_logo1;
            this.ImgInpeSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgInpeSobre.Location = new System.Drawing.Point(153, 6);
            this.ImgInpeSobre.Name = "ImgInpeSobre";
            this.ImgInpeSobre.Size = new System.Drawing.Size(122, 105);
            this.ImgInpeSobre.TabIndex = 9;
            // 
            // lbMSCSobre
            // 
            this.lbMSCSobre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSCSobre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbMSCSobre.Location = new System.Drawing.Point(45, 114);
            this.lbMSCSobre.Name = "lbMSCSobre";
            this.lbMSCSobre.Size = new System.Drawing.Size(354, 68);
            this.lbMSCSobre.TabIndex = 8;
            this.lbMSCSobre.Text = "Automação MSC - LIT";
            this.lbMSCSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutomacaoMSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 426);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(490, 465);
            this.MinimumSize = new System.Drawing.Size(490, 465);
            this.Name = "AutomacaoMSC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automação MSC LIT";
            this.panel1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabExecutar.ResumeLayout(false);
            this.tabExecutar.PerformLayout();
            this.tabSobre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btExecutar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbInstalar;
        private System.Windows.Forms.CheckBox cbHost;
        private System.Windows.Forms.CheckBox cbDominio;
        private System.Windows.Forms.CheckBox cbRDP;
        private System.Windows.Forms.CheckBox cbPerformance;
        private System.Windows.Forms.CheckBox cbWSUS;
        private System.Windows.Forms.TextBox tbLog;
        private Label lbVersao;
        private Label lbMSC;
        private Button btNenhum;
        private Button btTodos;
        private TabControl tabMain;
        private TabPage tabExecutar;
        private TabPage tabSobre;
        private Panel ImgInpeMain;
        private Panel ImgInpeSobre;
        private Label lbMSCSobre;
    }
}

