using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixSchemaDesignMVC_DotNet.Models
{
    public class NetflixDBContext : DbContext
    {
        public NetflixDBContext(DbContextOptions<NetflixDBContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<WatchHistory> WatchHistory { get; set; }
        public DbSet<Actor> Actor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Video>()
                .HasMany(e => e.Actors)
                .WithMany(e => e.Videos)
                .UsingEntity<Cast>(
                    l => l.HasOne<Actor>().WithMany().HasForeignKey(e => e.Id),
                    r => r.HasOne<Video>().WithMany().HasForeignKey(e => e.Id)
                );
        }
    }
}
