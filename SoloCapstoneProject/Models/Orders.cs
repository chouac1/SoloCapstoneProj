using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Models
{
    public class Orders
    {

        [Key]
        public int OrderId { get; set; }
        public string ServiceDate { get; set; }
        public double? ProviderEstimate { get; set; }

        [ForeignKey("Consumer")]
        public int ConsumerId { get; set; }
        public Consumers Consumers { get; set; }

        [ForeignKey("Services")]
        public int ServiceId { get; set; }

        public Services Services { get; set; }
    }
}
