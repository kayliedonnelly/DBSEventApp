using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DBAccess
    {
        SqlConnection conn;

        public DBAccess()
        {
        }

        //Connect to database
        public DBAccess(string passwordConnect)
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
                connectStatus();
            }
            else
            {
                Console.WriteLine("\nConnection Successful");
                connectStatus();
            }
        }

        //Check connection status
        public bool connectStatus()
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
        public string[] getUserInfo(string u)
        {
            SqlCommand c = new SqlCommand("SELECT * from Login WHERE username = @u", conn);
            c.Parameters.AddWithValue("@u", u);
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
                    ret[0] = r[0].ToString();
                    ret[1] = r[1].ToString();
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
        public bool insertUserInfo(string usernameSignup, string passwordSignup)
        {
            SqlCommand c = new SqlCommand("INSERT INTO Login (username, password) VALUES(@username, @password)", conn);
            c.Parameters.AddWithValue("@username", usernameSignup);
            c.Parameters.AddWithValue("@password", passwordSignup);
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
        public bool insertEventInfo(string eventID, string eventName)
        {
            SqlCommand c = new SqlCommand("INSERT INTO Event (eventID, eventName) VALUES(@eventID, @eventName)", conn);
            c.Parameters.AddWithValue("@eventID", eventID);
            c.Parameters.AddWithValue("@eventName", eventName);
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
        public bool updateEventInfo(string eventIDUpdate, string eventNameUpdate)
        {
            SqlCommand c = new SqlCommand("UPDATE Event SET eventName = @eventNameUpdate WHERE eventID = @eventIDUpdate", conn);
            c.Parameters.AddWithValue("@eventIDUpdate", eventIDUpdate);
            c.Parameters.AddWithValue("@eventNameUpdate", eventNameUpdate);
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
        public bool deleteEventInfo(string eventIDDelete)
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

    }

}
