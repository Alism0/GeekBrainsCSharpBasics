using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics
{
    public abstract class ExerciseStarter
    {
        protected abstract Dictionary<Exercises, Action> LessonExercises { get; }

        public void RunExercises()
        {
            do
            {

                Console.WriteLine("Выберите задание: ");
                foreach (Exercises exerciseKey in LessonExercises.Keys)
                {
                    ConsoleHelper.PrintItem((int)exerciseKey, exerciseKey.ToString());
                }

                int exercise = default;
                exercise = exercise.InputEnum<Exercises>();
                while (!LessonExercises.ContainsKey((Exercises)exercise))
                {
                    Console.WriteLine("Незарегистрированный тип");
                    exercise = exercise.InputEnum<Exercises>();
                }

                Console.Clear();
                LessonExercises[(Exercises)exercise]();
                ConsoleHelper.PauseAndClear();
            } while (true);
        }
    }
}
