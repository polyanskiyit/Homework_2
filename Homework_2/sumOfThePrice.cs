using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class sumOfThePrice : OtherParameters
    {
        public void Price(String distanceString, String timeOfDay, Double price)
        {

            //bool result = Double.TryParse(distanceString, out distance);

            if (Double.TryParse(distanceString, out distance))
            {
                distance = Convert.ToDouble(distanceString);
                if (timeOfDay == "day")
                {
                    if(distance > 0)
                    {
                        if (distance <= 10)
                        {
                            Console.WriteLine("\nPrice: " + (price + (5 * distance)) + " usd");
                        }
                        else if (distance <= 20)
                        {
                            Console.WriteLine("\nPrice: " + (price + (4 * distance)) + " usd");
                        }
                        else if (distance > 20)
                        {
                            Console.WriteLine("\nPrice: " + (price + (3 * distance)) + " usd");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPrice: " + 0 + " usd");
                    }
                }
                else if (timeOfDay == "night")
                {
                    if(distance > 0)
                    {
                        if (distance <= 10)
                        {
                            Console.WriteLine("\nPrice: " + ((price + (5 * distance))) / 2 + " usd");
                        }
                        else if (distance <= 20)
                        {
                            Console.WriteLine("\nPrice: " + ((price + (4 * distance))) / 2 + " usd");
                        }
                        else if (distance > 20)
                        {
                            Console.WriteLine("\nPrice: " + ((price + (3 * distance))) / 2 + " usd");
                        }
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
            else
            {
                Console.WriteLine("\nError in the input parameter 'distance'");
            }

        }
    }
}
