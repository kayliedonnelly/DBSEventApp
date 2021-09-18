using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Event
    {
        //Attributes 
        public int EventID { get; set; }
        public string EventName { get; set; }

        //Default Constructor
        public Event()
        {

        }

        //Overoaded Constructor
        public Event(int eventID, string eventName)
        {
            EventID = eventID;
            EventName = eventName;
        }

        //Override ToString() Method
        public override string ToString()
        {
            return $"\nEvent ID: {EventID} \nEvent Name: {EventName}";
        }
    }
}
