using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.Context
{
    public class MaisonReveDbContext : DbContext
    {
        public MaisonReveDbContext (DbContextOptions<MaisonReveDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeBataillon.Database.Models.Player> Player { get; set; }

        public DbSet<LeBataillon.Database.Models.Team> Team { get; set; }

        public DbSet<LeBataillon.Database.Models.Game> Game { get; set; }
    }
}
