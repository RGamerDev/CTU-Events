using CTU_Events.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTU_Events.Data
{
    public class EventsContext
    {
        public List<Event> Events;

        public EventsContext()
        {
            Events = new List<Event>()
            {
                new Event
                {
                    id = 0,
                    Title = "Potchefstroom Student Workshop Design Faculty",
                    Description = "You are invited! Come and join us for a student workshop on CTU's design tracks at a Potchefstroo...",
                    Image = "/Event pictures/1.jpg",
                    Link = "https://ctutraining.ac.za/upcoming-events/potchefstroom-student-workshop-design-faculty/"
                },
                new Event
                {
                    id = 1,
                    Title = "Career One2One Saturday",
                    Description = "Stay Calm! Book your ONE2ONE session now!...",
                    Image = "/Event pictures/2.jpg",
                    Link = "https://ctutraining.ac.za/upcoming-events/one2onesession/"
                },
                new Event
                {
                    id = 2,
                    Title = "Student Workshop Business/Management Facility",
                    Description = "You are invited! Come and join us for a student workshop on CTU's business/management tracks at a...",
                    Image = "/Event pictures/3.jpg",
                    Link = "https://ctutraining.ac.za/upcoming-events/student-workshop-business-management-facility-2/"
                },
            };
        }
    }
}
