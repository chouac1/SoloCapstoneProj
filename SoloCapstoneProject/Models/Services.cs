﻿using System;
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
        public int ServiceId { get; set; }
        public string TypeOfService { get; set; }
        public string Price { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("Providers")]
        public int ProviderId { get; set; }
        public Providers Providers { get; set; }
    }
}
