// =================================================================================
// PROJETO: Sistema de Agentes Comunitários de Saúde (ACS) - Windows Forms
// ARQUIVO: Data/AppDbContext.cs
// DESCRIÇÃO: Contexto do Entity Framework configurado para SQL Server.
// =================================================================================
using Microsoft.EntityFrameworkCore;
using SistemaACS.Models; // Importa as classes de modelo

namespace SistemaACS.Data
{
    public class AppDbContext : DbContext
    {
        // Mapeia cada classe para uma tabela no banco de dados (DbSet)
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Familia> Familias { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }

        // Este método é chamado pelo EF Core para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura o EF Core para usar o SQL Server.
            // A string de ligação (connection string) aponta para a sua base de dados.
            // IMPORTANTE: Ajuste os parâmetros (Server, Database, etc.) conforme a sua configuração.
            const string connectionString = @"Server=JPedro\SQLEXPRESS;Database=SistemaACS_DB;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aqui podemos adicionar configurações mais avançadas se necessário.
            // Por exemplo, configurar índices para garantir que CPF e CNS sejam únicos.
            modelBuilder.Entity<Paciente>()
                .HasIndex(p => p.CPF)
                .IsUnique();

            modelBuilder.Entity<Paciente>()
                .HasIndex(p => p.CNS)
                .IsUnique();
        }
    }
}
