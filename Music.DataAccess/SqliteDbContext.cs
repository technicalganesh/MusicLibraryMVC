using Microsoft.EntityFrameworkCore;
using Music.Standards;
using Music.Models;

namespace Music.DataAccess
{
    public class SqliteDbContext : DbContext
    {
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums {get;set;}
        public DbSet<Composer> Composers {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Composer>().HasKey(composer => composer.Id);
            modelBuilder.Entity<Album>().HasKey(album => album.Id);
            modelBuilder.Entity<Album>()
                .HasOne(album => album.Composer)
                .WithMany(composer => composer.Albums)
                .HasForeignKey(album => album.ComposerId);

            modelBuilder.Entity<Composer>().HasData(
                new Composer(){
                    Id = 1,
                    Name = "Hans Zimmer",
                    Phone = "8823923232"
                },
                new Composer() {
                    Id = 2,
                    Name = "Ilayaraja",
                    Phone = "8923232323"
                }
            );

            modelBuilder.Entity<Album>().HasData(
                new Album() {
                    Id = 1,
                    Name = "Spiderman",
                    Genre = "Soundtrack",
                    ComposerId = 1
                },
                new Album() {
                    Id = 2,
                    Name = "How to name it",
                    Genre = "Instrumental",
                    ComposerId = 2
                }
            );            
        }

    }
}