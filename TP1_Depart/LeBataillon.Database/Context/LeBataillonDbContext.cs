
using System.Collections.Generic;
using LeBataillon.Database.Initializer.DataFixtures;
using LeBataillon.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LeBataillon.Database.Context

{
    public class LeBataillonDbContext : DbContext
    {
        DbSet<Player> Players { get; set; }
        DbSet<Team> Teams { get; set; }
        DbSet<Game> Games { get; set; }
        public LeBataillonDbContext(DbContextOptions<LeBataillonDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var players = new List<Player>();
            for (int i = 1; i < 100; i++)
            {
                var name = SampleData.GenerateName(i);
                players.Add(new Player(i, $"{name}Alias", $"{name}@bataillonMail.com", SampleData.GeneratePhoneNumber(i), SampleData.GenerateName(i + 1), SampleData.GenerateLastName(i), SampleData.GenerateLevel()));
            }
            modelBuilder.Entity<Player>().HasData(players);
        }
    }
}