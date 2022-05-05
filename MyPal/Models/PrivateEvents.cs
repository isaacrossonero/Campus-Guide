using System;
using System.Collections;
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

    public class Events : IEnumerable
    {
        private PrivateEvents[] _events;
        public Events(PrivateEvents[] pArray)
        {
            _events = new PrivateEvents[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _events[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_events);
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class PeopleEnum : IEnumerator
    {
        public PrivateEvents[] _events;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public PeopleEnum(PrivateEvents[] list)
        {
            _events = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _events.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public PrivateEvents Current
        {
            get
            {
                try
                {
                    return _events[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
