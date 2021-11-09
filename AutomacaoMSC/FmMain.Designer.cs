using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutomacaoMSC
{
    partial class AutomacaoMSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomacaoMSC));
            this.btExecutar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lbMSC = new System.Windows.Forms.Label();
            this.lbVersao = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabExecutar = new System.Windows.Forms.TabPage();
            this.cbIpTeste = new System.Windows.Forms.CheckBox();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.ImgInpeMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDelWsus = new System.Windows.Forms.Button();
            this.btCompleta = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.cbInstalar = new System.Windows.Forms.CheckBox();
            this.cbHost = new System.Windows.Forms.CheckBox();
            this.cbDominio = new System.Windows.Forms.CheckBox();
            this.cbRDP = new System.Windows.Forms.CheckBox();
            this.cbPerformance = new System.Windows.Forms.CheckBox();
            this.cbWSUS = new System.Windows.Forms.CheckBox();
            this.tabSysInfo = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbMacs = new System.Windows.Forms.Label();
            this.lbSistema = new System.Windows.Forms.Label();
            this.lbArquitetura = new System.Windows.Forms.Label();
            this.tabSobre = new System.Windows.Forms.TabPage();
            this.lbPreguica = new System.Windows.Forms.Label();
            this.lbGit = new System.Windows.Forms.LinkLabel();
            this.lbPreGit = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.ldDescricao = new System.Windows.Forms.Label();
            this.ImgInpeSobre = new System.Windows.Forms.Panel();
            this.lbMSCSobre = new System.Windows.Forms.Label();
            this.tbMacs = new System.Windows.Forms.RichTextBox();
            this.tabMain.SuspendLayout();
            this.tabExecutar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSysInfo.SuspendLayout();
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
            this.btExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExecutar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btExecutar.Location = new System.Drawing.Point(351, 346);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(75, 23);
            this.btExecutar.TabIndex = 11;
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
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btSair.Location = new System.Drawing.Point(270, 346);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 10;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // lbMSC
            // 
            this.lbMSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbMSC.Location = new System.Drawing.Point(82, 6);
            this.lbMSC.Name = "lbMSC";
            this.lbMSC.Size = new System.Drawing.Size(354, 68);
            this.lbMSC.TabIndex = 5;
            this.lbMSC.Text = "Automação MSC - LIT";
            this.lbMSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVersao
            // 
            this.lbVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lbVersao.Location = new System.Drawing.Point(118, 319);
            this.lbVersao.Name = "lbVersao";
            this.lbVersao.Size = new System.Drawing.Size(218, 23);
            this.lbVersao.TabIndex = 0;
            this.lbVersao.Text = "BETA v0.00001Final";
            this.lbVersao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLog
            // 
            this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLog.Location = new System.Drawing.Point(33, 237);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(378, 92);
            this.tbLog.TabIndex = 6;
            this.tbLog.Text = "";
            this.tbLog.Visible = false;
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabExecutar);
            this.tabMain.Controls.Add(this.tabSysInfo);
            this.tabMain.Controls.Add(this.tabSobre);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(12, 5);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(450, 405);
            this.tabMain.TabIndex = 1;
            // 
            // tabExecutar
            // 
            this.tabExecutar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabExecutar.Controls.Add(this.cbIpTeste);
            this.tabExecutar.Controls.Add(this.btReiniciar);
            this.tabExecutar.Controls.Add(this.ImgInpeMain);
            this.tabExecutar.Controls.Add(this.tbLog);
            this.tabExecutar.Controls.Add(this.btExecutar);
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
            // cbIpTeste
            // 
            this.cbIpTeste.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbIpTeste.AutoSize = true;
            this.cbIpTeste.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbIpTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIpTeste.Location = new System.Drawing.Point(16, 346);
            this.cbIpTeste.Name = "cbIpTeste";
            this.cbIpTeste.Size = new System.Drawing.Size(57, 23);
            this.cbIpTeste.TabIndex = 13;
            this.cbIpTeste.Text = "IP Teste";
            this.cbIpTeste.UseVisualStyleBackColor = true;
            this.cbIpTeste.CheckedChanged += new System.EventHandler(this.CbIpTeste_CheckedChanged);
            // 
            // btReiniciar
            // 
            this.btReiniciar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btReiniciar.FlatAppearance.BorderSize = 0;
            this.btReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReiniciar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btReiniciar.Location = new System.Drawing.Point(189, 346);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btReiniciar.TabIndex = 12;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = false;
            this.btReiniciar.Click += new System.EventHandler(this.BtReiniciar_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btDelWsus);
            this.panel1.Controls.Add(this.btCompleta);
            this.panel1.Controls.Add(this.btLimpar);
            this.panel1.Controls.Add(this.cbInstalar);
            this.panel1.Controls.Add(this.cbHost);
            this.panel1.Controls.Add(this.cbDominio);
            this.panel1.Controls.Add(this.cbRDP);
            this.panel1.Controls.Add(this.cbPerformance);
            this.panel1.Controls.Add(this.cbWSUS);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 131);
            this.panel1.TabIndex = 2;
            // 
            // btDelWsus
            // 
            this.btDelWsus.BackColor = System.Drawing.Color.LightSlateGray;
            this.btDelWsus.FlatAppearance.BorderSize = 0;
            this.btDelWsus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelWsus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelWsus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btDelWsus.Location = new System.Drawing.Point(267, 12);
            this.btDelWsus.Name = "btDelWsus";
            this.btDelWsus.Size = new System.Drawing.Size(75, 23);
            this.btDelWsus.TabIndex = 10;
            this.btDelWsus.Text = "Del WSUS";
            this.btDelWsus.UseVisualStyleBackColor = false;
            this.btDelWsus.Click += new System.EventHandler(this.BtDelWsus_Click);
            // 
            // btCompleta
            // 
            this.btCompleta.BackColor = System.Drawing.Color.LightSlateGray;
            this.btCompleta.FlatAppearance.BorderSize = 0;
            this.btCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCompleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompleta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btCompleta.Location = new System.Drawing.Point(186, 12);
            this.btCompleta.Name = "btCompleta";
            this.btCompleta.Size = new System.Drawing.Size(75, 23);
            this.btCompleta.TabIndex = 3;
            this.btCompleta.Text = "Completa";
            this.btCompleta.UseVisualStyleBackColor = false;
            this.btCompleta.Click += new System.EventHandler(this.BtTodos_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btLimpar.Location = new System.Drawing.Point(105, 12);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.BtNenhum_Click);
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
            // tabSysInfo
            // 
            this.tabSysInfo.Controls.Add(this.tbMacs);
            this.tabSysInfo.Controls.Add(this.panel3);
            this.tabSysInfo.Controls.Add(this.lbMacs);
            this.tabSysInfo.Controls.Add(this.lbSistema);
            this.tabSysInfo.Controls.Add(this.lbArquitetura);
            this.tabSysInfo.Location = new System.Drawing.Point(4, 22);
            this.tabSysInfo.Name = "tabSysInfo";
            this.tabSysInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSysInfo.Size = new System.Drawing.Size(442, 379);
            this.tabSysInfo.TabIndex = 2;
            this.tabSysInfo.Text = "Sys Info";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::AutomacaoMSC.Properties.Resources.inpe_logo1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(333, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 46);
            this.panel3.TabIndex = 16;
            // 
            // lbMacs
            // 
            this.lbMacs.AutoSize = true;
            this.lbMacs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMacs.Location = new System.Drawing.Point(56, 81);
            this.lbMacs.Name = "lbMacs";
            this.lbMacs.Size = new System.Drawing.Size(45, 13);
            this.lbMacs.TabIndex = 12;
            this.lbMacs.Text = "Macs: ";
            // 
            // lbSistema
            // 
            this.lbSistema.AutoSize = true;
            this.lbSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSistema.Location = new System.Drawing.Point(56, 25);
            this.lbSistema.Name = "lbSistema";
            this.lbSistema.Size = new System.Drawing.Size(59, 13);
            this.lbSistema.TabIndex = 11;
            this.lbSistema.Text = "Sistema: ";
            // 
            // lbArquitetura
            // 
            this.lbArquitetura.AutoSize = true;
            this.lbArquitetura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArquitetura.Location = new System.Drawing.Point(56, 38);
            this.lbArquitetura.Name = "lbArquitetura";
            this.lbArquitetura.Size = new System.Drawing.Size(77, 13);
            this.lbArquitetura.TabIndex = 10;
            this.lbArquitetura.Text = "Arquitetura: ";
            // 
            // tabSobre
            // 
            this.tabSobre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabSobre.Controls.Add(this.lbPreguica);
            this.tabSobre.Controls.Add(this.lbGit);
            this.tabSobre.Controls.Add(this.lbPreGit);
            this.tabSobre.Controls.Add(this.lbAutor);
            this.tabSobre.Controls.Add(this.ldDescricao);
            this.tabSobre.Controls.Add(this.lbVersao);
            this.tabSobre.Controls.Add(this.ImgInpeSobre);
            this.tabSobre.Controls.Add(this.lbMSCSobre);
            this.tabSobre.Location = new System.Drawing.Point(4, 22);
            this.tabSobre.Name = "tabSobre";
            this.tabSobre.Padding = new System.Windows.Forms.Padding(3);
            this.tabSobre.Size = new System.Drawing.Size(442, 379);
            this.tabSobre.TabIndex = 0;
            this.tabSobre.Text = "Sobre";
            // 
            // lbPreguica
            // 
            this.lbPreguica.AutoSize = true;
            this.lbPreguica.Location = new System.Drawing.Point(127, 169);
            this.lbPreguica.Name = "lbPreguica";
            this.lbPreguica.Size = new System.Drawing.Size(198, 13);
            this.lbPreguica.TabIndex = 14;
            this.lbPreguica.Text = "Carinhosamente apilidado de \"Preguiça\"";
            // 
            // lbGit
            // 
            this.lbGit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGit.AutoSize = true;
            this.lbGit.Location = new System.Drawing.Point(296, 274);
            this.lbGit.Name = "lbGit";
            this.lbGit.Size = new System.Drawing.Size(40, 13);
            this.lbGit.TabIndex = 13;
            this.lbGit.TabStop = true;
            this.lbGit.Text = "GitHub";
            this.lbGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbGit_LinkClicked);
            // 
            // lbPreGit
            // 
            this.lbPreGit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPreGit.AutoSize = true;
            this.lbPreGit.Location = new System.Drawing.Point(103, 274);
            this.lbPreGit.Name = "lbPreGit";
            this.lbPreGit.Size = new System.Drawing.Size(199, 13);
            this.lbPreGit.TabIndex = 12;
            this.lbPreGit.Text = "O código aberto pode ser acessado em: ";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(189, 342);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(78, 13);
            this.lbAutor.TabIndex = 11;
            this.lbAutor.Text = "Abner Canellas";
            // 
            // ldDescricao
            // 
            this.ldDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ldDescricao.AutoSize = true;
            this.ldDescricao.Location = new System.Drawing.Point(103, 203);
            this.ldDescricao.Name = "ldDescricao";
            this.ldDescricao.Size = new System.Drawing.Size(240, 39);
            this.ldDescricao.TabIndex = 10;
            this.ldDescricao.Text = "Esse app foi desenvolvido com intuito de \nagilizar a configuração das maquinas at" +
    "ualizadas \n pela equipe MSC ";
            this.ldDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgInpeSobre
            // 
            this.ImgInpeSobre.BackgroundImage = global::AutomacaoMSC.Properties.Resources.inpe_logo1;
            this.ImgInpeSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgInpeSobre.Location = new System.Drawing.Point(163, 6);
            this.ImgInpeSobre.Name = "ImgInpeSobre";
            this.ImgInpeSobre.Size = new System.Drawing.Size(122, 105);
            this.ImgInpeSobre.TabIndex = 9;
            // 
            // lbMSCSobre
            // 
            this.lbMSCSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSCSobre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbMSCSobre.Location = new System.Drawing.Point(45, 114);
            this.lbMSCSobre.Name = "lbMSCSobre";
            this.lbMSCSobre.Size = new System.Drawing.Size(354, 68);
            this.lbMSCSobre.TabIndex = 8;
            this.lbMSCSobre.Text = "Automação MSC - LIT";
            this.lbMSCSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMacs
            // 
            this.tbMacs.BackColor = this.BackColor;
            this.tbMacs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMacs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMacs.Location = new System.Drawing.Point(59, 103);
            this.tbMacs.Name = "tbMacs";
            this.tbMacs.ReadOnly = true;
            this.tbMacs.Size = new System.Drawing.Size(322, 243);
            this.tbMacs.TabIndex = 17;
            this.tbMacs.TabStop = false;
            this.tbMacs.Text = "";
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
            this.tabMain.ResumeLayout(false);
            this.tabExecutar.ResumeLayout(false);
            this.tabExecutar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabSysInfo.ResumeLayout(false);
            this.tabSysInfo.PerformLayout();
            this.tabSobre.ResumeLayout(false);
            this.tabSobre.PerformLayout();
            this.ResumeLayout(false);

        }

        private Button btExecutar;
        private Button btSair;
        private RichTextBox tbLog;
        private Label lbVersao;
        private Label lbMSC;
        private TabControl tabMain;
        private TabPage tabExecutar;
        private TabPage tabSobre;
        private Panel ImgInpeMain;
        private Panel ImgInpeSobre;
        private Label lbMSCSobre;
        private Label lbAutor;
        private Label ldDescricao;
        private LinkLabel lbGit;
        private Label lbPreGit;
        private Button btReiniciar;
        private Panel panel1;
        private Button btCompleta;
        private Button btLimpar;
        public CheckBox cbInstalar;
        public CheckBox cbHost;
        public CheckBox cbDominio;
        public CheckBox cbRDP;
        public CheckBox cbPerformance;
        public CheckBox cbWSUS;
        public Button btDelWsus;
        public Label lbPreguica;
        public CheckBox cbIpTeste;
        private TabPage tabSysInfo;
        private Label lbSistema;
        private Label lbArquitetura;
        private Label lbMacs;
        private Panel panel3;
        private RichTextBox tbMacs;
    }
}

