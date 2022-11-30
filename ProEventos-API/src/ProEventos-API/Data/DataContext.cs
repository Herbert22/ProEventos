using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos_API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Eventos> Eventos { get; set; }
    }
}