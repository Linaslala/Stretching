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

            var exercise1 = new Exercise("Shoulder Extension", 
                "Place your hands on an overhead surface or wall and keep your arms straight.\n" +
                "Attempt to push your head and chest forward through your shoulders,\n" +
                "so that your arms press together behind your body.", 
                10, 30);

            exerciseList.AddExercise(exercise1);

            var exercise2 = new Exercise("Rear Hand Clasp", 
                "With one hand overhead and the other behind your back,\n" +
                "attempt to clasp the fingertips of each hand together.", 
                10, 30);

            exerciseList.AddExercise(exercise2);

            var exercise3 = new Exercise("Standing Pike", 
                "Bend forward, hinging at the hips while trying to keep your back flat.\n" +
                "Instead of trying to touch your toes,\n" +
                "try to touch the ground 1-2 feet in front of your toes.", 10, 30);

            exerciseList.AddExercise(exercise3);

            var exercise4 = new Exercise("Kneeling Lounge",
                "Kneel on the ground and Place one foot infront of you, flat on the ground. " +
                "Keep your back knee and toes on the ground.\n" +
                "Squeeze your glutus and move your pelvis forward, stretching the rear leg. " +
                "Keep your front shin and torso aligned.", 
                10, 30);

            exerciseList.AddExercise(exercise4);

            var exercise5 = new Exercise("Full Squat",
                "Squat down as far as you can, keeping your heels on the ground.\n" +
                "Keep your arms inside your knees and press them outward.", 
                10, 30);

            exerciseList.AddExercise(exercise5);

            var exercise6 = new Exercise("Butterfly",
                "Sit on the ground and bring the bottoms of your feet together infront of you.\n" +
                "Hold your feet together with your hands\n" +
                "and pull them slightly towards you.\n" +
                "Actively try to press your knees to the ground.", 
                10, 30);

            exerciseList.AddExercise(exercise6);

            var exercise7 = new Exercise("Lying Twist", 
                "Lie on the ground, facing upward,\n" +
                "and extend your arms out to the\n" +
                "sides. Lift one leg up vertical from\n" +
                "the ground, keeping it straight.\n" +
                "Lower this leg to the ground\n" +
                "on the opposite side of your" +
                "\ntorso while keeping your shoulders", 
                10, 30);

            exerciseList.AddExercise(exercise7);

            var exercise8 = new Exercise("Backbend", 
                "While lying on your back, bend\n" +
                "your knees and put your feet\n" +
                "near your butt. By squeezing your\n" +
                "glutes, lift your hips and pelvis off\n" +
                "the floor, and press them towards\n" +
                "the ceiling", 
                10, 30);

            exerciseList.AddExercise(exercise8);

            var exercise9 = new Exercise("Underarm - Shoulder", 
                "Sit on the ground and place your\n" +
                "hands behind you, fingers pointing\n" +
                "away. Slide your butt forward while\n" +
                "keeping your arms straight.", 
                10, 30);

            exerciseList.AddExercise(exercise9);

            return exerciseList.ListOfExercises;
        }
    }
}
