using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Stretching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exerciseList = ExerciseData.Create();

            Counter.CountDown(exerciseList);
        }
    }
}
