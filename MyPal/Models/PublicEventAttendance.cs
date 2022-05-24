using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Models
{
    public class PublicEventAttendance
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }
        [ForeignKey("PublicEvents")]
        public int PublicEventId { get; set; }

        public PublicEventAttendance(string userId, int publicEventId)
        {
            UserId = userId;
            PublicEventId = publicEventId;
        }
    }
}
