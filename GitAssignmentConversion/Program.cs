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

            System.Console.WriteLine("This is a program that calculates conversions in terms of-\nWeight: Kilograms & Pounds\nLength: Centimeters & Inches\n\n" +
                "Press any key to continue.\n");
            Console.ReadKey();
            Console.Clear();
            double Num;
            double Kilograms;
            double Pounds;
            double Centimeters;
            double Inches;
            double Conversion;

            /* Request user input for which conversion they would prefer */

            System.Console.WriteLine("Please enter the number associated with the conversion you would like to do.\n\nWeight:\n1.Kilograms to Pounds\n2.Pounds" +
                " to Kilograms\n\n" +
                "Length:\n3.Centimeters to Inches\n4.Inches to Centimeters\n");

            /* Get number */

            Num = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            if (Num == 1)
            {
                /* Kilogram # * 2.205 = Pound # */
                Console.WriteLine("Kilograms to Pounds\nPlease enter the number of Kilograms\n");
                Kilograms = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                /* Perform conversion calculation */
                Conversion = Kilograms * 2.205;
                Console.WriteLine(Kilograms + " Kilograms converts to " + Conversion + " Pounds");
            }
            if (Num == 2)
            {
                /* Pound # / 2.205 = Kilogram # */
                Console.WriteLine("Pounds to Kilograms\nPlease enter the number of Pounds\n");
                Pounds = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                /* Perform conversion calculation */
                Conversion = Pounds / 2.205;
                Console.WriteLine(Pounds + " Pounds converts to " + Conversion + " Kilograms");
            }
            if (Num == 3)
            {
                /* Centimeter # / 2.54 = Inch # */
                Console.WriteLine("Centimeters to Inches\nPlease enter the number of Centimeters\n");
                Centimeters = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                /* Perform conversion calculation */
                Conversion = Centimeters / 2.54;
                Console.WriteLine(Centimeters + " Centimeters converts to " + Conversion + " Inches");
            }
            if (Num == 4)
            {
                /* Inch # * 2.54 = Centimeter # */
                Console.WriteLine("Inches to Centimeters\nPlease enter the number of Inches\n");
                Inches = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                /* Perform conversion calculation */
                Conversion = Inches * 2.54;
                Console.WriteLine(Inches + " Inches converts to " + Conversion + " Centimeters");
            }
                Console.ReadLine();
        }
    }
}
