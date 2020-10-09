
using System;
using System.Collections.Generic;
using LeBataillon.Database.Initializer.DataFixtures;
using LeBataillon.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LeBataillon.Database.Context

{
    public class LeBataillonDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }
        public LeBataillonDbContext(DbContextOptions<LeBataillonDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //player
            var players = new List<Player>();
            for (int i = 1; i < 100; i++)
            {
                var name = SampleData.GenerateName(10 + i);

                var player = new Player(i, $"{name}Alias", $"{name}@bataillonMail.com", SampleData.GeneratePhoneNumber(i), name, SampleData.GenerateLastName(i), SampleData.GenerateLevel());

                players.Add(player);
            }
            modelBuilder.Entity<Player>().HasData(players);


            //team
            var teams = new List<Team>();
            for (int i = 1; i <= 10; i++)
            {

                var teamName = "Équipe de " + SampleData.GenerateName(i);
                teams.Add(new Team(i, teamName, i));

            }
            modelBuilder.Entity<Team>().HasData(teams);
            //GAME



            var games = new List<Game>();
            games.Add(new Game(1, new DateTime(2020, 10, 24), 1, 3));
            games.Add(new Game(2, new DateTime(2020, 10, 24), 4, 6));
            games.Add(new Game(3, new DateTime(2020, 10, 24), 7, 2));
            modelBuilder.Entity<Game>().HasData(games);

        }
    }
}