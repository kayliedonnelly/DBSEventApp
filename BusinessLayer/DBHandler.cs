using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DBHandler
    {
        private DBAccess d;

        public DBHandler(string passwordConnect)
        {
            d = new DBAccess(passwordConnect);
        }


        //Check if the connection is successful
        public bool Connect(string usernameConnect, string passwordConnect)
        {
            bool connectStatus = d.connectStatus();
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
        public bool Login(string usernameLogin, string passwordLogin)
        {
            string[] userdata = d.getUserInfo(usernameLogin);
            if (userdata == null)
            {
                return false;
            }
            return passwordLogin == userdata[1];
        }

        //Check if the sign up is successful
        public bool Signup(string usernameSignup, string passwordSignup)
        {
            bool signupStatus = d.insertUserInfo(usernameSignup, passwordSignup);

            if (signupStatus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check if adding the event is successful
        public bool AddEvent(string eventID, string eventName)
        {
            bool addEventStatus = d.insertEventInfo(eventID, eventName);

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
        public bool UpdateEvent(string eventIDUpdate, string eventNameUpdate)
        {
            bool updateEventStatus = d.updateEventInfo(eventIDUpdate, eventNameUpdate);

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
        public bool DeleteEvent(string eventIDDelete)
        {
            bool deleteEventStatus = d.deleteEventInfo(eventIDDelete);

            if (deleteEventStatus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
