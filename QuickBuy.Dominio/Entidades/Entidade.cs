﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagemValidacao { get; set; }

        private List<string> mensagemValidacao {

            get{ return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }

        }
        protected void LimparMensagesValidacao()
        {
            mensagemValidacao.Clear();

        }
        protected void AdiconarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);

        }
        public abstract void Validacao();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }

        }


        
    }
}