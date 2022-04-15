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

        //PublicEvents object
        public PublicEvents PublicEvents { get; set; }
        // List of private events
        public List<PrivateEvents> PrivateEventsList { get; set;}
        // List of public events
        public List<PublicEvents> PublicEventsList { get; set; }
    }
}
