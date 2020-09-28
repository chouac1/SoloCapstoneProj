using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Models
{
    public class ProviderAvailability
    {

        [Key]
        public int ProviderAvailablityId { get; set; }
        [DisplayName("Day of the Week")]
        public string WeekDay { get; set; }
        [DisplayName("Opening Hours")]
        public string OpeningHour { get; set; }
        [DisplayName("Closing Hours")]
        public string ClosingHour { get; set; }
        [DisplayName("Availabile")]
        public bool isAvailable { get; set; }

        [DisplayName("Schedule Appointment")]
        public bool isBooked { get; set; }

        [ForeignKey("Providers")]
        public int ProviderId { get; set; }
        public Provider Providers { get; set; }

    }
}
