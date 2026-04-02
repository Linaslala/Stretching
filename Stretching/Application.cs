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

            Counter.CountDown(exerciseList);

            Console.WriteLine("Nu är du mjuk och go!");
            Console.ReadKey();
        }
    }
}
