using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an instance of the BusinessLogic Class
            Business.BusinessLogic bl;

            //WhileLoop - Connect Menu
            bool continueLooping1 = true;
            while (continueLooping1)
            {
                //Main Menu - Ask the user to login or sign up
                Console.WriteLine("********************Connect Menu*************************\n");
                Console.WriteLine("1. Connect");
                Console.WriteLine("2. Quit\n");
                Console.Write("Please choose option 1 or 2: ");
                int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    //Connect
                    case 1:
                        //Connect
                        bool continueLooping2 = true;
                        //Continue to ask the user to connect until successful
                        while (continueLooping2)
                        {
                            //Ask the user to input their usernme and password to connect
                            Console.WriteLine("\n**********************Connect**************************\n");
                            Console.Write("Please enter your username: ");
                            string usernameConnect = Console.ReadLine();
                            while (usernameConnect.Trim() == String.Empty)
                            {
                                Console.Write("The username is required. Please enter the username: ");
                                usernameConnect = Console.ReadLine();
                            }
                            Console.Write("Please enter your password: ");
                            string passwordConnect = Console.ReadLine();
                            while (passwordConnect.Trim() == String.Empty)
                            {
                                Console.Write("The password is required. Please enter the password: ");
                                passwordConnect = Console.ReadLine();
                            }

                            bl = new Business.BusinessLogic(passwordConnect);
                            bool successConnect = bl.UserConnect(usernameConnect, passwordConnect); //Call the UserConnect method in the BusinessLogic
                            if (successConnect)
                            {
                                bool continueLooping3 = true;
                                //Contiune to ask the user if they would lke to login, signup or quit
                                while (continueLooping3)
                                {
                                    //Main Menu - Ask the user to login, sign up or quit
                                    Console.WriteLine("\n*********************Login Menu*************************\n");
                                    Console.WriteLine("1. Login");
                                    Console.WriteLine("2. Sign Up");
                                    Console.WriteLine("3. Quit");
                                    Console.Write("\nPlease choose option 1 or 3: ");
                                    int.TryParse(Console.ReadLine(), out int option);

                                    //Switch statement
                                    switch (option)
                                    {
                                        case 1:
                                            bool continuelooping4 = true;
                                            while (continuelooping4)
                                            {
                                                //Ask the user to input their username and password to login
                                                Console.WriteLine("\n***********************Login***************************\n");
                                                Console.Write("Please enter your username: ");
                                                string usernameLogin = Console.ReadLine();
                                                while (usernameLogin.Trim() == String.Empty)
                                                {
                                                    Console.Write("The username is required. Please enter the username: ");
                                                    usernameLogin = Console.ReadLine();
                                                }
                                                Console.Write("Please enter your password: ");
                                                string passwordLogin = Console.ReadLine();
                                                while (passwordLogin.Trim() == String.Empty)
                                                {
                                                    Console.Write("The password is required. Please enter the username: ");
                                                    passwordLogin = Console.ReadLine();
                                                }
                                                bool success = bl.UserLogin(usernameLogin, passwordLogin); //Call the UserLogin method in the BusinessLogic
                                                if (success)
                                                {
                                                    Console.WriteLine("\nLogin Successful");

                                                    bool continueLooping5 = true;
                                                    while (continueLooping5)
                                                    {
                                                        //int option1 = MainMenu();
                                                        Console.WriteLine("\n*********************Main Menu************************\n");
                                                        Console.WriteLine("1. Add event");
                                                        Console.WriteLine("2. Update event");
                                                        Console.WriteLine("3. Delete event");
                                                        Console.WriteLine("4. Search event");
                                                        Console.WriteLine("5. Quit\n");
                                                        Console.Write("Please choose an option between 1-5: ");
                                                        int.TryParse(Console.ReadLine(), out option);

                                                        //Switch statement
                                                        switch (option)
                                                        {
                                                            //Add an event
                                                            case 1:
                                                                //AddEvent();
                                                                Console.WriteLine("\n********************Add Event************************\n");
                                                                Console.Write("Please enter the event name: ");
                                                                string eventName = Console.ReadLine();
                                                                while (eventName.Trim() == String.Empty)
                                                                {
                                                                    Console.Write("The event name is required. Please enter the event name: ");
                                                                    eventName = Console.ReadLine();
                                                                }
                                                                Console.Write("Please enter the event type: ");
                                                                string eventType = Console.ReadLine();
                                                                while (eventType.Trim() == String.Empty)
                                                                {
                                                                    Console.Write("The event type is required. Please enter the event type: ");
                                                                    eventType = Console.ReadLine();
                                                                }
                                                                Console.Write("Please enter the event venue: ");
                                                                string eventVenue = Console.ReadLine();
                                                                while (eventVenue.Trim() == String.Empty)
                                                                {
                                                                    Console.Write("The event venue is required. Please enter the event venue: ");
                                                                    eventVenue = Console.ReadLine();
                                                                }
                                                                Console.Write("Please enter the event date and time: ");
                                                                string eventDateTime = Console.ReadLine();
                                                                while (eventDateTime.Trim() == String.Empty)
                                                                {
                                                                    Console.Write("The event date and time are required. Please enter the event date and time: ");
                                                                    eventDateTime = Console.ReadLine();
                                                                }
                                                                Console.Write("Please enter the event county: ");
                                                                string eventCounty = Console.ReadLine();
                                                                while (eventCounty.Trim() == String.Empty)
                                                                {
                                                                    Console.Write("The event county is required. Please enter the event county: ");
                                                                    eventCounty = Console.ReadLine();
                                                                }
                                                                Console.Write("Please enter the event ticket price: ");
                                                                do
                                                                {
                                                                    if (int.TryParse(Console.ReadLine(), out int TicketPrice))
                                                                    {
                                                                        bool successEvent = bl.InsertEvent(eventName, eventType, eventVenue, eventDateTime, eventCounty, TicketPrice); //Call the InsertEvent method in the BusinessLogic
                                                                        if (successEvent)
                                                                        {
                                                                            Console.WriteLine("\nEvent Added Successfully\n");
                                                                            continueLooping3 = false;
                                                                        }
                                                                        break;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.Write("The ticket price must be a number. Please enter the ticket price: ");
                                                                    }
                                                                } while (1 == 1);
                                                                break;
                                                            case 2:
                                                                //Update event
                                                                Console.WriteLine("\n******************Update Event************************\n");
                                                                Console.Write("Please enter the event ID: ");
                                                                bool continueLooping6 = true;

                                                                while (continueLooping6)
                                                                {
                                                                    if (int.TryParse(Console.ReadLine(), out int eventID))
                                                                    {
                                                                        Console.Write("Please enter the event name: ");
                                                                        string eventNameUpdate = Console.ReadLine();
                                                                        while (eventNameUpdate.Trim() == String.Empty)
                                                                        {
                                                                            Console.Write("The new event name is required. Please enter the event name: ");
                                                                            eventNameUpdate = Console.ReadLine();
                                                                        }
                                                                        Console.Write("Please enter the event type: ");
                                                                        string eventTypeUpdate = Console.ReadLine();
                                                                        while (eventTypeUpdate.Trim() == String.Empty)
                                                                        {
                                                                            Console.Write("The new event type is required. Please enter the new event type: ");
                                                                            eventTypeUpdate = Console.ReadLine();
                                                                        }
                                                                        Console.Write("Please enter the event venue: ");
                                                                        string eventVenueUpdate = Console.ReadLine();
                                                                        while (eventVenueUpdate.Trim() == String.Empty)
                                                                        {
                                                                            Console.Write("The new event venue is required. Please enter the new event venue: ");
                                                                            eventVenueUpdate = Console.ReadLine();
                                                                        }
                                                                        Console.Write("Please enter the event date and time: ");
                                                                        string eventDateTimeUpdate = Console.ReadLine();
                                                                        while (eventDateTimeUpdate.Trim() == String.Empty)
                                                                        {
                                                                            Console.Write("The new event date and time are required. Please enter the event date and time: ");
                                                                            eventDateTimeUpdate = Console.ReadLine();
                                                                        }
                                                                        Console.Write("Please enter the event county: ");
                                                                        string eventCountyUpdate = Console.ReadLine();
                                                                        while (eventCountyUpdate.Trim() == String.Empty)
                                                                        {
                                                                            Console.Write("The new event county is required. Please enter the new event county: ");
                                                                            eventCountyUpdate = Console.ReadLine();
                                                                        }
                                                                        Console.Write("Please enter the event ticket price: ");
                                                                        do
                                                                        {
                                                                            if (int.TryParse(Console.ReadLine(), out int TicketPriceUpdate))
                                                                            {
                                                                                bool successEventUpdate = bl.UpdateEvent(eventID, eventNameUpdate, eventTypeUpdate, eventVenueUpdate, eventDateTimeUpdate, eventCountyUpdate, TicketPriceUpdate); //Call the UpdateEvent method in the BusinessLogic
                                                                                if (successEventUpdate)
                                                                                {
                                                                                    Console.WriteLine("\nEvent Update Successful\n");
                                                                                    continueLooping6 = false;
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("\nFailed to update event. Event does not exist.\n");
                                                                                }
                                                                                break;

                                                                            }
                                                                            else
                                                                            {
                                                                                Console.Write("The ticket price must be a number. Please enter the ticket price: ");
                                                                            }
                                                                        } while (1 == 1);
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.Write("The event ID must be a number. Please enter the Event ID: ");
                                                                    }
                                                                }
                                                                break;
                                                            case 3:
                                                                //Delete event
                                                                Console.WriteLine("\n******************Delete Event************************\n");
                                                                Console.Write("Please enter the event ID: ");
                                                                int.TryParse(Console.ReadLine(), out int eventIDDelete);

                                                                bool successEventDelete = bl.DeleteEvent(eventIDDelete); //Call the DeleteEvent method in the BusinessLogic
                                                                if (successEventDelete)
                                                                {
                                                                    Console.WriteLine("\nEvent Deleted Successfully");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("\nFailed to delete event. Event does not exist.");
                                                                }
                                                                break;
                                                            case 4:
                                                                bool continueLooping7 = true;

                                                                while (continueLooping7)
                                                                {
                                                                    //Search event
                                                                    Console.WriteLine("\n*******************Search Event***********************\n");
                                                                    Console.WriteLine("1. Search all events");
                                                                    Console.WriteLine("2. Search for an event by county");
                                                                    Console.WriteLine("3. Return to Main Menu");
                                                                    Console.WriteLine("4. Quit\n");
                                                                    Console.Write("Please choose an option between 1-3: ");
                                                                    int.TryParse(Console.ReadLine(), out option);

                                                                    //Switch statement
                                                                    switch (option)
                                                                    {
                                                                        //Search all events
                                                                        case 1:
                                                                            //display a list of all events
                                                                            List<Event> eventList = bl.SearchAllEvents(); //Call the SearchAllEvents method in the BusinessLogic
                                                                            Console.WriteLine("\n*********************All Events***********************\n");
                                                                            Console.WriteLine("----------------------------------------------------");
                                                                            foreach (Event e in eventList)
                                                                            {
                                                                                Console.WriteLine("Event ID: " + e.EventID);
                                                                                Console.WriteLine("Event Name: " + e.EventName);
                                                                                Console.WriteLine("Event Type: " + e.EventType);
                                                                                Console.WriteLine("Event Venue: " + e.EventVenue);
                                                                                Console.WriteLine("Event Date and Time: " + e.EventDateTime);
                                                                                Console.WriteLine("Event County: " + e.EventCounty);
                                                                                Console.WriteLine("Event Ticket Price: " + e.TicketPrice);
                                                                                Console.WriteLine("----------------------------------------------------");
                                                                            }

                                                                            bool continueLooping8 = true;

                                                                            while (continueLooping8)
                                                                            {
                                                                                Console.WriteLine("\n*******************Options***********************\n");
                                                                                Console.WriteLine("1. Update event");
                                                                                Console.WriteLine("2. Delete event");
                                                                                Console.WriteLine("3. Purchase event ticket");
                                                                                Console.WriteLine("4. Return to the Search Event Menu");
                                                                                Console.WriteLine("5. Quit\n");
                                                                                Console.Write("Please choose an option between 1-5: ");
                                                                                int.TryParse(Console.ReadLine(), out option);

                                                                                switch (option)
                                                                                {
                                                                                    case 1:
                                                                                        Console.WriteLine("\n******************Update Event************************\n");
                                                                                        Console.Write("Please enter the event ID: ");
                                                                                        bool continueLooping9 = true;

                                                                                        while (continueLooping9)
                                                                                        {
                                                                                            if (int.TryParse(Console.ReadLine(), out int eventID))
                                                                                            {
                                                                                                Console.Write("Please enter the event name: ");
                                                                                                string eventNameUpdate = Console.ReadLine();
                                                                                                while (eventNameUpdate.Trim() == String.Empty)
                                                                                                {
                                                                                                    Console.Write("The new event name is required. Please enter the event name: ");
                                                                                                    eventNameUpdate = Console.ReadLine();
                                                                                                }
                                                                                                Console.Write("Please enter the event type: ");
                                                                                                string eventTypeUpdate = Console.ReadLine();
                                                                                                while (eventTypeUpdate.Trim() == String.Empty)
                                                                                                {
                                                                                                    Console.Write("The new event type is required. Please enter the new event type: ");
                                                                                                    eventTypeUpdate = Console.ReadLine();
                                                                                                }
                                                                                                Console.Write("Please enter the event venue: ");
                                                                                                string eventVenueUpdate = Console.ReadLine();
                                                                                                while (eventVenueUpdate.Trim() == String.Empty)
                                                                                                {
                                                                                                    Console.Write("The new event venue is required. Please enter the new event venue: ");
                                                                                                    eventVenueUpdate = Console.ReadLine();
                                                                                                }
                                                                                                Console.Write("Please enter the event date and time: ");
                                                                                                string eventDateTimeUpdate = Console.ReadLine();
                                                                                                while (eventDateTimeUpdate.Trim() == String.Empty)
                                                                                                {
                                                                                                    Console.Write("The new event date and time are required. Please enter the event date and time: ");
                                                                                                    eventDateTimeUpdate = Console.ReadLine();
                                                                                                }
                                                                                                Console.Write("Please enter the event county: ");
                                                                                                string eventCountyUpdate = Console.ReadLine();
                                                                                                while (eventCountyUpdate.Trim() == String.Empty)
                                                                                                {
                                                                                                    Console.Write("The new event county is required. Please enter the new event county: ");
                                                                                                    eventCountyUpdate = Console.ReadLine();
                                                                                                }
                                                                                                Console.Write("Please enter the event ticket price: ");
                                                                                                do
                                                                                                {
                                                                                                    if (int.TryParse(Console.ReadLine(), out int TicketPriceUpdate))
                                                                                                    {
                                                                                                        bool successEventUpdate = bl.UpdateEvent(eventID, eventNameUpdate, eventTypeUpdate, eventVenueUpdate, eventDateTimeUpdate, eventCountyUpdate, TicketPriceUpdate); //Call the UpdateEvent method in the BusinessLogic
                                                                                                        if (successEventUpdate)
                                                                                                        {
                                                                                                            Console.WriteLine("\nEvent Update Successful\n");
                                                                                                            continueLooping9 = false;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            Console.WriteLine("\nFailed to update event. Event does not exist.\n");
                                                                                                        }
                                                                                                        break;

                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        Console.Write("The ticket price must be a number. Please enter the ticket price: ");
                                                                                                    }
                                                                                                } while (1 == 1);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.Write("The event ID must be a number. Please enter the Event ID: ");
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case 2:
                                                                                        //Delete event
                                                                                        Console.WriteLine("\n******************Delete Event************************\n");
                                                                                        Console.Write("Please enter the event ID: ");
                                                                                        int.TryParse(Console.ReadLine(), out int eventIDDeleteOptions);

                                                                                        bool successEventDeleteOptions = bl.DeleteEvent(eventIDDeleteOptions); //Call the DeleteEvent method in the BusinessLogic
                                                                                        if (successEventDeleteOptions)
                                                                                        {
                                                                                            Console.WriteLine("\nEvent Deleted Successfully");
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Console.WriteLine("\nFailed to delete event. Event does not exist.");
                                                                                        }
                                                                                        break;
                                                                                    case 3:
                                                                                        //Ask the user to choose an event 
                                                                                        Console.WriteLine("\n*****************Purchase Ticket***********************\n");
                                                                                        Console.Write("Please enter the event ID to purchase a ticket: ");
                                                                                        do
                                                                                        {
                                                                                            if (int.TryParse(Console.ReadLine(), out int eventID))
                                                                                            {

                                                                                                Console.Write("Please enter the quantity of tickets: ");
                                                                                                do
                                                                                                {
                                                                                                    if (int.TryParse(Console.ReadLine(), out int ticketQuantity))
                                                                                                    {

                                                                                                        //Ask the user enter to input their contact details
                                                                                                        Console.WriteLine("\n*****************Contact Information***********************\n");
                                                                                                        Console.Write("Please enter your first name: ");
                                                                                                        string firstName = Console.ReadLine();
                                                                                                        while (firstName.Trim() == String.Empty)
                                                                                                        {
                                                                                                            Console.Write("The first name is required. Please enter the first name: ");
                                                                                                            firstName = Console.ReadLine();
                                                                                                        }
                                                                                                        Console.Write("Please enter your last name: ");
                                                                                                        string lastName = Console.ReadLine();
                                                                                                        while (lastName.Trim() == String.Empty)
                                                                                                        {
                                                                                                            Console.Write("The last name is required. Please enter the last name: ");
                                                                                                            lastName = Console.ReadLine();
                                                                                                        }
                                                                                                        Console.Write("Please enter your email address: ");
                                                                                                        string email = Console.ReadLine();
                                                                                                        while (email.Trim() == String.Empty)
                                                                                                        {
                                                                                                            Console.Write("The email is required. Please enter the email: ");
                                                                                                            email = Console.ReadLine();
                                                                                                        }
                                                                                                        Console.Write("Please enter your phone number: ");
                                                                                                        do
                                                                                                        {
                                                                                                            if (int.TryParse(Console.ReadLine(), out int phoneNumber))
                                                                                                            {
                                                                                                               
                                                                                                                bool successPurchaseTicket = bl.InsertOrder(eventID, ticketQuantity, firstName, lastName, email, phoneNumber); //Call the Createrder method in BusinessLogic
                                                                                                                if (successPurchaseTicket)
                                                                                                                {
                                                                                                                    Console.WriteLine("\nTicket Successfully Purchased");
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    Console.WriteLine("\nPurchase ticket failed. Event does not exist.");
                                                                                                                }
                                                                                                                break;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                Console.Write("Must be a number. Please enter the phone number: ");
                                                                                                            }
                                                                                                        } while (1 == 1);
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        Console.Write("Must be a number. Please enter the ticket quantity: ");
                                                                                                    }
                                                                                                    break;
                                                                                                } while (1 == 1);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.Write("Must be a number.");
                                                                                            }
                                                                                            break;
                                                                                        } while (1 == 1);
                                                                                        break;
                                                                                    case 4:
                                                                                        //Return to main menu
                                                                                        continueLooping8 = false;
                                                                                        break;
                                                                                    case 5:
                                                                                        //Quit
                                                                                        Console.WriteLine("\nThank you for using the Events App. Goodbye.\n");
                                                                                        continueLooping1 = false;
                                                                                        continueLooping2 = false;
                                                                                        continueLooping3 = false;
                                                                                        continuelooping4 = false;
                                                                                        continueLooping5 = false;
                                                                                        continueLooping7 = false;
                                                                                        continueLooping7 = false;
                                                                                        continueLooping8 = false;
                                                                                        break;
                                                                                    default:
                                                                                        //Invalid option
                                                                                        Console.WriteLine("\nNot a valid option");
                                                                                        break;
                                                                                }
                                                                            }
                                                                            break;
                                                                        case 2:
                                                                            //Search for an event by county
                                                                            Console.WriteLine("\n*********************Event County***********************\n");
                                                                            Console.Write("Please enter the event county: ");
                                                                            string searchEventCounty = Console.ReadLine();
                                                                            while (searchEventCounty.Trim() == String.Empty)
                                                                            {
                                                                                Console.Write("The new event county is required. Please enter the new event county: ");
                                                                                searchEventCounty = Console.ReadLine();
                                                                            }
                                                                            List<Event> eventListCounty = bl.SearchEventCounty(searchEventCounty); //Call the SearchEventCounty method in the BusinessLogic
                                                                            Console.WriteLine("\n----------------------------------------------------");
                                                                            foreach (Event e in eventListCounty)
                                                                            {
                                                                                Console.WriteLine("Event ID: " + e.EventID);
                                                                                Console.WriteLine("Event Name: " + e.EventName);
                                                                                Console.WriteLine("Event Type: " + e.EventType);
                                                                                Console.WriteLine("Event Venue: " + e.EventVenue);
                                                                                Console.WriteLine("Event Date and Time: " + e.EventDateTime);
                                                                                Console.WriteLine("Event County: " + e.EventCounty);
                                                                                Console.WriteLine("Event Ticket Price: " + e.TicketPrice);
                                                                                Console.WriteLine("----------------------------------------------------");
                                                                            }

                                                                            bool continueLooping10 = true;

                                                                            while (continueLooping10)
                                                                            {
                                                                                Console.WriteLine("\n*******************Options***********************\n");
                                                                                Console.WriteLine("1. Update event");
                                                                                Console.WriteLine("2. Delete event");
                                                                                Console.WriteLine("3. Purchase event ticket");
                                                                                Console.WriteLine("4. Return to the Search Event Menu");
                                                                                Console.WriteLine("5. Quit\n");
                                                                                Console.Write("Please choose an option between 1-5: ");
                                                                                int.TryParse(Console.ReadLine(), out option);

                                                                                switch (option)
                                                                                {
                                                                                    case 1:
                                                                                        Console.WriteLine("\n******************Update Event************************\n");
                                                                                        Console.Write("Please enter the event ID: ");
                                                                                        bool continueLooping9 = true;

                                                                                        while (continueLooping9)
                                                                                        {
                                                                                            if (int.TryParse(Console.ReadLine(), out int eventID))
                                                                                            {
                                                                                                Console.Write("Please enter the event name: ");
                                                                                                string eventNameUpdate = Console.ReadLine();
                                                                                                while (eventNameUpdate.Trim() == String.Empty)
                                                                                                {
                                                                                                    Console.Write("The new event name is required. Please enter the event name: ");
                                                                                                    eventNameUpdate = Console.ReadLine();
                                                                                                }
                                                                                                Console.Write("Please enter the event type: ");
                                                                                                string eventTypeUpdate = Console.ReadLine();
                                                                                                while (eventTypeUpdate.Trim() == String.Empty)
                                                                                                {
                                                                                                    Console.Write("The new event type is required. Please enter the new event type: ");
                                                                                                    eventTypeUpdate = Console.ReadLine();
                                                                                                }
                                                                                                Console.Write("Please enter the event venue: ");
                                                                                                string eventVenueUpdate = Console.ReadLine();
                                                                                                while (eventVenueUpdate.Trim() == String.Empty)
                                                                                                {
                                                                                                    Console.Write("The new event venue is required. Please enter the new event venue: ");
                                                                                                    eventVenueUpdate = Console.ReadLine();
                                                                                                }
                                                                                                Console.Write("Please enter the event date and time: ");
                                                                                                string eventDateTimeUpdate = Console.ReadLine();
                                                                                                while (eventDateTimeUpdate.Trim() == String.Empty)
                                                                                                {
                                                                                                    Console.Write("The new event date and time are required. Please enter the event date and time: ");
                                                                                                    eventDateTimeUpdate = Console.ReadLine();
                                                                                                }
                                                                                                Console.Write("Please enter the event county: ");
                                                                                                string eventCountyUpdate = Console.ReadLine();
                                                                                                while (eventCountyUpdate.Trim() == String.Empty)
                                                                                                {
                                                                                                    Console.Write("The new event county is required. Please enter the new event county: ");
                                                                                                    eventCountyUpdate = Console.ReadLine();
                                                                                                }
                                                                                                Console.Write("Please enter the event ticket price: ");
                                                                                                do
                                                                                                {
                                                                                                    if (int.TryParse(Console.ReadLine(), out int TicketPriceUpdate))
                                                                                                    {
                                                                                                        bool successEventUpdate = bl.UpdateEvent(eventID, eventNameUpdate, eventTypeUpdate, eventVenueUpdate, eventDateTimeUpdate, eventCountyUpdate, TicketPriceUpdate); //Call the UpdateEvent method in the BusinessLogic
                                                                                                        if (successEventUpdate)
                                                                                                        {
                                                                                                            Console.WriteLine("\nEvent Update Successful\n");
                                                                                                            continueLooping9 = false;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            Console.WriteLine("\nFailed to update event. Event does not exist.\n");
                                                                                                        }
                                                                                                        break;

                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        Console.Write("The ticket price must be a number. Please enter the ticket price: ");
                                                                                                    }
                                                                                                } while (1 == 1);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.Write("The event ID must be a number. Please enter the Event ID: ");
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case 2:
                                                                                        //Delete event
                                                                                        Console.WriteLine("\n******************Delete Event************************\n");
                                                                                        Console.Write("Please enter the event ID: ");
                                                                                        int.TryParse(Console.ReadLine(), out int eventIDDeleteOptions);

                                                                                        bool successEventDeleteOptions = bl.DeleteEvent(eventIDDeleteOptions); //Call the DeleteEvent method in the BusinessLogic
                                                                                        if (successEventDeleteOptions)
                                                                                        {
                                                                                            Console.WriteLine("\nEvent Deleted Successfully");
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Console.WriteLine("\nFailed to delete event. Event does not exist.");
                                                                                        }
                                                                                        break;
                                                                                    case 3:
                                                                                        //Ask the user to choose an event 
                                                                                        Console.WriteLine("\n*****************Purchase Ticket***********************\n");
                                                                                        Console.Write("Please enter the event ID to purchase a ticket: ");
                                                                                        do
                                                                                        {
                                                                                            if (int.TryParse(Console.ReadLine(), out int eventID))
                                                                                            {

                                                                                                Console.Write("Please enter the quantity of tickets: ");
                                                                                                do
                                                                                                {
                                                                                                    if (int.TryParse(Console.ReadLine(), out int ticketQuantity))
                                                                                                    {

                                                                                                        //Ask the user enter to input their contact details
                                                                                                        Console.WriteLine("\n*****************Contact Information***********************\n");
                                                                                                        Console.Write("Please enter your first name: ");
                                                                                                        string firstName = Console.ReadLine();
                                                                                                        while (firstName.Trim() == String.Empty)
                                                                                                        {
                                                                                                            Console.Write("The first name is required. Please enter the first name: ");
                                                                                                            firstName = Console.ReadLine();
                                                                                                        }
                                                                                                        Console.Write("Please enter your last name: ");
                                                                                                        string lastName = Console.ReadLine();
                                                                                                        while (lastName.Trim() == String.Empty)
                                                                                                        {
                                                                                                            Console.Write("The last name is required. Please enter the last name: ");
                                                                                                            lastName = Console.ReadLine();
                                                                                                        }
                                                                                                        Console.Write("Please enter your email address: ");
                                                                                                        string email = Console.ReadLine();
                                                                                                        while (email.Trim() == String.Empty)
                                                                                                        {
                                                                                                            Console.Write("The email is required. Please enter the email: ");
                                                                                                            email = Console.ReadLine();
                                                                                                        }
                                                                                                        Console.Write("Please enter your phone number: ");
                                                                                                        do
                                                                                                        {
                                                                                                            if (int.TryParse(Console.ReadLine(), out int phoneNumber))
                                                                                                            {

                                                                                                                bool successPurchaseTicket = bl.InsertOrder(eventID, ticketQuantity, firstName, lastName, email, phoneNumber); //Call the Createrder method in BusinessLogic
                                                                                                                if (successPurchaseTicket)
                                                                                                                {
                                                                                                                    Console.WriteLine("\nTicket Successfully Purchased");
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    Console.WriteLine("\nPurchase ticket failed. Event does not exist.");
                                                                                                                }
                                                                                                                break;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                Console.Write("Must be a number. Please enter the phone number: ");
                                                                                                            }
                                                                                                        } while (1 == 1);
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        Console.Write("Must be a number. Please enter the ticket quantity: ");
                                                                                                    }
                                                                                                    break;
                                                                                                } while (1 == 1);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.Write("Must be a number.");
                                                                                            }
                                                                                            break;
                                                                                        } while (1 == 1);
                                                                                        break;
                                                                                    case 4:
                                                                                        //Return to main menu
                                                                                        continueLooping10 = false;
                                                                                        break;
                                                                                    case 5:
                                                                                        //Quit
                                                                                        Console.WriteLine("\nThank you for using the Events App. Goodbye.\n");
                                                                                        continueLooping1 = false;
                                                                                        continueLooping2 = false;
                                                                                        continueLooping3 = false;
                                                                                        continuelooping4 = false;
                                                                                        continueLooping5 = false;
                                                                                        continueLooping7 = false;
                                                                                        continueLooping10 = false;
                                                                                        break;
                                                                                    default:
                                                                                        //Invalid option
                                                                                        Console.WriteLine("\nNot a valid option");
                                                                                        break;
                                                                                }
                                                                            }
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case 5:
                                                                //Quit
                                                                Console.WriteLine("\nThank you for using the Events App. Goodbye.");
                                                                continueLooping1 = false;
                                                                continueLooping2 = false;
                                                                continueLooping3 = false;
                                                                continuelooping4 = false;
                                                                continueLooping5 = false;
                                                                break;
                                                            default:
                                                                //Invalid option 
                                                                Console.WriteLine("\nNot a valid option");
                                                                break;
                                                        }

                                                    }
                                            
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nLogin Unsuccessful");
                                                }
                                            }
                                            break;
                                        case 2:
                                            //Continue to ask the user to signup until successful
                                            bool continueLooping4 = true;
                                            while (continueLooping4)
                                            {
                                                //Ask the user to input their username and password to login
                                                Console.WriteLine("\n*********************Sign Up***************************\n");
                                                Console.Write("Please create a username: ");
                                                string usernameSignup = Console.ReadLine();
                                                while (usernameSignup.Trim() == String.Empty)
                                                {
                                                    Console.Write("A username is required. Please create a username: ");
                                                    usernameSignup = Console.ReadLine();
                                                }
                                                Console.Write("Please create a password: ");
                                                string passwordSignup = Console.ReadLine();
                                                while (passwordSignup.Trim() == String.Empty)
                                                {
                                                    Console.Write("A password is required. Please create a password: ");
                                                    passwordSignup = Console.ReadLine();
                                                }

                                                bool success = bl.UserSignup(usernameSignup, passwordSignup);
                                                if (success)
                                                {
                                                    //int option1 = MainMenu();
                                                    Console.WriteLine("\nSign Up Successful");

                                                    bool continueLooping6 = true;
                                                    while (continueLooping6)
                                                    {
                                                        Console.WriteLine("\n**********************Main Menu************************\n");
                                                        Console.WriteLine("1. Add an event");
                                                        Console.WriteLine("2. Update an event");
                                                        Console.WriteLine("3. Delete an event");
                                                        Console.WriteLine("4. See all events");
                                                        Console.WriteLine("5. Quit\n");

                                                        Console.Write("Please choose an option between 1-5: ");
                                                        int.TryParse(Console.ReadLine(), out option);

                                                        //Switch statement
                                                        switch (option)
                                                        {
                                                            case 1:
                                                                Console.WriteLine("\n********************Add Event************************\n");
                                                                Console.Write("Please enter the event name: ");
                                                                string eventName = Console.ReadLine();
                                                                Console.Write("Please enter the event type: ");
                                                                string eventType = Console.ReadLine();
                                                                Console.Write("Please enter the event venue: ");
                                                                string eventVenue = Console.ReadLine();
                                                                Console.Write("Please enter the event date and time: ");
                                                                string eventDateTime = Console.ReadLine();
                                                                Console.Write("Please enter the event county: ");
                                                                string eventCounty = Console.ReadLine();
                                                                Console.Write("Please enter the event ticket price: ");
                                                                int.TryParse(Console.ReadLine(), out int TicketPrice);

                                                                bool successEvent = bl.InsertEvent(eventName, eventType, eventVenue, eventDateTime, eventCounty, TicketPrice); //Call the InsertEvent method in the BusinessLogic
                                                                if (successEvent)
                                                                {
                                                                    Console.WriteLine("\nEvent Added Successfully\n");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("\nFailed to add event.\n");
                                                                }
                                                                break;
                                                            case 2:
                                                                Console.WriteLine("\n******************Update Event************************\n");
                                                                Console.Write("Please enter the event ID: ");
                                                                int.TryParse(Console.ReadLine(), out int eventID);
                                                                Console.Write("Please enter the event name: ");
                                                                string eventNameUpdate = Console.ReadLine();
                                                                Console.Write("Please enter the event type: ");
                                                                string eventTypeUpdate = Console.ReadLine();
                                                                Console.Write("Please enter the event venue: ");
                                                                string eventVenueUpdate = Console.ReadLine();
                                                                Console.Write("Please enter the event date and time: ");
                                                                string eventDateTimeUpdate = Console.ReadLine();
                                                                Console.Write("Please enter the event county: ");
                                                                string eventCountyUpdate = Console.ReadLine();
                                                                Console.Write("Please enter the event ticket price: ");
                                                                int.TryParse(Console.ReadLine(), out int ticketPriceUpdate);
                                                                bool successEventUpdate = bl.UpdateEvent(eventID, eventNameUpdate, eventTypeUpdate, eventVenueUpdate, eventDateTimeUpdate, eventCountyUpdate, ticketPriceUpdate); //Call the UpdateEvent method in the BusinessLogic
                                                                if (successEventUpdate)
                                                                {
                                                                    Console.WriteLine("\nEvent Update Successful\n");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("\nFailed to update event.\n");
                                                                }
                                                                break;
                                                            case 3:
                                                                Console.WriteLine("\n******************Delete Event************************\n");
                                                                Console.Write("Please enter the event ID: ");
                                                                int.TryParse(Console.ReadLine(), out int eventIDDelete);
                                                                bool successEventDelete = bl.DeleteEvent(eventIDDelete); //Call the DeleteEvent method in the BusinessLogic
                                                                if (successEventDelete)
                                                                {
                                                                    Console.WriteLine("\nEvent Delete Successful\n");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("\nFailed to delete event.\n");
                                                                }
                                                                break;
                                                            case 4:
                                                                Console.WriteLine("See all events");
                                                                break;
                                                            case 5:
                                                                Console.WriteLine("\nThank you for using the Events App. Goodbye.\n");
                                                                continueLooping1 = false;
                                                                continueLooping2 = false;
                                                                continueLooping3 = false;
                                                                continueLooping6 = false;
                                                                break;
                                                            default:
                                                                //Invalid option
                                                                Console.WriteLine("\nNot a valid option\n");
                                                                break;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nSign Up Unsuccessful\n");
                                                }
                                                break;
                                            }
                                            break;
                                        case 3:
                                            //Quit
                                            Console.WriteLine("\nThank you for using the Events App. Goodbye.\n");
                                            continueLooping1 = false;
                                            continueLooping2 = false;
                                            continueLooping3 = false;
                                            break;
                                        default:
                                            //Invalid option
                                            Console.WriteLine("\nNot a valid option.");
                                            break;
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        //Quit
                        Console.WriteLine("\nThank you for using the Events App. Goodbye.\n");
                        continueLooping1 = false;
                        break;
                    default:
                        //Invalid option
                        Console.WriteLine("\nNot a valid option.\n");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
