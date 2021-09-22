using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        //Create a sorted list and list the properties
        public SortedList<int, int> items;
        public string Username { get; private set; }
        public string Password { get; private set; }

        public User(string username, string password)
        {
            items = new SortedList<int, int>();
            Username = username;
            Password = password;
        }
    }
}
