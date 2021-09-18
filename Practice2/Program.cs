using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an instance of the LoginHandler Class
            BusinessLayer.DBHandler h;

            //Create an instance of the Event Class
            BusinessLayer.Event e;

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
                        h = new BusinessLayer.DBHandler(passwordConnect);

                        bool successConnect = h.Connect(usernameConnect, passwordConnect);
                        if (successConnect)
                        {
                            //Main Menu - Ask the user to login, sign up or quit
                            Console.WriteLine("\n*********************Main Menu*************************\n");
                            Console.WriteLine("1. Login");
                            Console.WriteLine("2. Sign Up");
                            Console.Write("\nPlease choose option 1 or 2: ");
                            int.TryParse(Console.ReadLine(), out int option);

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

                                        bool success = h.Login(usernameLogin, passwordLogin);
                                        if (success)
                                        {
                                            continuelooping = false;
                                            Console.WriteLine("\nLogin Successful\n");

                                            do
                                            {
                                                Console.WriteLine("*********************Main Menu************************\n");
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
                                                    //Add an event
                                                    case 1:
                                                        Console.WriteLine("\n********************Add Event************************\n");
                                                        Console.Write("Please enter the event ID: ");
                                                        string eventID = Console.ReadLine();
                                                        Console.Write("Please enter the event name: ");
                                                        string eventName = Console.ReadLine();
                                                        bool successEvent = h.AddEvent(eventID, eventName);
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
                                                        string eventIDUpdate = Console.ReadLine();
                                                        Console.Write("Please enter the new event name: ");
                                                        string eventNameUpdate = Console.ReadLine();
                                                        bool successEventUpdate = h.UpdateEvent(eventIDUpdate, eventNameUpdate);
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
                                                        string eventIDDelete = Console.ReadLine();
                                                        bool successEventDelete = h.DeleteEvent(eventIDDelete);
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

                                        bool success = h.Signup(usernameSignup, passwordSignup);
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
                                                    Console.WriteLine("Add an event");
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Update an event");
                                                    break;
                                                case 3:
                                                    Console.WriteLine("Delete an event");
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
                    Console.WriteLine("Thank you for using the Events App. Goodbye.");
                    break;
                default:
                    Console.WriteLine("Not a valid option. Please choose an option between 1-2");
                    break;
            }
            Console.ReadLine();


        }
    }
}
