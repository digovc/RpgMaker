﻿namespace Rpg.Frm
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.tsmArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJogoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJogoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJogoCriar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReiniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExibirExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExibirPropriedade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExibirDados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExibirMixer = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdJogo = new System.Windows.Forms.OpenFileDialog();
            this.pnlDockRpg = new Rpg.Controle.DockPanelRpg();
            this.pnlAtalho = new Rpg.Controle.PainelAtalhoRpg();
            this.sfdJogo = new System.Windows.Forms.SaveFileDialog();
            this.tsmServidor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmServidorIniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArquivo,
            this.exibirToolStripMenuItem,
            this.tsmServidor});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnu.Size = new System.Drawing.Size(284, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // tsmArquivo
            // 
            this.tsmArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmJogoAbrir,
            this.tsmJogoSalvar,
            this.tsmJogoCriar,
            this.toolStripMenuItem1,
            this.tsmReiniciar});
            this.tsmArquivo.Name = "tsmArquivo";
            this.tsmArquivo.Size = new System.Drawing.Size(61, 20);
            this.tsmArquivo.Text = "Arquivo";
            // 
            // tsmJogoAbrir
            // 
            this.tsmJogoAbrir.Name = "tsmJogoAbrir";
            this.tsmJogoAbrir.Size = new System.Drawing.Size(119, 22);
            this.tsmJogoAbrir.Text = "Abrir";
            this.tsmJogoAbrir.Click += new System.EventHandler(this.tsmJogoAbrir_Click);
            // 
            // tsmJogoSalvar
            // 
            this.tsmJogoSalvar.Name = "tsmJogoSalvar";
            this.tsmJogoSalvar.Size = new System.Drawing.Size(119, 22);
            this.tsmJogoSalvar.Text = "Salvar";
            this.tsmJogoSalvar.Click += new System.EventHandler(this.tsmJogoSalvar_Click);
            // 
            // tsmJogoCriar
            // 
            this.tsmJogoCriar.Name = "tsmJogoCriar";
            this.tsmJogoCriar.Size = new System.Drawing.Size(119, 22);
            this.tsmJogoCriar.Text = "Criar";
            this.tsmJogoCriar.Click += new System.EventHandler(this.tsmJogoCriar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 6);
            // 
            // tsmReiniciar
            // 
            this.tsmReiniciar.Name = "tsmReiniciar";
            this.tsmReiniciar.Size = new System.Drawing.Size(119, 22);
            this.tsmReiniciar.Text = "Reiniciar";
            this.tsmReiniciar.Click += new System.EventHandler(this.tsmReiniciar_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExibirExplorer,
            this.tsmExibirPropriedade,
            this.tsmExibirDados,
            this.tsmExibirMixer});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // tsmExibirExplorer
            // 
            this.tsmExibirExplorer.Name = "tsmExibirExplorer";
            this.tsmExibirExplorer.Size = new System.Drawing.Size(152, 22);
            this.tsmExibirExplorer.Text = "Explorer";
            // 
            // tsmExibirPropriedade
            // 
            this.tsmExibirPropriedade.Name = "tsmExibirPropriedade";
            this.tsmExibirPropriedade.Size = new System.Drawing.Size(152, 22);
            this.tsmExibirPropriedade.Text = "Propriedades";
            this.tsmExibirPropriedade.Click += new System.EventHandler(this.tsmExibirPropriedade_Click);
            // 
            // tsmExibirDados
            // 
            this.tsmExibirDados.Name = "tsmExibirDados";
            this.tsmExibirDados.Size = new System.Drawing.Size(152, 22);
            this.tsmExibirDados.Text = "Dados";
            this.tsmExibirDados.Click += new System.EventHandler(this.tsmExibirDados_Click);
            // 
            // tsmExibirMixer
            // 
            this.tsmExibirMixer.Name = "tsmExibirMixer";
            this.tsmExibirMixer.Size = new System.Drawing.Size(152, 22);
            this.tsmExibirMixer.Text = "Mixer";
            this.tsmExibirMixer.Click += new System.EventHandler(this.tsmExibirMixer_Click);
            // 
            // pnlDockRpg
            // 
            this.pnlDockRpg.Name = "pnlDockRpg";
            this.pnlDockRpg.TabIndex = 1;
            // 
            // pnlAtalho
            // 
            this.pnlAtalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.pnlAtalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAtalho.Name = "pnlAtalho";
            this.pnlAtalho.TabIndex = 3;
            // 
            // tsmServidor
            // 
            this.tsmServidor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmServidorIniciar});
            this.tsmServidor.Name = "tsmServidor";
            this.tsmServidor.Size = new System.Drawing.Size(62, 20);
            this.tsmServidor.Text = "Servidor";
            // 
            // tsmServidorIniciar
            // 
            this.tsmServidorIniciar.Name = "tsmServidorIniciar";
            this.tsmServidorIniciar.Size = new System.Drawing.Size(152, 22);
            this.tsmServidorIniciar.Text = "Iniciar";
            this.tsmServidorIniciar.Click += new System.EventHandler(this.tsmServidorIniciar_Click);
            // 
            // FrmPrincipal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlDockRpg);
            this.Controls.Add(this.pnlAtalho);
            this.Controls.Add(this.mnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem tsmArquivo;
        private Controle.DockPanelRpg pnlDockRpg;
        private Controle.PainelAtalhoRpg pnlAtalho;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExibirExplorer;
        private System.Windows.Forms.ToolStripMenuItem tsmJogoCriar;
        private System.Windows.Forms.OpenFileDialog ofdJogo;
        private System.Windows.Forms.SaveFileDialog sfdJogo;
        private System.Windows.Forms.ToolStripMenuItem tsmJogoSalvar;
        private System.Windows.Forms.ToolStripMenuItem tsmJogoAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsmExibirPropriedade;
        private System.Windows.Forms.ToolStripMenuItem tsmExibirDados;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmReiniciar;
        private System.Windows.Forms.ToolStripMenuItem tsmExibirMixer;
        private System.Windows.Forms.ToolStripMenuItem tsmServidor;
        private System.Windows.Forms.ToolStripMenuItem tsmServidorIniciar;
    }
}