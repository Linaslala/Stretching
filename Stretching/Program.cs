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

            var exercise4 = new Exercise("Kneeling Lounge", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise4);

            var exercise5 = new Exercise("Full Squat", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise5);

            var exercise6 = new Exercise("Butterfly", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise6);

            var exercise7 = new Exercise("Lying Twist", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise7);

            var exercise8 = new Exercise("Backbend", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise8);

            var exercise9 = new Exercise("Underarm - Shoulder", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise9);

            Counter.CountDown(exercise1);
        }
    }
}
