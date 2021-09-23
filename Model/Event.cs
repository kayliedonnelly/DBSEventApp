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
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventType { get; set; }
        public string EventVenue { get; set; }
        public string EventDateTime { get; set; }
        public string EventCounty { get; set; }
        public int TicketPrice { get; set; }

        //Default constructor
        public Event()
        {

        }

        //Overloaded constructor
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

        public Event(int eventID)
        {
            EventID = eventID;
        }

        //public List<Event> AddEvent(int eventID, string eventName, string eventType, string eventVenue, string eventDateTime, string eventCounty, int ticketPrice)
        //{
        //    List<Event> eventList = new List<Event>();
        //    eventList.EventID = eventID;
        //    eventList.EventName = eventName;
        //    eventList.EventType = eventType;
        //    eventList.EventVenue = eventVenue;
        //    eventList.EventDateTime = eventDateTime;
        //    eventItem.EventCounty = eventCounty;
        //    eventItem.TicketPrice = ticketPrice;
        //    return eventItem;
        //}





    }
}
