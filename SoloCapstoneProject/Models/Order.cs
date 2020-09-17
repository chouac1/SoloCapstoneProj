using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Models
{
    public class Order
    {

        [Key]
        public int OrderId { get; set; }
        public string ConsumerName { get; set; }
        public string ConsumerAddress { get; set; }
        public string ConsumerCity { get; set; }
        public string ConsumerZip { get; set; }
        public string ServiceDate { get; set; }


    }
}
