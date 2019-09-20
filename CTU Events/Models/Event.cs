using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTU_Events.Models
{
    public class Event : IComparable<Event>
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }

        public int CompareTo(Event other)
        {
            return this.Title.CompareTo(other.Title);
        }
    }
}