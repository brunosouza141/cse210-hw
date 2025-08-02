using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> counter = new List<int>([0,0,0]);
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
                counter[int.Parse(option) - 1] += 1;
                continue;
            }
            else if (option == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                counter[int.Parse(option) - 1] += 1;
                continue;
            }
            else if (option == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                counter[int.Parse(option) - 1] += 1;
                continue;
            }
            else if (option == "4")
            {
                Console.WriteLine("If you want to save the logs on a external file, please type the file name. Press enter to exit.");
                string response = Console.ReadLine();
                if (string.IsNullOrEmpty(response))
                {
                    break;
                }
                else
                {
                    using (StreamWriter outputFile = new StreamWriter(response))
                    {
                        outputFile.WriteLine($"Breathing Activity,Reflection Activity,Listing Activity");

                            outputFile.WriteLine($"{counter[0]},{counter[1]},{counter[2]}");
                    }
                }
            }
        } while (option != "4");
    }
}