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

            //modelBuilder.Entity<MediaItem>()
            //    .HasDiscriminator<string>("MediaType")
            //    .HasValue<Vinyl>("Vinyl")
            //    .HasValue<CD>("CD")
            //    .HasValue<Cassette>("Cassette");

            //// Configuración de herencia para MediaItem
            //modelBuilder.Entity<MediaItem>()
            //    .HasDiscriminator<MediaFormat>("Format")
            //    .HasValue<Vinyl>(MediaFormat.Vinyl)
            //    .HasValue<CD>(MediaFormat.CD)
            //    .HasValue<Cassette>(MediaFormat.Cassette);


            //modelBuilder.Entity<MediaItem>(b =>
            //{
            //    b.Property<int>("Format")
            //        .HasColumnType("integer");

            //    b.HasKey("Id");

            //    b.ToTable("MediaItems");

            //    // Configura el discriminador
            //    b.HasDiscriminator<MediaFormat>("Format")
            //        .HasValue<Vinyl>(MediaFormat.Vinyl)
            //        .HasValue<CD>(MediaFormat.CD)
            //        .HasValue<Cassette>(MediaFormat.Cassette);

            //    b.UseTphMappingStrategy();
            //});

            // Relaciones de clave foránea
            modelBuilder.Entity<MediaItem>()
                .HasOne(m => m.Artist)
                .WithMany()
                .HasForeignKey(m => m.ArtistId)
                .OnDelete(DeleteBehavior.Cascade); // Eliminar medios si se elimina el artista

            modelBuilder.Entity<Collection>()
                .HasMany(c => c.MediaItems)
                .WithOne()
                .HasForeignKey("CollectionId");

            modelBuilder.Entity<PlayList>()
                .HasMany(p => p.Tracks)
                .WithOne()
                .HasForeignKey(t => t.PlayListId);

            modelBuilder.Entity<Track>()
                .HasOne(t => t.MediaItem)
                .WithMany(m => m.Tracks)
                .HasForeignKey(t => t.MediaItemId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
