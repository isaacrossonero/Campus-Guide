using System;
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

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Description length can't be more than 50 characters.")]
        public string Description { get; set; }

        [Required]
        [ForeignKey("PinpointsTypes")]
        public int PinpointTypesId { get; set; }

        [ForeignKey("Floors")]
        public int FloorId { get; set; }
    }
}
