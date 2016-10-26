﻿namespace Rpg.Controle.Painel
{
    partial class PnlAtributoGrupo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlTitulo = new Rpg.Controle.Painel.PnlRpgTitulo();
            this.pnlComando = new System.Windows.Forms.Panel();
            this.btnVisivel = new DigoFramework.Controle.Botao.BotaoAtalho();
            this.pnlComando.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.AutoSize = true;
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 38);
            this.pnlConteudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(200, 62);
            this.pnlConteudo.TabIndex = 2;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.booTituloFixo = false;
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 18);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(200, 20);
            this.pnlTitulo.strTitulo = "Título";
            this.pnlTitulo.TabIndex = 0;
            // 
            // pnlComando
            // 
            this.pnlComando.Controls.Add(this.btnVisivel);
            this.pnlComando.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComando.Location = new System.Drawing.Point(0, 0);
            this.pnlComando.Margin = new System.Windows.Forms.Padding(4);
            this.pnlComando.Name = "pnlComando";
            this.pnlComando.Size = new System.Drawing.Size(200, 18);
            this.pnlComando.TabIndex = 3;
            // 
            // btnVisivel
            // 
            this.btnVisivel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVisivel.Name = "btnVisivel";
            this.btnVisivel.TabIndex = 2;
            this.btnVisivel.Click += new System.EventHandler(this.btnVisivel_Click);
            // 
            // PnlAtributoGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlComando);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PnlAtributoGrupo";
            this.Size = new System.Drawing.Size(200, 100);
            this.pnlComando.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlConteudo;
        private PnlRpgTitulo pnlTitulo;
        private System.Windows.Forms.Panel pnlComando;
        private DigoFramework.Controle.Botao.BotaoAtalho btnVisivel;
    }
}