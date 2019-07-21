using PROPlanner.Models.RefModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPlanner.Models
{
    public class Tournament
    {
        public int Id { get; set; }

        public string TournamentName { get; set; }

        public List<Match> Matches { get; set; }

    }
}
