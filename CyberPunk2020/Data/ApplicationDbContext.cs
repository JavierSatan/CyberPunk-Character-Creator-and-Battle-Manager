using CyberPunk2020.Models;
using Microsoft.EntityFrameworkCore;

namespace CyberPunk2020.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Stats> Statuses { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }


    }
}
