using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrisao { get; set; }
        public decimal Preco { get; set; }

        public override void Validacao()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome do produto não foi informado");

            if (string.IsNullOrEmpty(Descrisao))
                AdicionarCritica("Descrição não foi informado");
        }

      
    }
}
