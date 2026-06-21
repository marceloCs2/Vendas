using Microsoft.EntityFrameworkCore;

public class VendasWebContext(DbContextOptions<VendasWebContext> options) : DbContext(options)
{
    public DbSet<VendasWeb.Models.Departamento> Departamento { get; set; } = default!;
    public DbSet<VendasWeb.Models.Vendedor> Vendedor { get; set; } = default!;
    public DbSet<VendasWeb.Models.RegistroVenda> RegistroVenda { get; set; } = default!;

}
