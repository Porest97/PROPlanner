using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROPlanner.Models.DataModels
{
    public class Game
    {
        public int Id { get; set; }

        [Display(Name = "Game Cat")]
        public int? GameCategoryId { get; set; }
        [Display(Name = "Game Cat")]
        [ForeignKey("GameCategoryId")]
        public GameCategory GameCategory { get; set; }

        [Display(Name = "Game #")]
        public string GameNumber { get; set; }

        [Display(Name = "Date&Time")]
        public DateTime GameDateTime { get; set; }

        [Display(Name = "Arena")]
        public int? ArenaId { get; set; }
        [Display(Name = "Arena")]
        [ForeignKey("ArenaId")]
        public Arena Arena { get; set; }

        [Display(Name = "Home Team")]
        public int? TeamId { get; set; }
        [Display(Name = "Home Team")]
        [ForeignKey("TeamId")]
        public Team HomeTeam { get; set; }

        [Display(Name = "Away Team")]
        public int? TeamId1 { get; set; }
        [Display(Name = "Away Team")]
        [ForeignKey("TeamId1")]
        public Team AwayTeam { get; set; }


        public int? HomeTeamScore { get; set; }

        public int? AwayTeamScore { get; set; }

        [Display(Name = "Score")]
        public string Result { get { return string.Format("{0} {1} {2}", HomeTeamScore,"-", AwayTeamScore); } }

        [Display(Name = "HD")]
        public int? PersonId { get; set; }
        [Display(Name = "HD")]
        [ForeignKey("PersonId")]
        public Person HD1 { get; set; }

        [Display(Name = "HD")]
        public int? PersonId1 { get; set; }
        [Display(Name = "HD")]
        [ForeignKey("PersonId1")]
        public Person HD2 { get; set; }

        [Display(Name = "LD")]
        public int? PersonId2 { get; set; }
        [Display(Name = "LD")]
        [ForeignKey("PersonId2")]
        public Person LD1 { get; set; }

        [Display(Name = "LD")]
        public int? PersonId3 { get; set; }
        [Display(Name = "LD")]
        [ForeignKey("PersonId3")]
        public Person LD2 { get; set; }

        // Fee calculations !
        [DataType(DataType.Currency)]
        public int HD1Fee { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int HD1TravelKost { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int HD1Alowens { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int HD1LateGameKost { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int HD1TotalFee { get; set; } = 0;

        [DataType(DataType.Currency)]
        public int HD2Fee { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int HD2TravelKost { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int HD2Alowens { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int HD2LateGameKost { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int HD2TotalFee { get; set; } = 0;

        [DataType(DataType.Currency)]
        public int LD1Fee { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int LD1TravelKost { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int LD1Alowens { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int LD1LateGameKost { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int LD1TotalFee { get; set; } = 0;

        [DataType(DataType.Currency)]
        public int LD2Fee { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int LD2TravelKost { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int LD2Alowens { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int LD2LateGameKost { get; set; } = 0;
        [DataType(DataType.Currency)]
        public int LD2TotalFee { get; set; } = 0;

        [DataType(DataType.Currency)]
        public int GameTotalKost { get; set; } = 0;






    }
}
