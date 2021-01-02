using System;
using System.Globalization;

namespace WeekTwoHomeworkConversions
{
    class Program
    {
        static void Main(string[] args)
        {



            //convert double number to currency format
            double numba = 66666.55;
            string s = numba.ToString("C0");
             Console.WriteLine(s);

            //convert double number to currency format
            double value = 12345.6789;
            Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));

            //convert double number to currency format
             double num1 = 1234444;
             Console.WriteLine(num1.ToString("C2"));

            
            Console.WriteLine("What is the temperature in Fahrenheit degrees: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            double celcius = (temp - 32) * 5 / 9;
            Console.WriteLine("The temperature in celsius is" + " " + celcius);


            Console.WriteLine("What is the length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            double meters = length * 0.3048;
            Console.WriteLine("The length in meters is: " + " " + meters);



            Console.WriteLine("What is the volume in gallons: ");
            double gallons = Convert.ToDouble(Console.ReadLine());
            double liters = gallons * 3.785412;
            Console.WriteLine("The gallons in meters is: " + " " + liters);


            Console.WriteLine("What is the weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kilo = pounds * 0.45359237;
            Console.WriteLine("The number of kilograms is: " + " " + kilo);
                         




            Console.ReadLine();





        }
    }
}



