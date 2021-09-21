using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Event
    {
        //Create a sorted list and list the properties
        public SortedList<int, int> items;
        public string EventName { get; private set; }
        public string EventType{ get; private set; }
        public string EventVenue { get; private set; }
        public string EventDateTime { get; private set; }
        public string EventCounty { get; private set; }
        public int TicketPrice { get; private set; }

        public Event(string eventName, string eventType, string eventVenue, string eventDateTime, string eventCounty, int ticketPrice)
        {
            items = new SortedList<int, int>();
            EventName = eventName;
            EventType = eventType;
            EventVenue = eventVenue;
            EventDateTime = eventDateTime;
            EventCounty = eventCounty;
            TicketPrice = ticketPrice;
        }

    }
}
