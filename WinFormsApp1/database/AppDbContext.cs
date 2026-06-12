using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySqlConnector.Logging;
using WinFormsApp1.model.entidade;

namespace WinFormsApp1.database
{
    public class AppDbContext : DbContext
    {
        // DbSets representam tabelas   
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        // Configuração da conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // String de conexão — ajuste conforme seu ambiente
            var connectionString = "Server=localhost;Database=vendasDesk;User=root;Password=123456;";

            optionsBuilder
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
