using Melodex.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Melodex.Infrastructure.Data
{
    public class MelodexDbContext : DbContext
    {
        public MelodexDbContext(DbContextOptions<MelodexDbContext> options) : base(options) { }

        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<CD> CDs { get; set; }
        public DbSet<Cassette> Cassettes { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CollectionVinyl> CollectionVinyls { get; set; }
        public DbSet<CollectionCD> CollectionCDs { get; set; }
        public DbSet<CollectionCassette> CollectionCassettes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CollectionVinyl>()
                .HasKey(cv => new { cv.CollectionId, cv.VinylId });

            modelBuilder.Entity<CollectionVinyl>()
                .HasOne(cv => cv.Collection)
                .WithMany(c => c.CollectionVinyls)
                .HasForeignKey(cv => cv.CollectionId);

            modelBuilder.Entity<CollectionVinyl>()
                .HasOne(cv => cv.Vinyl)
                .WithMany()
                .HasForeignKey(cv => cv.VinylId);

            modelBuilder.Entity<CollectionCD>()
                .HasKey(cc => new { cc.CollectionId, cc.CDId });

            modelBuilder.Entity<CollectionCD>()
                .HasOne(cc => cc.Collection)
                .WithMany(c => c.CollectionCDs)
                .HasForeignKey(cc => cc.CollectionId);

            modelBuilder.Entity<CollectionCD>()
                .HasOne(cc => cc.CD)
                .WithMany()
                .HasForeignKey(cc => cc.CDId);

            modelBuilder.Entity<CollectionCassette>()
                .HasKey(cc => new { cc.CollectionId, cc.CassetteId });

            modelBuilder.Entity<CollectionCassette>()
                .HasOne(cc => cc.Collection)
                .WithMany(c => c.CollectionCassettes)
                .HasForeignKey(cc => cc.CollectionId);

            modelBuilder.Entity<CollectionCassette>()
                .HasOne(cc => cc.Cassette)
                .WithMany()
                .HasForeignKey(cc => cc.CassetteId);

            modelBuilder.Entity<Collection>()
                .HasOne(c => c.User)
                .WithOne(u => u.Collection)
                .HasForeignKey<Collection>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}