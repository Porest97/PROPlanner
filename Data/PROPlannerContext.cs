using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROPlanner.Models.DataModels;
using PROPlanner.Models.RefModels;

namespace PROPlanner.Models
{
    public class PROPlannerContext : DbContext
    {
        public PROPlannerContext (DbContextOptions<PROPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<PROPlanner.Models.DataModels.Company> Company { get; set; }

        public DbSet<PROPlanner.Models.DataModels.Person> Person { get; set; }

        public DbSet<PROPlanner.Models.DataModels.PersonType> PersonType { get; set; }

        public DbSet<PROPlanner.Models.DataModels.Schedule> Schedule { get; set; }

        public DbSet<PROPlanner.Models.DataModels.WorkingDay> WorkingDay { get; set; }

        public DbSet<PROPlanner.Models.DataModels.Game> Game { get; set; }

        public DbSet<PROPlanner.Models.DataModels.Arena> Arena { get; set; }

        public DbSet<PROPlanner.Models.DataModels.Team> Team { get; set; }

        public DbSet<PROPlanner.Models.DataModels.GameCategory> GameCategory { get; set; }

        public DbSet<PROPlanner.Models.RefModels.RefereeType> RefreeType { get; set; }

        public DbSet<PROPlanner.Models.RefModels.Referee> Referee { get; set; }

        public DbSet<PROPlanner.Models.RefModels.Match> Match { get; set; }
    }
}
