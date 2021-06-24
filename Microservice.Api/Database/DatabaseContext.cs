using System.Configuration;
using Microservice.Api.Entities;
using Microservice.API.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace Microservice.API.Database
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Commentary> Commentary { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Place> Place { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["photravel"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commentary>(entity =>
            {
                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.Score);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Commentaries)
                    .HasForeignKey(d => d.PostId);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(512);

                entity.Property(e => e.Details)
                    .HasMaxLength(512);

                entity.Property(e => e.Score);

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PlaceId);
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.Property(e => e.Addresses)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.Score);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(120);
                
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.Passw)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.Token)
                    .HasMaxLength(120);
            });
        }
    }
}
