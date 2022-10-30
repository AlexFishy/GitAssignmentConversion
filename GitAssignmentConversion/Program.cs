using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAssignmentConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Program that converts Kilograms <-> Pounds & Centimeter <-> Inches */
            //NR: /n is platform specific, use the build in newline to ensure it works on all platforms
            System.Console.WriteLine($"This is a program that calculates conversions in terms of-{System.Environment.NewLine}Weight: Kilograms & Pounds{System.Environment.NewLine}Length: Centimeters & Inches");
            Console.WriteLine($"Tempurature: Celsius & Fahrenheit");
            Console.WriteLine($"{System.Environment.NewLine}Press any key to continue.{System.Environment.NewLine}");
            Console.ReadKey();
            Console.Clear();
            double Num;
            double Kilograms;
            double Pounds;
            double Centimeters;
            double Inches;
            double Conversion;

            //could refactor above to just have Input and Conversion since all are doubles and not used at the same time
            double Input;

            /* Request user input for which conversion they would prefer */

            System.Console.WriteLine($"Please enter the number associated with the conversion you would like to do.{System.Environment.NewLine}{System.Environment.NewLine}Weight:{System.Environment.NewLine}1.Kilograms to Pounds{System.Environment.NewLine}2.Pounds to Kilograms{System.Environment.NewLine}{System.Environment.NewLine}Length:{System.Environment.NewLine}3.Centimeters to Inches{System.Environment.NewLine}4.Inches to Centimeters{System.Environment.NewLine}");
            Console.WriteLine("5. Celsius to Fahrenheit");
            Console.WriteLine("6. Fahrenheit to Celsius");


            /* Get number */

            Num = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

			//switch statement better than chained if statements
			switch (Num)
			{
                case 1: /* Kilogram # * 2.205 = Pound # */
                    printPrompt("Kilograms", "Pounds");
                    Kilograms = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    /* Perform conversion calculation */
                    Conversion = Kilograms * 2.205;
                    Console.WriteLine(Kilograms + " Kilograms converts to " + Conversion + " Pounds");
                    break;
                case 2: /* Pound # / 2.205 = Kilogram # */
                    printPrompt("Pounds", "Kilograms");
                    Pounds = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    /* Perform conversion calculation */
                    Conversion = Pounds / 2.205;
                    Console.WriteLine(Pounds + " Pounds converts to " + Conversion + " Kilograms");
                    break;
                case 3: /* Centimeter # / 2.54 = Inch # */
                    printPrompt("Centimeters", "Inches");
                    Centimeters = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    /* Perform conversion calculation */
                    Conversion = Centimeters / 2.54;
                    Console.WriteLine(Centimeters + " Centimeters converts to " + Conversion + " Inches");
                    break;
                case 4:
                    printPrompt("Inches", "Centimeters");
                    Inches = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    /* Perform conversion calculation */
                    Conversion = Inches * 2.54;
                    Console.WriteLine(Inches + " Inches converts to " + Conversion + " Centimeters");
                    break;
                case 5:
                    printPrompt("Celcius", "Farenheit");
                    Input = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("{0:F2}° Celcius converts to {1:F2}° Farenheit", Input, ((Input * ((double)9 / (double)5)) + 32));
                    break;
                case 6:
                    printPrompt("Farenheit", "Celcius");
                    Input = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("{0}° Farenheit converts to {1:F2}° Celcius", Input, ((Input - 32) * ((double)5 / (double)9)));
                    break;
                default:
                    Console.WriteLine("You did not enter a valid option");
                    break;
            }
            Console.ReadLine();
        }
        private static void printPrompt(string from, string to)
        {
            Console.WriteLine($"{from} to {to}");
            Console.WriteLine($"Please enter the number of {from}");
        }
    }

}
