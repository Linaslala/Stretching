using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Stretching
{
    public static class ExerciseData
    {
        public static List<Exercise> Create()
        {
            var exerciseList = new ExerciseList();

            var exercise1 = new Exercise("Shoulder Extension", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise1);

            var exercise2 = new Exercise("Rear Hand Clasp", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise2);

            var exercise3 = new Exercise("Standing Pike", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise3);

            var exercise4 = new Exercise("Kneeling Lounge",
                "Kneel on the ground and Place one foot infront of you, flat on the ground. " +
                "Keep your back knee and toes on the ground.\r\n" +
                "Squeeze your glutus and move your pelvis forward, stretching the rear leg. " +
                "Keep your front shin and torso aligned.", 
                10, 30);

            exerciseList.AddExercise(exercise4);

            var exercise5 = new Exercise("Full Squat",
                "Squat down as far as you can, keeping your heels on the ground.\r\n " +
                "Keep your arms inside your knees and press them outward.", 
                10, 30);

            exerciseList.AddExercise(exercise5);

            var exercise6 = new Exercise("Butterfly", 
                "Sit on the ground and bring the bottoms of your feet together infront of you. Hold your feet together with your hands and\r\n" +
                "and pull them slightly towards you. Actively try to press your knees to the ground.", 
                10, 30);

            exerciseList.AddExercise(exercise6);

            var exercise7 = new Exercise("Lying Twist", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise7);

            var exercise8 = new Exercise("Backbend", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise8);

            var exercise9 = new Exercise("Underarm - Shoulder", "Lägg in instruktion", 10, 30);

            exerciseList.AddExercise(exercise9);

            return exerciseList.ListOfExercises;
        }
    }
}
