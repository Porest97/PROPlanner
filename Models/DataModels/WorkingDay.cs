using System;
using System.ComponentModel.DataAnnotations;

namespace PROPlanner.Models.DataModels
{
    public class WorkingDay
    {
        public int Id { get; set; }

        public string WorkingDayName { get; set; }

        
        public string WorkingDayStart { get; set; }
        

        public string WorkingDayEnd { get; set; }

        
        public string WorkingDayTimes { get { return string.Format("{0} {1} {2} ", WorkingDayStart,"-", WorkingDayEnd); } }

        
        public decimal HoursWorked { get; set; }


    }
}