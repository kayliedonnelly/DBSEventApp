using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Events
    {
        public List<Event> eventList = new List<Event>();

        public void AddEvent(int eventID, string eventName, string eventType, string eventVenue, string eventDateTime, string eventCounty, int ticketPrice)
        {
            Event eventItem = new Event();
            eventItem.EventID = eventID;
            eventItem.EventName = eventName;
            eventItem.EventType = eventType;
            eventItem.EventVenue = eventVenue;
            eventItem.EventDateTime = eventDateTime;
            eventItem.EventCounty = eventCounty;
            eventItem.TicketPrice = ticketPrice;
        }
    }
}
