using System;
using System.Collections.Generic;
using System.Text;


namespace Stretching
{
    public class Application
    {
        public void Run()
        {
            var exerciseList = ExerciseData.Create();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Dags att börja stretcha!\n");
                Console.WriteLine("1. Börja stretchning");
                Console.WriteLine("2. Läs stretchning instruktioner");
                Console.WriteLine("0. Avsluta");

                if (Int32.TryParse(Console.ReadLine(), out var input))
                {
                    switch (input)
                    {
                        case 1:
                            Console.Clear();

                            Counter.CountDown(exerciseList);
                            break;

                        case 2:
                            Console.Clear();

                            for (int i = 0; i < exerciseList.Count; i++)
                            {
                                Console.WriteLine($"Övning {i + 1}. {exerciseList[i].Name}");
                            }
                            Console.Write($"\nVälj vilken övning du vill se instruktioner för: ");

                            if (Int32.TryParse(Console.ReadLine(), out var exerciseChoice))
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{exerciseList[exerciseChoice - 1].Name}");
                                Console.WriteLine($"\n{exerciseList[exerciseChoice - 1].Instruction}");
                            }

                            Console.WriteLine("\nTryck valfri knapp för att komam tillbaka till menyn!");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                }

            }


            Console.WriteLine("Nu är du mjuk och go!");
            Console.ReadKey();
        }
    }
}
