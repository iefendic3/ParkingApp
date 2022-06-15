using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projekat___Parking.Models;

namespace Projekat___Parking.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BankovniRacun> BankovniRacun { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<Parking> Parking { get; set; }
        public DbSet<Radnik> Radnik { get; set; }
        public DbSet<VIPKorisnik> VIPKorisnik { get; set; }
        public DbSet<Vlasnik> Vlasnik { get; set; }
        public DbSet<Vozilo> Vozilo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankovniRacun>().ToTable("BankovniRacun");
            modelBuilder.Entity<Grad>().ToTable("Grad");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Osoba>().ToTable("Osoba");
            modelBuilder.Entity<Parking>().ToTable("Parking");
            modelBuilder.Entity<Radnik>().ToTable("Radnik");
            modelBuilder.Entity<VIPKorisnik>().ToTable("VIPKorisnik");
            modelBuilder.Entity<Vlasnik>().ToTable("Vlasnik");
            modelBuilder.Entity<Vozilo>().ToTable("Vozilo");

            base.OnModelCreating(modelBuilder);
        }

    }
}
