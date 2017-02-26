namespace WebApplication1.Data
{
    using Microsoft.EntityFrameworkCore;

    public partial class HeroDbContext : DbContext
    {
        public HeroDbContext(DbContextOptions<HeroDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hero> Heroes { get; set; }

    }
 }
  