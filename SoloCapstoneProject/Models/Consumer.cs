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
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }

        public Users Users { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}
