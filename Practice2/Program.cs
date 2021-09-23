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

            //Main Menu - Ask the user to login or sign up
            Console.WriteLine("********************Events App*************************\n");
            Console.WriteLine("1. Connect");
            Console.WriteLine("2. Quit\n");
            Console.Write("Please choose option 1 or 2: ");
            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                //Login
                case 1:
                    //Login
                    bool keeplooping = true;
                    //Continue to ask the user to connect until successful
                    while (keeplooping)
                    {
                        //Ask the user to input their usernme and password to connect
                        Console.WriteLine("\n**********************Connect**************************\n");
                        Console.Write("Please enter your username: ");
                        string usernameConnect = Console.ReadLine();
                        Console.Write("Please enter your password: ");
                        string passwordConnect = Console.ReadLine();
                        bl = new Business.BusinessLogic(passwordConnect);
                        bool successConnect = bl.UserConnect(usernameConnect, passwordConnect); //Call the UserConnect method in the BusinessLogic
                        if (successConnect)
                        {
                            //Main Menu - Ask the user to login, sign up or quit
                            Console.WriteLine("\n********************Login*************************\n");
                            Console.WriteLine("1. Login");
                            Console.WriteLine("2. Sign Up");
                            Console.Write("\nPlease choose option 1 or 2: ");
                            int.TryParse(Console.ReadLine(), out int option);

                            //Switch statement
                            switch (option)
                            {
                                case 1:
                                    //Continue to ask the user to login until successful
                                    bool continuelooping = true;
                                    while (continuelooping)
                                    {
                                        //Ask the user to input their username and password to login
                                        Console.WriteLine("\n***********************Login***************************\n");
                                        Console.Write("Please enter your username: ");
                                        string usernameLogin = Console.ReadLine();
                                        Console.Write("Please enter your password: ");
                                        string passwordLogin = Console.ReadLine();
                                        bool success = bl.UserLogin(usernameLogin, passwordLogin); //Call the UserLogin method in the BusinessLogic
                                        if (success)
                                        {
                                            continuelooping = false;
                                            Console.WriteLine("\nLogin Successful\n");

                                            do
                                            {
                                                Console.WriteLine("*********************Main Menu************************\n");
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
                                                        int.TryParse(Console.ReadLine(), out int TicketPriceUpdate);
                                                        bool successEventUpdate = bl.UpdateEvent(eventID, eventNameUpdate, eventTypeUpdate, eventVenueUpdate, eventDateTimeUpdate, eventCountyUpdate, TicketPriceUpdate); //Call the UpdateEvent method in the BusinessLogic
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
                                                            Console.WriteLine("\nEvent Deleted Successfully\n");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("\nFailed to delete event.\n");
                                                        }
                                                        break;
                                                    case 4:
                                                        //Search event
                                                        Console.WriteLine("\n*******************Search Event***********************\n");
                                                        Console.WriteLine("1. Search all events");
                                                        Console.WriteLine("2. Search for an event by county");
                                                        Console.WriteLine("3. Return to Main Menu\n");
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

                                                                Console.WriteLine("\n*******************Options***********************\n");
                                                                Console.WriteLine("1. Update event");
                                                                Console.WriteLine("2. Delete event");
                                                                Console.WriteLine("3. Purchase event ticket");
                                                                Console.WriteLine("4. Return to Main Menu\n");
                                                                Console.Write("Please choose an option between 1-4: ");
                                                                int.TryParse(Console.ReadLine(), out option);

                                                                switch (option)
                                                                {
                                                                    case 1:
                                                                        break;
                                                                    case 2:
                                                                        break;
                                                                    case 3:
                                                                        //Ask the user to choose an event 
                                                                        Console.Write("\nPlease enter the event ID to purchase a ticket: ");
                                                                        int.TryParse(Console.ReadLine(), out int EventID);
                                                                        Console.Write("Please enter the quantity of tickets: ");
                                                                        int.TryParse(Console.ReadLine(), out int ticketQuantity);

                                                                        //Ask the user enter to input their contact details
                                                                        Console.WriteLine("\n*****************Contact Information***********************\n");
                                                                        Console.Write("Please enter your first name: ");
                                                                        string firstName = Console.ReadLine();
                                                                        Console.Write("Please enter your last name: ");
                                                                        string lastName = Console.ReadLine();
                                                                        Console.Write("Please enter your email address: ");
                                                                        string email = Console.ReadLine();
                                                                        Console.Write("Please enter your phone number: ");
                                                                        int.TryParse(Console.ReadLine(), out int phoneNumber);
                                                                        bl.InsertOrder(EventID, ticketQuantity, firstName, lastName, email, phoneNumber); //Call the Createrder method in BusinessLogic
                                                                        break;
                                                                    case 4:
                                                                        break;
                                                                    default:
                                                                        break; 
                                                                }
                                                                break;
                                                            case 2:
                                                                //Search for an event by county
                                                                Console.WriteLine("\n*********************Event County***********************\n");
                                                                Console.Write("Please enter the event county: ");
                                                                string searchEventCounty = Console.ReadLine();
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

                                                                Console.WriteLine("\n*******************Options***********************\n");
                                                                Console.WriteLine("1. Update event");
                                                                Console.WriteLine("2. Delete event");
                                                                Console.WriteLine("3. Purchase event ticket");
                                                                Console.WriteLine("4. Return to Main Menu\n");
                                                                Console.Write("Please choose an option between 1-4: ");
                                                                int.TryParse(Console.ReadLine(), out option);

                                                                switch (option)
                                                                {
                                                                    case 1:
                                                                        break;
                                                                    case 2:
                                                                        break;
                                                                    case 3:
                                                                        //Ask the user to choose an event 
                                                                        Console.Write("\nPlease enter the event ID to purchase a ticket: ");
                                                                        int.TryParse(Console.ReadLine(), out int EventID);
                                                                        Console.Write("Please enter the quantity of tickets: ");
                                                                        int.TryParse(Console.ReadLine(), out int ticketQuantity);

                                                                        //Ask the user enter to input their contact details
                                                                        Console.WriteLine("\n*****************Contact Information***********************\n");
                                                                        Console.Write("Please enter your first name: ");
                                                                        string firstName = Console.ReadLine();
                                                                        Console.Write("Please enter your last name: ");
                                                                        string lastName = Console.ReadLine();
                                                                        Console.Write("Please enter your email address: ");
                                                                        string email = Console.ReadLine();
                                                                        Console.Write("Please enter your phone number: ");
                                                                        int.TryParse(Console.ReadLine(), out int phoneNumber);
                                                                        bl.InsertOrder(EventID, ticketQuantity, firstName, lastName, email, phoneNumber); //Call the Createrder method in BusinessLogic
                                                                        break;
                                                                    case 4:
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                                break;
                                                                break;
                                                            case 3:
                                                                //Return to main menu
                                                                break;
                                                            default:
                                                                Console.WriteLine("Not a valid option. Please choose an option between 1-3.");
                                                                break;

                                                        } //Do while
                                                        break;
                                                    case 5:
                                                        //Quit
                                                        Console.WriteLine("\nThank you for using the Events App. Goodbye.");
                                                        break;
                                                    default:
                                                        Console.WriteLine("Not a valid option. Please choose an option between 1-5.");
                                                        break;
                                                }
                                            } while (1 == 1);
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nLogin Unsuccessful\n");
                                        }
                                    }
                                    break;
                                case 2:
                                    //Continue to ask the user to signup until successful
                                    bool keepgoing = true;
                                    while (keepgoing)
                                    {
                                        //Ask the user to input their username and password to login
                                        Console.WriteLine("\n*********************Sign Up***************************\n");
                                        Console.Write("Please create a username: ");
                                        string usernameSignup = Console.ReadLine();
                                        Console.Write("Please create a password: ");
                                        string passwordSignup = Console.ReadLine();

                                        bool success = bl.UserSignup(usernameSignup, passwordSignup);
                                        if (success)
                                        {
                                            Console.WriteLine("\nSign Up Successful\n");
                                            Console.WriteLine("**********************Main Menu************************\n");
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
                                                    Console.WriteLine("Quit");
                                                    break;
                                                default:
                                                    Console.WriteLine("Not a valid option. Please choose an option between 1-5.");
                                                    break;
                                            }


                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nSign Up Unsuccessful\n");
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Not a valid option. Please choose an option between 1-2");
                                    break;
                            }
                            break;
                        }
                    }
                    break;
                case 2:
                    //Quit
                    Console.WriteLine("\nThank you for using the Events App. Goodbye.");
                    break;
                    //Default
                default:
                    Console.WriteLine("Not a valid option. Please choose an option between 1-2");
                    break;
            }
            Console.ReadLine();


        }

    }
}
