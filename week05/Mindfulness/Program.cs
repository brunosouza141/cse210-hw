using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string option;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            if (option == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                continue;
            }
            else if (option == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                continue;
            }
            else if (option == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                continue;
            }
            else if (option == "4")
            {
                break;
            }
        } while (option != "4");
    }
}