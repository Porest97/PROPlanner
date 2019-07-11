using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROPlanner.Models.DataModels
{
    public class Schedule
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime ScheduleStartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ScheduleEndDate { get; set; }
        [Display(Name="Vecka")]
        public string ScheduleWeek { get; set; }
        [Display(Name = "Schema")]
        public string ScheduleName { get; set; }
        [Display(Name = "Schemabeskrivning")]
        public string ScheduleDescription { get; set; }


        //Person !
        [Display(Name = "Person")]
        public int? PersonId { get; set; }
        [Display(Name = "Person")]
        [ForeignKey("PersonId")]
        public Person Person { get; set; }


        //WorkingDays !

        [Display(Name = "Måndag")]
        public int? WorkingDayId { get; set; }
        [Display(Name = "Måndag")]
        [ForeignKey("WorkingDayId")]        
        public WorkingDay WorkingDay { get; set; }

        [Display(Name = "Tisdag")]
        public int? WorkingDayId1 { get; set; }
        [Display(Name = "Tisdag")]
        [ForeignKey("WorkingDayId1")]
        public WorkingDay WorkingDay1 { get; set; }

        [Display(Name = "Onsdag")]
        public int? WorkingDayId2 { get; set; }
        [Display(Name = "Onsdag")]
        [ForeignKey("WorkingDayId2")]
        public WorkingDay WorkingDay3 { get; set; }

        [Display(Name = "Torsdag")]
        public int? WorkingDayId3 { get; set; }
        [Display(Name = "Torsdag")]
        [ForeignKey("WorkingDayId3")]
        public WorkingDay WorkingDay4 { get; set; }

        [Display(Name = "Fredag")]
        public int? WorkingDayId4 { get; set; }
        [Display(Name = "Fredag")]
        [ForeignKey("WorkingDayId4")]
        public WorkingDay WorkingDay5 { get; set; }

        [Display(Name = "Antal Tim")]
        public decimal TotalWorkedHours { get; set; }
    }
}
