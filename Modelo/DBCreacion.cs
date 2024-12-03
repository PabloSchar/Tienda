using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class DBCreacion : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleDeFactura> DetalleDeFacturas { get; set; }
        public DbSet<ProductoImportado> ProductosImportados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Tienda");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Claves Primarias
            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);
            modelBuilder.Entity<Categoria>().HasKey(c => c.Id);
            modelBuilder.Entity<DetalleDeFactura>().HasKey(c => c.Id);
            modelBuilder.Entity<Factura>().HasKey(c => c.Id);
            modelBuilder.Entity<Producto>().HasKey(c => c.Id);
            modelBuilder.Entity<Proveedor>().HasKey(c => c.Id);

            modelBuilder.Entity<ProductoImportado>().ToTable("ProductosImportados");

            //Claves Unicas
            modelBuilder.Entity<Cliente>().HasIndex(c => c.Codigo).IsUnique();
            modelBuilder.Entity<Categoria>().HasIndex(c => c.Codigo).IsUnique();
            modelBuilder.Entity<Factura>().HasIndex(c => c.Numero).IsUnique();
            modelBuilder.Entity<Producto>().HasIndex(c => c.Codigo).IsUnique();
            modelBuilder.Entity<Proveedor>().HasIndex(c => c.Codigo).IsUnique();
            modelBuilder.Entity<ProductoImportado>().HasIndex(c => c.CodigoImportacion).IsUnique();

            //Relaciones
            modelBuilder.Entity<Categoria>().HasMany(c => c.Productos).WithOne(c => c.Categoria).OnDelete(DeleteBehavior.Restrict); //evito eliminacion en cascada
            modelBuilder.Entity<Proveedor>().HasMany(c => c.Productos).WithMany();

            modelBuilder.Entity<Factura>().HasMany(c => c.DetalleDeFacturas).WithOne(c => c.Factura).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Factura>().HasOne(c => c.Cliente).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DetalleDeFactura>().HasOne(c => c.Producto).WithMany().OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
