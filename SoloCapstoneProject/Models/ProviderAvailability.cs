using System;
using System.Collections.Generic;
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
        public string DayOfWeek { get; set; }
        public string OpeningHour { get; set; }
        public string ClosingHour { get; set; }

        [ForeignKey("Providers")]
        public int ProviderId { get; set; }
        public Provider Providers { get; set; }

    }
}
