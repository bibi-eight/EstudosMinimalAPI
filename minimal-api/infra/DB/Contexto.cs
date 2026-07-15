using Microsoft.EntityFrameworkCore;
using MinimalApi.domain.entities;

namespace MinimalApi.Infra.DB;

public class Contexto : DbContext
{
    public DbSet<Administrador> Administradores {get; set;} = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("string de conexao", ServerVersion.AutoDetect("string de conexao"));
    }
}