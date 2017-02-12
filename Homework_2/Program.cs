using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 30;

            Console.WriteLine("Input the distance:");
            String distanceString = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Time of day (day/night):");
            String timeOfDay = Convert.ToString(Console.ReadLine());

            sumOfThePrice SumOfThePrice = new sumOfThePrice();
            SumOfThePrice.Price(distanceString, timeOfDay, price);
            
            Console.Read();

        }
    }
}
