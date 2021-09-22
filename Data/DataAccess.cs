using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataAccess
    {
        SqlConnection conn;

        public DataAccess()
        {
        }

        //Connect to database
        public DataAccess(string passwordConnect)
        {
            //conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Integrated Security = True; Initial Catalog = Login");
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["azuredb"].ConnectionString.Replace("********", passwordConnect));
            try
            {
                conn.Open();
            }
            catch
            {

            }
            if (conn.State != ConnectionState.Open)
            {
                Console.WriteLine("\nConnection Failed");
                ConnectStatus();
            }
            else
            {
                Console.WriteLine("\nConnection Successful");
                ConnectStatus();
            }
        }

        //Check connection status
        public bool ConnectStatus()
        {
            if (conn.State != ConnectionState.Open)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Get user details from the database
        public string[] GetUserInfo(User u)
        {
            //Value for order information
            string username = u.Username;

            SqlCommand c = new SqlCommand("SELECT * from [User] WHERE username = @usernameLogin", conn);
            c.Parameters.AddWithValue("@usernameLogin", username);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                 conn.Open();
                }
                SqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    string[] ret = new string[2];
                    ret[0] = r[1].ToString();
                    ret[1] = r[2].ToString();
                    return ret;
                }
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        //Insert user details into the database
        public bool InsertUserInfo(User u)
        {
            //Value for order information
            string username= u.Username;
            string password = u.Password;

            SqlCommand c = new SqlCommand("INSERT INTO [User] (username, password) VALUES(@usernameSignup, @passwordSignup)", conn);
            c.Parameters.AddWithValue("@usernameSignup", username);
            c.Parameters.AddWithValue("@passwordSignup", password);
            try
            {
                int i = c.ExecuteNonQuery();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        //Insert event details into the database
        public bool InsertEventInfo(Event e)
        {
            //Value for event information
            string eventName = e.EventName;
            string eventType = e.EventType;
            string eventVenue = e.EventVenue;
            string eventDateTime = e.EventDateTime;
            string eventCounty = e.EventCounty;
            int ticketPrice = e.TicketPrice;

            SqlCommand c = new SqlCommand("INSERT INTO Event (eventName, eventType, eventVenue, eventDateTime, eventCounty, ticketPrice) " +
                "VALUES(@eventName, @eventType, @eventVenue, @eventDateTime, @eventCounty, @ticketPrice)", conn);
            c.Parameters.AddWithValue("@eventName", eventName);
            c.Parameters.AddWithValue("@eventType", eventType);
            c.Parameters.AddWithValue("@eventVenue", eventVenue);
            c.Parameters.AddWithValue("@eventDateTime", eventDateTime);
            c.Parameters.AddWithValue("@eventCounty", eventCounty);
            c.Parameters.AddWithValue("@TicketPrice", ticketPrice);
            conn.Open();
            try
            {
                int i = c.ExecuteNonQuery();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        //Update event details into the database
        public bool UpdateEventInfo(int eventID, string eventNameUpdate, string eventTypeUpdate, string eventVenueUpdate, string eventDateTimeUpdate, string eventCountyUpdate, int ticketPriceUpdate)
        {
            SqlCommand c = new SqlCommand("UPDATE Event SET eventName = @eventNameUpdate, eventType = @eventTypeUpdate, eventVenue = @eventVenueUpdate, eventDateTime = @eventDateTimeUpdate, eventCounty = @eventCountyUpdate, ticketPrice = @ticketPriceUpdate WHERE eventID = @eventID", conn);
            c.Parameters.AddWithValue("@eventID", eventID);
            c.Parameters.AddWithValue("@eventNameUpdate", eventNameUpdate);
            c.Parameters.AddWithValue("@eventTypeUpdate", eventTypeUpdate);
            c.Parameters.AddWithValue("@eventVenueUpdate", eventVenueUpdate);
            c.Parameters.AddWithValue("@eventDateTimeUpdate", eventDateTimeUpdate);
            c.Parameters.AddWithValue("@eventCountyUpdate", eventCountyUpdate);
            c.Parameters.AddWithValue("@TicketPriceUpdate", ticketPriceUpdate);
            conn.Open();
            try
            {
                int i = c.ExecuteNonQuery();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        //Delete event details into the database
        public bool DeleteEventInfo(int eventIDDelete)
        {
            SqlCommand c = new SqlCommand("DELETE FROM Event WHERE eventID = @eventIDDelete", conn);
            c.Parameters.AddWithValue("@eventIDDelete", eventIDDelete);
            conn.Open();
            try
            {
                int i = c.ExecuteNonQuery();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        //Insert Order into the database
        public int InsertOrderInfo(Order o)
        {
            //Value for order information
            int orderID = -1;
            int eventID = o.EventID;
            int ticketQuantity = o.TicketQuantity;
            string firstName = o.FirstName;
            string lastName = o.LastName;
            string email = o.Email;
            int phoneNumber = o.PhoneNumber;

            //Insert event values into the Orders table
            SqlCommand cmd = new SqlCommand("INSERT INTO Orders" +
                "(EventID,TicketQuantity,FirstName,LastName,Email,PhoneNumber) VALUES(" +
                "@EventID,@ticketQuantity,@firstName,@lastName,@email,@phoneNumber);", conn);
            cmd.Parameters.AddWithValue("@EventID", eventID);
            cmd.Parameters.AddWithValue("@ticketQuantity", ticketQuantity);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlCommand c2 = new SqlCommand("SELECT IDENT_CURRENT('Orders')", conn);
                object o1 = c2.ExecuteScalar();
                orderID = int.Parse(o1.ToString());
                SqlCommand c3 = new SqlCommand("INSERT INTO OrderLine" +
                    "VALUES(@orderID,@eventID,@ticketQuantity)", conn);
                c3.Parameters.AddWithValue("@orderID", orderID);
                foreach (KeyValuePair<int, int> kv in o.items)
                {
                    int key = kv.Key;
                    int val = kv.Value;
                    c3.Parameters.AddWithValue("@EventID", key);
                    c3.Parameters.AddWithValue("@ticketQuantity", val);
                    c3.ExecuteNonQuery();
                }
            }
            finally
            {
                conn.Close();
            }
            return orderID;
        }
    }



}
