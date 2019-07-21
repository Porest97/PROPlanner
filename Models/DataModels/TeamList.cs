using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROPlanner.Models.DataModels
{
    public class TeamList
    {
        public int Id { get; set; }

        //Team properies !
        [Display(Name = "Team")]
        public int? TeamId { get; set; }
        [Display(Name = "Team")]
        [ForeignKey("TeamId")]
        public Team Team { get; set; }

        //Staff properties !
        [Display(Name = "Head Coach")]
        public int? PersonId { get; set; }
        [Display(Name = "Head Coach")]
        [ForeignKey("PersonId")]
        public Person HeadCoach { get; set; }

        [Display(Name = "Ass Coach")]
        public int? PersonId1 { get; set; }
        [Display(Name = "Ass Coach")]
        [ForeignKey("PersonId1")]
        public Person AssCoach { get; set; }

        [Display(Name = "Teamleader")]
        public int? PersonId2 { get; set; }
        [Display(Name = "Teamleader")]
        [ForeignKey("PersonId2")]
        public Person TeamLeader { get; set; }

        //Squad properties !

        //Goalies!
        [Display(Name = "Goalie")]
        public int? PersonId3 { get; set; }
        [Display(Name = "Goalie")]
        [ForeignKey("PersonId3")]
        public Person Goalie1 { get; set; }

        [Display(Name = "Goalie")]
        public int? PersonId4 { get; set; }
        [Display(Name = "Goalie")]
        [ForeignKey("PersonId4")]
        public Person Goalie2 { get; set; }

        //Defense !
        [Display(Name = "D")]
        public int? PersonId5 { get; set; }
        [Display(Name = "D")]
        [ForeignKey("PersonId5")]
        public Person Defense1 { get; set; }

        [Display(Name = "D")]
        public int? PersonId6 { get; set; }
        [Display(Name = "D")]
        [ForeignKey("PersonId6")]
        public Person Defense2 { get; set; }

        [Display(Name = "D")]
        public int? PersonId7 { get; set; }
        [Display(Name = "D")]
        [ForeignKey("PersonId7")]
        public Person Defense3 { get; set; }

        [Display(Name = "D")]
        public int? PersonId8 { get; set; }
        [Display(Name = "D")]
        [ForeignKey("PersonId8")]
        public Person Defense4 { get; set; }

        [Display(Name = "D")]
        public int? PersonId9 { get; set; }
        [Display(Name = "D")]
        [ForeignKey("PersonId9")]
        public Person Defense5 { get; set; }

        [Display(Name = "D")]
        public int? PersonId10 { get; set; }
        [Display(Name = "D")]
        [ForeignKey("PersonId10")]
        public Person Defense6 { get; set; }

        [Display(Name = "D")]
        public int? PersonId11 { get; set; }
        [Display(Name = "D")]
        [ForeignKey("PersonId11")]
        public Person Defense7 { get; set; }

        [Display(Name = "D")]
        public int? PersonId12 { get; set; }
        [Display(Name = "D")]
        [ForeignKey("PersonId12")]
        public Person Defense8 { get; set; }

        //Offense !
        [Display(Name = "FW")]
        public int? PersonId13 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId13")]
        public Person Offense1 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId14 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId14")]
        public Person Offense2 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId15 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId15")]
        public Person Offense3 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId16 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId16")]
        public Person Offense4 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId17 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId17")]
        public Person Offense5 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId18 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId18")]
        public Person Offense6 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId19 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId19")]
        public Person Offense7 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId20 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId20")]
        public Person Offense8 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId21 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId21")]
        public Person Offense9 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId22 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId22")]
        public Person Offense10 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId23 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId23")]
        public Person Offense11 { get; set; }

        [Display(Name = "FW")]
        public int? PersonId24 { get; set; }
        [Display(Name = "FW")]
        [ForeignKey("PersonId24")]
        public Person Offense12 { get; set; }


    }
}
