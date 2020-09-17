using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Models
{
    public class Services
    {
        [Key]
        public int MyProperty { get; set; }
        public string LawnServices { get; set; }
        public string TrashCleanup { get; set; }
        public string Planting { get; set; }
        public string BugTreatment { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

    }
}
