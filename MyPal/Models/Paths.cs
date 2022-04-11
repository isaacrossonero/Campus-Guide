using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Models
{
    public class Paths
    {
        [Key]
        public int PinpointIdOne { get; set; }
        [Key]
        public int PinpointIdTwo { get; set; }
    }
}
