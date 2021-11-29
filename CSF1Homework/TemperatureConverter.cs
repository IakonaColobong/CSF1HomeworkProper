using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TemperatureConverter
    {
        static void Main(string[] args)
        {
            double fht;
            double celsius;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "TEMPERATURE CONVERTER"));
            Console.WriteLine();
            bool repeat = true;

            do
            {



                Console.WriteLine("Select a letter from the following menu by:");
                Console.WriteLine(@"
    F) Convert from Celcius to Farenheit
    C) Convert from Farenheit to Celsius
    ");
                String userChoice = Console.ReadLine().ToLower();
                Console.Clear();

                switch (userChoice)
                {
                    case "f":
                        Console.Write("Enter a Celsius tempterature to be converted into Farenheit: ");
                        int cTemp = Convert.ToInt32(Console.ReadLine());
                        fht = cTemp * (9.0 / 5.0) + 32;
                        Console.WriteLine(fht);
                        Console.WriteLine();
                        break;
                    case "c":
                        Console.Write("Enter a Farenheit tempterature to be converted into Celsius: ");
                        int fTemp = Convert.ToInt32(Console.ReadLine());
                        celsius = (fTemp - 32) / (9.0 / 5.0);
                        Console.WriteLine($"The temp in Farenheit is {celsius}.");
                        Console.WriteLine();
                        break;
                    /* case "x":
                   case "exit":
                        Console.WriteLine("Thank you for using this application");
                        //update
                        repeat = false; // UPDATE
                        break;
                        
*/


                    default:
                        Console.WriteLine("That was not a valid option\n" +
                            "select again");
                        break;

                }//end SWITCH
                Console.WriteLine("Do you have another entry to perform? Y/N");

            } while (Console.ReadLine().ToUpper() == "Y");




        }//end MAIN()
    }//end CLASS
}//end NAMESPACE
