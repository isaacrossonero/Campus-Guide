using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Models
{
    public class CollectionDataModel
    {
        // List of private events
        public List<Pinpoints> PinpointsList { get; set; }

        // PrivateEvents object
        public PrivateEvents PrivateEvents { get; set; }
    }
}
