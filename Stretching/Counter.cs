using System;
using System.Collections.Generic;
using System.Text;

namespace Stretching
{
    public class Counter
    {
        public static void CountDown(List<Exercise> list)
        {
            foreach (var exercise in list)
            {

                for (int t = exercise.PreparationTime; t > 0; t--)
                {
                    Console.WriteLine($"Nästa övning: \u001b[1m{exercise.Name.ToUpper()}\u001b[0m\n");
                    Console.WriteLine($"{exercise.Instruction}\n");
                    Console.WriteLine($"Förberedelse: {t} sekunder");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                for (int i = exercise.ExerciseTime; i > 0; i--)
                {
                    Console.WriteLine($"\u001b[1m{exercise.Name.ToUpper()}\u001b[0m\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nu kör vi!\n");
                    Console.ResetColor();
                    Console.WriteLine($"Tid kvar: {i} sekunder");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tiden är ute!");
                Console.ResetColor();
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}


