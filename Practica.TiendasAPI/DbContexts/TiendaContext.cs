using Practica.TiendasAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Practica.TiendasAPI.DbContexts
{
    public class TiendaContext : DbContext
    {
        public DbSet<Tienda> Tiendas { get; set; } = null!;
        public DbSet<Producto> Productos { get; set; } = null!;
        
        public TiendaContext(DbContextOptions<TiendaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tienda>().HasData(
                new Tienda(){ Id = 1, Name = "Panadería Paqui", Description = "Pan recién hecho." },
                new Tienda() { Id = 2, Name = "Bazar Todo a 1", Description = "Todo a 1€." },
                new Tienda() { Id = 3, Name = "Supermercados MAS" });
            modelBuilder.Entity<Producto>().HasData(
                new Producto() { Id = 1, Name = "Pan integral", ShopId = 1, Price = 0.3 },
                new Producto() { Id = 2, Name = "Bizcocho", Description = "Porción de bizcocho casero.", ShopId = 1, Price = 0.3 },
                new Producto() { Id = 3, Name = "Cruzcampo 1L", Description = "Botella de 1 litro de cerveza.", ShopId = 2, Price = 1.0 },
                new Producto() { Id = 4, Name = "Agua 2L", Description = "Botella de 1 litro de agua.", ShopId = 2, Price = 1.0 },
                new Producto() { Id = 5, Name = "Agua 2L", Description = "Botella de 1 litro de agua.", ShopId = 3, Price = 1.2 });
        }
    }

}
