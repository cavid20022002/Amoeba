using AmoebaTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace AmoebaTemplate.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

            
        }

        public DbSet<Slider>Sliders { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<CustomService> CustomServices { get; set; }
        public DbSet<Setting> Settings { get; set; }


    }
}
