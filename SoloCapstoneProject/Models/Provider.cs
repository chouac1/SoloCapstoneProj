using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Models
{
    public class Provider
    {

        [Key]
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Address")]
        public string ProviderAddress { get; set; }
        [DisplayName("City")]
        public string ProviderCity { get; set; }
        [DisplayName("Zipcode")]
        public string Zipcode { get; set; }

        [ForeignKey("Users")]
        public int UsersId { get; set; }
        public Users Users { get; set; }

        [ForeignKey("Calendar")]
        public int CalendarId { get; set; }
        public Calendar Calendar { get; set; }

    }
}
