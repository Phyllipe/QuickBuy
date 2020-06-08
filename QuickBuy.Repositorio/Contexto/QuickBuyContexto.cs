using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
      
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder
                .Entity<FormaPagamento>()
                .HasData(
                new FormaPagamento() {
                    Id = 1,
                    Nome = "Boleto",
                    Descrisao = "Forma de Pagamento Boleto" },
                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "Cartão de Crédito",
                    Descrisao = "Forma de Pagamento Cartão de Crédito"
                },
                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Depósito",
                    Descrisao = "Forma de Pagamento Depósito bancario"
                }

                ); ; ;

            base.OnModelCreating(modelBuilder);
        }
    }
}
