using Buffet.Models.Buffet.Cliente;
using Microsoft.EntityFrameworkCore;

namespace Buffet.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        {
        }
    }
}