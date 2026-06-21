using Microsoft.EntityFrameworkCore;

public class VendasWebContext(DbContextOptions<VendasWebContext> options) : DbContext(options)
{
    public DbSet<VendasWeb.Models.Departamento> Departamento { get; set; } = default!;
}
