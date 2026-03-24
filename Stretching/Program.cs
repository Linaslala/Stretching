using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Stretching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exerciseList = new ExerciseList();

            var exercise1 = new Exercise("Shoulder Extension", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise1);

            var exercise2 = new Exercise("Rear Hand Clasp", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise2);

            var exercise3 = new Exercise("Standing Pike", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise3);

            Counter.CountDown(exercise1);
        }
    }
}
