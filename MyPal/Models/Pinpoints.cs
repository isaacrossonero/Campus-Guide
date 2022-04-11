﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Models
{
    public class Pinpoints
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("PinpointsTypes")]
        public int PinpointTypesId { get; set; }
        [ForeignKey("Floors")]
        public int FloorId { get; set; }
    }
}
