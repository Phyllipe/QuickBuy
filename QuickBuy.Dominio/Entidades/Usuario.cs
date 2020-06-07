﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validacao()
        {
            if (string.IsNullOrEmpty(Email))
                AdiconarCritica("Email não foi informado");
            if (string.IsNullOrEmpty(Senha))
                AdiconarCritica("Senha não foi informado");
        }
    }
}
