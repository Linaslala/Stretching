using System;
using System.Collections.Generic;
using System.Text;

namespace Stretching
{
    public class Exercise
    {
        public string Name { get; set; }
        public string Instruction { get; set; }
        public int PreparationTime { get; set; }
        public int ExerciseTime { get; set; }

        public Exercise(string name, string instruction, int preparationTime, int exerciseTime)
        {
            Name = name;
            Instruction = instruction;
            PreparationTime = preparationTime;
            ExerciseTime = exerciseTime;
        }
    }
}
