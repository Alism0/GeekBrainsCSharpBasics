using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics
{
    public abstract class ExerciseStarter
    {
        protected abstract Dictionary<Exercises, Action> Exercises { get; }

        public void RunExercises()
        {
            Console.WriteLine("Выберите задание: ");
            foreach (Exercises exerciseKey in Exercises.Keys)
            {
                ConsoleHelper.PrintItem((int)exerciseKey, exerciseKey.ToString());
            }

            int exercise = default;
            exercise = exercise.InputEnum<Exercises>();
            while (!Exercises.ContainsKey((Exercises)exercise))
            {
                Console.WriteLine("Незарегистрированный тип");
                exercise = exercise.InputEnum<Exercises>();
            }

            Console.Clear();
            Exercises[(Exercises)exercise]();
        }
    }
}
