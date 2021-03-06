﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DigoFramework;
using Rpg.Controle.TabDock;
using Rpg.Dominio;
using WeifenLuo.WinFormsUI.Docking;

namespace Rpg.Frm
{
    public partial class FrmPrincipal : FrmRpgBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private List<ImagemDominio> _lstObjImg;
        private List<MapaDominio> _lstObjMapa;
        private List<PersonagemDominio> _lstObjPersonagem;
        private RpgDominioBase _objSelecionado;
        private TabDockDados _tabDockDados;
        private TabDockExplorer _tabDockExplorer;
        private TabDockImagem _tabDockImagemSelecionada;
        private TabDockMapa _tabDockMapa;
        private TabDockMapa _tabDockMapaSelecionado;
        private TabDockMixer _tabDockMixer;
        private TabDockPropriedade _tabDockPropriedade;

        public RpgDominioBase objSelecionado
        {
            get
            {
                return _objSelecionado;
            }

            set
            {
                if (_objSelecionado == value)
                {
                    return;
                }

                _objSelecionado = value;

                this.setObjSelecionado(_objSelecionado);
            }
        }

        public TabDockExplorer tabDockExplorer
        {
            get
            {
                if (_tabDockExplorer != null)
                {
                    return _tabDockExplorer;
                }

                _tabDockExplorer = new TabDockExplorer();

                return _tabDockExplorer;
            }
        }

        public TabDockImagem tabDockImagemSelecionada
        {
            get
            {
                return _tabDockImagemSelecionada;
            }

            set
            {
                _tabDockImagemSelecionada = value;
            }
        }

        public TabDockMapa tabDockMapaSelecionado
        {
            get
            {
                return _tabDockMapaSelecionado;
            }

            set
            {
                _tabDockMapaSelecionado = value;
            }
        }

        public TabDockMixer tabDockMixer
        {
            get
            {
                if (_tabDockMixer != null)
                {
                    return _tabDockMixer;
                }

                _tabDockMixer = new TabDockMixer();

                return _tabDockMixer;
            }
        }

        public TabDockPropriedade tabDockPropriedade
        {
            get
            {
                if (_tabDockPropriedade != null)
                {
                    return _tabDockPropriedade;
                }

                _tabDockPropriedade = new TabDockPropriedade();

                return _tabDockPropriedade;
            }
        }

        private List<ImagemDominio> lstObjImg
        {
            get
            {
                if (_lstObjImg != null)
                {
                    return _lstObjImg;
                }

                _lstObjImg = new List<ImagemDominio>();

                return _lstObjImg;
            }
        }

        private List<MapaDominio> lstObjMapa
        {
            get
            {
                if (_lstObjMapa != null)
                {
                    return _lstObjMapa;
                }

                _lstObjMapa = new List<MapaDominio>();

                return _lstObjMapa;
            }
        }

        private List<PersonagemDominio> lstObjPersonagem
        {
            get
            {
                if (_lstObjPersonagem != null)
                {
                    return _lstObjPersonagem;
                }

                _lstObjPersonagem = new List<PersonagemDominio>();

                return _lstObjPersonagem;
            }
        }

        private TabDockDados tabDockDados
        {
            get
            {
                if (_tabDockDados != null)
                {
                    return _tabDockDados;
                }

                _tabDockDados = new TabDockDados();

                return _tabDockDados;
            }
        }

        private TabDockMapa tabDockMapa
        {
            get
            {
                if (_tabDockMapa != null)
                {
                    return _tabDockMapa;
                }

                _tabDockMapa = new TabDockMapa();

                return _tabDockMapa;
            }
        }

        #endregion Atributos

        #region Construtores

        public FrmPrincipal()
        {
            this.InitializeComponent();
        }

        #endregion Construtores

        #region Métodos

        public void abrirMixer()
        {
            this.tabDockMixer.Show(this.pnlDockRpg, DockState.DockBottom);
        }

        internal void abrirImagem(ImagemDominio objImg)
        {
            if (objImg == null)
            {
                return;
            }

            if (this.lstObjImg.Contains(objImg))
            {
                return;
            }

            TabDockImagem tabImagem = new TabDockImagem();

            tabImagem.objImagem = objImg;

            tabImagem.Show(this.pnlDockRpg, DockState.DockRight);

            this.lstObjImg.Add(objImg);
        }

