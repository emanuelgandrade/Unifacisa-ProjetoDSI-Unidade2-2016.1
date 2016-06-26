using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Infra.Data.Migrations;
using System.Data.Entity;

namespace ProjetoDDD.Infra.Data.Entity
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Prato> Pratos { get; set; }

        public BancoDeDados() : base("ProjetoDDD_DataBase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BancoDeDados, Configuration>());
        }
    }
}