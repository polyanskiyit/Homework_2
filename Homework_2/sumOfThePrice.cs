using System;

namespace Homework_2
{
    class sumOfThePrice
    {
        double distance;

        public void price(String distanceString, String timeOfDay, Double price)
        {
            if (Double.TryParse(distanceString, out distance))
            {
                distance = Convert.ToDouble(distanceString);

                if (timeOfDay == "day" && distance > 0 && distance <= 10)
                {
                    Console.WriteLine("\nPrice: " + (price + (5 * distance)) + " usd");
                }
                else if (timeOfDay == "day" && distance > 0 && distance <= 20)
                {
                    Console.WriteLine("\nPrice: " + (price + (4 * distance)) + " usd");
                }
                else if (timeOfDay == "day" && distance > 0 && distance > 20)
                {
                    Console.WriteLine("\nPrice: " + (price + (3 * distance)) + " usd");
                }


                else if (timeOfDay == "night" && distance > 0 && distance <= 10)
                {
                    Console.WriteLine("\nPrice: " + ((price + (5 * distance))) / 2 + " usd");
                }
                else if (timeOfDay == "night" && distance > 0 && distance <= 20)
                {
                    Console.WriteLine("\nPrice: " + ((price + (4 * distance))) / 2 + " usd");
                }
                else if (timeOfDay == "night" && distance > 0 && distance > 20)
                {
                    Console.WriteLine("\nPrice: " + ((price + (3 * distance))) / 2 + " usd");
                }
                else
                {
                    Console.WriteLine("\nPrice: " + 0 + " usd");
                }
            }
            else
            {
                Console.WriteLine("\nError in the input parameter 'timeOfDay'");
            }

        }
    }
}