        internal bool abrirMapa(MapaDominio objMapa)
        {
            if (objMapa == null)
            {
                return false;
            }

            if (this.lstObjMapa.Contains(objMapa))
            {
                return false;
            }

            TabDockMapa tabDockMapa = new TabDockMapa();

            tabDockMapa.objMapa = objMapa;

            tabDockMapa.Show(this.pnlDockRpg, DockState.Document);

            this.lstObjMapa.Add(objMapa);

            return true;
        }

        internal void abrirPersonagem(PersonagemDominio objPersonagem)
        {
            if (objPersonagem == null)
            {
                return;
            }

            if (this.lstObjPersonagem.Contains(objPersonagem))
            {
                return;
            }

            TabDockPersonagem tabDockPersonagem = new TabDockPersonagem();

            tabDockPersonagem.objPersonagem = objPersonagem;

            tabDockPersonagem.Show(this.pnlDockRpg, DockState.Document);

            this.lstObjPersonagem.Add(objPersonagem);
        }

        protected override void inicializar()
        {
            base.inicializar();

            AppRpg.i.frmPrincipal = this;

            this.WindowState = FormWindowState.Maximized;

            this.ofdJogo.Filter = ("Jogo RPG Maker|*" + AppRpg.STR_EXTENSAO_JOGO);

            this.sfdJogo.FileName = ("Novo Jogo RPG" + AppRpg.STR_EXTENSAO_JOGO);
            this.sfdJogo.Filter = ("Jogo RPG Maker|*" + AppRpg.STR_EXTENSAO_JOGO);
        }

        private void abrirJogo()
        {
            if (!DialogResult.OK.Equals(this.ofdJogo.ShowDialog()))
            {
                return;
            }

            AppRpg.i.abrirJogo(this.ofdJogo.FileName);

            this.abrirJogoTabDock();
        }

        private void abrirJogoTabDock()
        {
            if (AppRpg.i.objJogo == null)
            {
                return;
            }

            this.tabDockExplorer.Show(this.pnlDockRpg, DockState.DockLeft);

            this.tabDockExplorer.abrirJogo();
        }

        private void criarJogo()
        {
            if (!DialogResult.OK.Equals(this.sfdJogo.ShowDialog()))
            {
                return;
            }

            AppRpg.i.criarJogo(this.sfdJogo.FileName);

            this.abrirJogoTabDock();
        }

        private void fecharAplicacao()
        {
            this.fecharAplicacaoMixer();
        }

        private void fecharAplicacaoMixer()
        {
            if (!this.tabDockMixer.Visible)
            {
                return;
            }

            this.tabDockMixer.fecharAplicacao();
        }

        private void salvarJogo()
        {
            AppRpg.i.objJogo.salvar();

            foreach (MapaDominio objMapa in this.lstObjMapa)
            {
                objMapa.salvar();
            }

            foreach (PersonagemDominio objPersonagem in this.lstObjPersonagem)
            {
                objPersonagem.salvar();
            }
        }

        private void setObjSelecionado(RpgDominioBase objDominioSelecionado)
        {
            this.onObjSelecionadoChanged?.Invoke(this, objDominioSelecionado);
        }

        #endregion Métodos

        #region Eventos

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            try
            {
                this.fecharAplicacao();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void tsmExibirDados_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabDockDados.Show(this.pnlDockRpg, DockState.DockBottom);
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void tsmExibirMixer_Click(object sender, EventArgs e)
        {
            try
            {
                this.abrirMixer();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void tsmExibirPropriedade_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabDockPropriedade.Show(this.pnlDockRpg, DockState.DockRight);
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void tsmJogoAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                this.abrirJogo();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void tsmJogoCriar_Click(object sender, EventArgs e)
        {
            try
            {
                this.criarJogo();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void tsmJogoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.salvarJogo();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void tsmMapa_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabDockMapa.Show(this.pnlDockRpg, DockState.DockTop);
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        private void tsmServidorIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                AppRpg.i.iniciarServidorWeb();
            }
            catch (Exception ex)
            {
                new Erro("Erro inesperado.\n", ex);
            }
        }

        public event EventHandler<RpgDominioBase> onObjSelecionadoChanged;

        #endregion Eventos
    }
}