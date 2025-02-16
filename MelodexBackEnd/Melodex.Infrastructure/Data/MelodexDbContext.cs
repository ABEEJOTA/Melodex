using Melodex.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Melodex.Infrastructure.Data
{
    public class MelodexDbContext : DbContext
    {
        public MelodexDbContext(DbContextOptions<MelodexDbContext> options) : base(options) { }
        public DbSet<MediaItem> MediaItems { get; set; }
        public DbSet<Vinyl> Vinyl { get; set; }
        public DbSet<CD> CD { get; set; }
        public DbSet<Cassette> Cassette { get; set; }
        public DbSet<Collection> Collection { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<PlayList> PlayList { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
