using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Models
{
    public class PrivateEvents
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Event name")]
        [StringLength(30, ErrorMessage = "Description length can't be more than 30 characters.")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Event description")]
        [StringLength(300, ErrorMessage = "Description length can't be more than 300 characters.")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Start time")]
        public DateTime StartTime { get; set; }

        [Required]
        [DisplayName("End time")]
        public DateTime EndTime { get; set; }

        [Required]
        [ForeignKey("Pinpoints")]
        [DisplayName("Pinpoint")]
        
        public int PinpointId { get; set; }

        [ForeignKey("AspNetUsers")]
        [DisplayName("User")]
        public string UserId { get; set; }
       
    }
}
