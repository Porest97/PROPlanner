using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROPlanner.Models.DataModels;

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
    }
}
