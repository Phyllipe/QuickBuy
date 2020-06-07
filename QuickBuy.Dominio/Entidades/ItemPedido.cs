using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validacao()
        {
            if (ProdutoId == 0)
                AdiconarCritica("Não foi identificado qual a referencia do produto");
            if (Quantidade == 0)
                AdiconarCritica("Quantidade não foi informado");
        }
    }
}
