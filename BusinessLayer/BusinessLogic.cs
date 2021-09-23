using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessLogic
    {
        private DataAccess da;

        public BusinessLogic(string passwordConnect)
        {
            da = new DataAccess(passwordConnect);
        }


        //Check if the connection is successful
        public bool UserConnect(string usernameConnect, string passwordConnect)
        {
            bool connectStatus = da.ConnectStatus();
            if (connectStatus == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check if the login is successful
        public bool UserLogin(string usernameLogin, string passwordLogin)
        {
            User user = new User(usernameLogin, passwordLogin);
            string[] userdata = da.GetUserInfo(user);
            if (userdata == null)
            {
                return false;
            }
            return passwordLogin == userdata[1];
        }

        //Check if the sign up is successful
        public bool UserSignup(string usernameSignup, string passwordSignup)
        {
            User user = new User(usernameSignup, passwordSignup);
            bool signupStatus = da.InsertUserInfo(user);

            if (signupStatus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Create an event and check if adding the event is successful
        public bool InsertEvent(string eventName, string eventType, string eventVenue, string eventDateTime, string eventCounty, int ticketPrice)
        {
            Event currentEvent = new Event(eventName, eventType, eventVenue, eventDateTime, eventCounty, ticketPrice);
            
            //Events eventList = new Events();
            //eventList.AddEvent(eventName, eventType, eventVenue, eventDateTime, eventCounty, ticketPrice);

            //Check if adding the event is successful
            bool addEventStatus = da.InsertEventInfo(currentEvent);
            if (addEventStatus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check if updating the event is successful
        public bool UpdateEvent(int eventID, string eventNameUpdate, string eventTypeUpdate, string eventVenueUpdate, string eventDateTimeUpdate, string eventCountyUpdate, int ticketPriceUpdate)
        {
            bool updateEventStatus = da.UpdateEventInfo(eventID, eventNameUpdate, eventTypeUpdate, eventVenueUpdate, eventDateTimeUpdate, eventCountyUpdate, ticketPriceUpdate);

            if (updateEventStatus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check if deleting the event is successful
        public bool DeleteEvent(int eventIDDelete)
        {
            bool deleteEventStatus = da.DeleteEventInfo(eventIDDelete);

            if (deleteEventStatus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Create an order
        public void InsertOrder(int EventID, int ticketQuantity, string firstName, string lastName, string email, int phoneNumber)
        {
            Order currentOrder = new Order(EventID, ticketQuantity, firstName, lastName, email, phoneNumber);
            da.InsertOrderInfo(currentOrder);
        }

        //Search all events
        public List<Event> SearchAllEvents()
        {
            List<Event> eventList =  da.SearchAllEvents();

            if (eventList == null)
            {
                return null;
            }
            return eventList;
        }

    }

}

