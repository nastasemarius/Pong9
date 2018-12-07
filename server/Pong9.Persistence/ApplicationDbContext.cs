using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pong9.Data.Entities;

namespace Pong9.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AuthorBook>()
        //        .HasKey(authorBook => new { authorBook.AuthorId, authorBook.BookId });

        //    modelBuilder.Entity<GenreBook>()
        //        .HasKey(genreBook => new { genreBook.GenreId, genreBook.BookId });

        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Invite> Invites { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<PingPongTable> PingPongTables { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }
        
        public DbSet<WorkSpace> WorkSpaces { get; set; }

    }
}
