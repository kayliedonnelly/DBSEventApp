using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        //Create a sorted list and list the properties
        public SortedList<int, int> items;
        public int EventID { get; private set; }
        public int TicketQuantity { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public int PhoneNumber { get; private set; }

        public Order(int eventID, int ticketQuantity, string firstName, string lastName, string email, int phoneNumber)
        {
            items = new SortedList<int, int>();
            EventID = eventID;
            TicketQuantity = ticketQuantity;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        //Method to add an item to an order
        public bool InsertOrderInfo(int EventID, int ticketQuantity, string firstName, string lastName, string email, int phoneNumber)
        {
            items[EventID] += ticketQuantity;
            return true;
        }
    }
}
