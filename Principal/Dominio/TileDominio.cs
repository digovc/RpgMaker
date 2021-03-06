﻿using System;
using System.Drawing;
using Newtonsoft.Json;
using Rpg.Controle.Editor.Grafico;

namespace Rpg.Dominio
{
    public class TileDominio : RpgDominioBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private bool _booFixo;
        private string _dirImagem;
        private TileGrafico _gfcTile;
        private Rectangle _rtgImg;
        private Rectangle _rtgMapa;

        public bool booFixo
        {
            get
            {
                return _booFixo;
            }

            set
            {
                _booFixo = value;
            }
        }

        public string dirImagem
        {
            get
            {
                return _dirImagem;
            }

            set
            {
                _dirImagem = value;
            }
        }

        [JsonIgnore]
        public TileGrafico gfcTile
        {
            get
            {
                return _gfcTile;
            }

            set
            {
                _gfcTile = value;
            }
        }

        public Rectangle rtgImg
        {
            get
            {
                return _rtgImg;
            }

            set
            {
                _rtgImg = value;
            }
        }

        public Rectangle rtgMapa
        {
            get
            {
                return _rtgMapa;
            }

            set
            {
                _rtgMapa = value;
            }
        }

        #endregion Atributos

        #region Construtores

        #endregion Construtores

        #region Métodos

        private void setBooSelecionado(bool booSelecionado)
        {
            this.onBooSelecionadoChanged?.Invoke(this, booSelecionado);
        }

        #endregion Métodos

        #region Eventos

        public event EventHandler<bool> onBooSelecionadoChanged;

        #endregion Eventos
    }
}