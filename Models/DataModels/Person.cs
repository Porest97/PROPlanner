using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROPlanner.Models.DataModels
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }

        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }

        [Display(Name = "Telefonnummer1")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefonnummer2")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber2 { get; set; }

        public string PhoneNumbers { get { return string.Format("{0} {1} ", PhoneNumber1, PhoneNumber2); } }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Person Type")]
        public int? PersonTypeId { get; set; }
        [Display(Name = "Person Type")]
        [ForeignKey("PersonTypeId")]
        public PersonType PersonType { get; set; }

        [Display(Name = "Company")]
        public int? CompanyId { get; set; }
        [Display(Name = "Company")]
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [Display(Name = "Pos#")]
        public string PlayerPossition { get; set; }

        [Display(Name = "SSN#")]
        public string SSN { get; set; }

        [Display(Name = "Player")]
        public string PlayerString { get { return string.Format("{0} {1} {2} ", FullName, PlayerPossition, SSN); } }


    }
}
