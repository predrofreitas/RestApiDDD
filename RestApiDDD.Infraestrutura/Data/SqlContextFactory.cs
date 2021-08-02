using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RestApiDDD.Infraestrutura.Data
{
    public class SqlContextFactory : IDesignTimeDbContextFactory<SqlContext>
    {
        public SqlContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqlContext>();
            optionsBuilder.UseSqlServer("Data Source=192.168.70.111,1433;Initial Catalog=locadoradb;User Id=sa;Password=abc,12345678",
                sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure();
            });

            return new SqlContext(optionsBuilder.Options);
        }
    }
}
