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
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Start time")]
        public DateTime StartTime { get; set; }
        [DisplayName("End time")]
        public DateTime EndTime { get; set; }
        [ForeignKey("Pinpoints")]
        [DisplayName("Pin-point ID")]
        public int PinpointId { get; set; }
        [ForeignKey("AspNetUsers")]
        [DisplayName("User ID")]
        public string UserId { get; set; }
    }
}
