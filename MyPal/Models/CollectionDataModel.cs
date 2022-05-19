using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Models
{
    public class CollectionDataModel
    {
        // List of pinpoints
        public List<Pinpoints> PinpointsList { get; set; }

        // PrivateEvents object
        public PrivateEvents PrivateEvents { get; set; }

        // Pinpoints object
        public Pinpoints Pinpoints { get; set; }

        //PublicEvents object
        public PublicEvents PublicEvents { get; set; }
        // List of private events
        public List<PrivateEvents> PrivateEventsList { get; set;}
        
        // List of public events
        public List<PublicEvents> PublicEventsList { get; set; }

        // List of events that that user is attending
        public List<PublicEvents> AttendingPublicEventsList { get; set; }

        // Attendance list
        public List<PublicEventAttendance> PublicEventAttendances { get; set; }

        // Used for event attendance
        public bool AlreadyAttending { get; set; }

        // String to get UserId
        public string CurrentUserId { get; set; }

    }
}
