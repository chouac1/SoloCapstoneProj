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
        public double ProviderEstimate { get; set; }
        public string ProviderComments { get; set; }
        public string ConsumerComments { get; set; }
        public bool isAppointConfirmed { get; set; }

        [ForeignKey("Consumer")]
        public int ConsumerId { get; set; }
        public Consumer Consumers { get; set; }

        [ForeignKey("Provider")]
        public int ProviderId { get; set; }

        public Provider Provider { get; set; }
    }
}
