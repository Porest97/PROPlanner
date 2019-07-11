using PROPlanner.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPlanner.Models.ViewModels
{
    public class CompanyViewModel
    {
        public List<Company> Companies { get; set; }

        public List<Person> Emloyees { get; set; }
    }
}
