using API_WEB_CORE.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace API_WEB_CORE.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions dbContextOption) : base(dbContextOption)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
