using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Models
{
    public class Order
    {

        [Key]
        public int OrderId { get; set; }
        public string ServiceDate { get; set; }
        public double? ProviderEstimate { get; set; }

        [ForeignKey("Consumer")]
        public int ConsumerId { get; set; }
        public Consumer Consumers { get; set; }

        [ForeignKey("Services")]
        public int ServiceId { get; set; }

        public Service Services { get; set; }
    }
}
