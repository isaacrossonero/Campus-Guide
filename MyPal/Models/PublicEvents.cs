using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Models
{
    public class PublicEvents
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Start time")]
        public DateTime StartTime { get; set; }
        [DisplayName("End time")]
        public DateTime EndTime { get; set; }
        public int Capacity { get; set; }
        [ForeignKey("Pinpoints")]
        [DisplayName("Pinpoint ID")]
        public int PinpointId { get; set; }
    }
}
