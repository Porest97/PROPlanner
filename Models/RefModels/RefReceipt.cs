using PROPlanner.Models.DataModels;
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
        public Referee REF1 { get; set; }

        [Display(Name = "HD")]
        public int? RefereeId1 { get; set; }
        [Display(Name = "HD")]
        [ForeignKey("RefereeId1")]
        public Referee REF2 { get; set; }

        [Display(Name = "LD")]
        public int? RefereeId2 { get; set; }
        [Display(Name = "LD")]
        [ForeignKey("RefereeId2")]
        public Referee REF3 { get; set; }

        [Display(Name = "LD")]
        public int? RefereeId3 { get; set; }
        [Display(Name = "LD")]
        [ForeignKey("RefereeId3")]
        public Referee REF4 { get; set; }

        /// <summary>
        /// Payment Properties Ref1 !
        /// </summary>
        //Ref1 Fee !
        public int REF1Fee { get; set; }
        //Ref1 Allowance !
        public int REF1Allowance { get; set; }
        //Ref1 LateGameStart !
        public int REF1LateGame { get; set; }
        //Ref1 travelkosts !
        public int REF1TravellengthKm { get; set; }
        public int REF1TravelKostperkm { get; set; }
        public int REF1TravelKost { get; set; }
        public int REF1Toll { get; set; }
        public int REF1ParkingFee { get; set; }
        //REF1 Total PAYMENT !
        public int REF1TotalPayment { get; set; }
        public bool REF1Paid { get; set; } = false;
        //REF1 Signing properties !
        public string REF1Date { get; set; }
        public string REF1Sign { get; set; }
        //REF1 FROM AND TO !
        public string REF1From { get; set; }
        public string REF1To { get; set; }
       

        /// <summary>
        /// Payment Properties Ref2 !
        /// </summary>
        //Ref1 Fee !
        public int REF2Fee { get; set; }
        //Ref2 Allowance !
        public int REF2Allowance { get; set; }
        //Ref2 LateGameStart !
        public int REF2LateGame { get; set; }        
        //Ref2 travelkosts !
        public int REF2TravellengthKm { get; set; }
        public int REF2TravelKostperkm { get; set; }
        public int REF2TravelKost { get; set; }
        public int REF2Toll { get; set; }
        public int REF2ParkingFee { get; set; }
        //REF2 Total PAYMENT !
        public int REF2TotalPayment { get; set; }
        public bool REF2Paid { get; set; } = false;
        //REF2 Signing properties !
        public string REF2Date { get; set; }
        public string REF2Sign { get; set; }
        //REF2 FROM AND TO !
        public string REF2From { get; set; }
        public string REF2To { get; set; }



        /// <summary>
        /// Payment Properties Ref3 !
        /// </summary>
        //Ref3 Fee !
        public int REF3Fee { get; set; }
        //Ref3 Allowance !
        public int REF3Allowance { get; set; }
        //Ref3 LateGameStart !
        public int REF3LateGame { get; set; }
        //Ref3 travelkosts !
        public int REF3TravellengthKm { get; set; }
        public int REF3TravelKostperkm { get; set; }
        public int REF3TravelKost { get; set; }
        public int REF3Toll { get; set; }
        public int REF3ParkingFee { get; set; }
        //REF3 Total PAYMENT !
        public int REF3TotalPayment { get; set; }
        public bool REF3Paid { get; set; } = false;
        //REF3 Signing properties !
        public string REF3Date { get; set; }
        public string REF3Sign { get; set; }
        //REF3 FROM AND TO !
        public string REF3From { get; set; }
        public string REF3To { get; set; }



        /// <summary>
        /// Payment Properties Ref4 !
        /// </summary>
        //Ref4 Fee !
        public int REF4Fee { get; set; }
        //Ref4 Allowance !
        public int REF4Allowance { get; set; }
        //Ref4 LateGameStart !
        public int REF4LateGame { get; set; }
        //Ref4 travelkosts !
        public int REF4TravellengthKm { get; set; }
        public int REF4TravelKostperkm { get; set; }
        public int REF4TravelKost { get; set; }
        public int REF4Toll { get; set; }
        public int REF4ParkingFee { get; set; }
        //REF4 Total PAYMENT !
        public int REF4TotalPayment { get; set; }
        public bool REF4Paid { get; set; } = false;
        //REF4 Signing properties !
        public string REF4Date { get; set; }
        public string REF4Sign { get; set; }
        //REF4 FROM AND TO !
        public string REF4From { get; set; }
        public string REF4To { get; set; }
    }
}
