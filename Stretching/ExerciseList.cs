using System;
using System.Collections.Generic;
using System.Text;

namespace Stretching
{
    public class ExerciseList
    {
        public List<Exercise> ListOfExercises { get; set; } = new List<Exercise>();

        public void AddExercise(Exercise exercise)
        {
            ListOfExercises.Add(exercise);

        }
    }
}
