using dotnet_rpg_udemy.Models;
using Microsoft.EntityFrameworkCore;
using RPG_Udemy.Models;

namespace RPG_Udemy.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
    }
}