using System;
using System.Collections.Generic;
using System.Text;

namespace Stretching
{
    public class Counter
    {
        public static void CountDown(Exercise exercise)
        {
            Console.WriteLine($"Nästa övning {exercise.Name}");

            for (int t = 10; t > 0; t--)
            {
                Console.WriteLine($"Förberedelse: {t} sekunder");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Nu kör vi!");

            for (int i = 30; i > 0; i--)
            {
                Console.WriteLine($"Tid kvar: {i} sekunder");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Tiden är ute!");

        }
    }
}


