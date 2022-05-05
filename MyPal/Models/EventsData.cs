using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Models
{
    public class EventsData
    {
        public IEnumerable<PrivateEvents> allData { get; set; }
        public IEnumerable<PrivateEvents> firstData { get; set; }
    }
}
