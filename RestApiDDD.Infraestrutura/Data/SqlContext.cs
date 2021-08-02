using Microsoft.EntityFrameworkCore;
using RestApiDDD.Dominio.Entidades;
using System;
using System.Linq;

namespace RestApiDDD.Infraestrutura.Data
{
    public class SqlContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options ) : base(options)
        {

        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(
                    entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if(entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
