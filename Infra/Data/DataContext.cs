using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options):base(options) { }

    public DbSet<Users> Users { get; set; }
    public DbSet<Movies> Movies { get; set; }
    public DbSet<Reviews> Reviews { get; set; }
}
