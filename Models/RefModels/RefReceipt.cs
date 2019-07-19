using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROPlanner.Models.RefModels
{
    public class RefReceipt
    {
        public int Id { get; set; }
        /// <summary>
        /// Match Rpoperties !
        /// </summary>
        [Display(Name = "Match")]
        public int? MatchId { get; set; }
        [Display(Name = "Match")]
        [ForeignKey("MatchId")]
        public Match Match { get; set; }
              
        /// <summary>
        /// Referees Properties !
        /// </summary>
        [Display(Name = "HD")]
        public int? RefereeId { get; set; }
        [Display(Name = "HD")]
        [ForeignKey("RefereeId")]
        public Referee HD1 { get; set; }

        [Display(Name = "HD")]
        public int? RefereeId1 { get; set; }
        [Display(Name = "HD")]
        [ForeignKey("RefereeId1")]
        public Referee HD2 { get; set; }

        [Display(Name = "LD")]
        public int? RefereeId2 { get; set; }
        [Display(Name = "LD")]
        [ForeignKey("RefereeId2")]
        public Referee LD1 { get; set; }

        [Display(Name = "LD")]
        public int? RefereeId3 { get; set; }
        [Display(Name = "LD")]
        [ForeignKey("RefereeId3")]
        public Referee LD2 { get; set; }

        /// <summary>
        /// Payment Properties Ref1 !
        /// </summary>
        //Ref1 Fee !
        public int HD1Fee { get; set; }

        //Ref1 Allowance !
        public int HD1Allowance { get; set; }

        //Ref1 LateGameStart !
        public int HD1LateGame { get; set; }


        //Ref1 travelkosts !
        public int HD1TravellengthKm { get; set; }
        public int HD1TravelKostperkm { get; set; }
        public int HD1TravelKost { get; set; }

        //REF1 Total PAYMENT !
        public int HD1TotalPayment { get; set; }

        public bool HD1Paid { get; set; } = false;

        /// <summary>
        /// Payment Properties Ref2 !
        /// </summary>
        //Ref1 Fee !
        public int HD2Fee { get; set; }

        //Ref1 Allowance !
        public int HD2Allowance { get; set; }

        //Ref1 LateGameStart !
        public int HD2LateGame { get; set; }


        //Ref1 travelkosts !
        public int HD2TravellengthKm { get; set; }
        public int HD2TravelKostperkm { get; set; }
        public int HD2TravelKost { get; set; }

        //REF1 Total PAYMENT !
        public int HD2TotalPayment { get; set; }

        public bool HD2Paid { get; set; } = false;

        /// <summary>
        /// Payment Properties Ref3 !
        /// </summary>
        //Ref3 Fee !
        public int LD1Fee { get; set; }

        //Ref3 Allowance !
        public int LD1Allowance { get; set; }

        //Ref3 LateGameStart !
        public int LD1LateGame { get; set; }


        //Ref3 travelkosts !
        public int LD1TravellengthKm { get; set; }
        public int LD1TravelKostperkm { get; set; }
        public int LD1TravelKost { get; set; }

        //REF3 Total PAYMENT !
        public int LD1TotalPayment { get; set; }

        public bool LD1Paid { get; set; } = false;


        /// <summary>
        /// Payment Properties Ref4 !
        /// </summary>
        //Ref4 Fee !
        public int LD2Fee { get; set; }

        //Ref3 Allowance !
        public int LD2Allowance { get; set; }

        //Ref3 LateGameStart !
        public int LD2LateGame { get; set; }


        //Ref3 travelkosts !
        public int LD2TravellengthKm { get; set; }
        public int LD2TravelKostperkm { get; set; }
        public int LD2TravelKost { get; set; }

        //REF3 Total PAYMENT !
        public int LD2TotalPayment { get; set; }

        public bool LD2Paid { get; set; } = false;

        //Signing properties !

        public string HD1Date { get; set; }

        public string HD2Date { get; set; }

        public string HD3Date { get; set; }

        public string HD4Date { get; set; }

        public string HD1Sign { get; set; }
        public string HD2Sign { get; set; }
        public string HD3Sign { get; set; }
        public string HD4Sign { get; set; }

    }
}
