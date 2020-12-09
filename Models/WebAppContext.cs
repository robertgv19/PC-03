using Microsoft.EntityFrameworkCore;
using PC_03.Models;

namespace PC_03.Models
{
    public class WebAppContext : DbContext
    {

        public DbSet<Productos> Productos { get; set; }
        public WebAppContext(DbContextOptions dco) : base(dco) {

        }
        
    }
}