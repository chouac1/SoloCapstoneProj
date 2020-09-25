using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Models
{
    public class Consumer
    {

        [Key]
        public int ConsumerId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        //[DisplayName("Request a lawn service")]
        //public string OneTimePickup { get; set; }
        //[DisplayName("Start Date")]
        //public string StartDate { get; set; }
        //[DisplayName("End Date")]
        //public string EndDate { get; set; }
        //[DisplayName("Weekly Lawn Service")]
        //public string WeeklyService { get; set; }
        //[DisplayName("Monthly Lawn Service")]
        //public string MonthlyService { get; set; }
        //[DisplayName("Service Confirmed")]
        //public bool isConfirmed { get; set; }

        [ForeignKey("IdentityUser")]
        [DisplayName("User Id")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }


    }
}
