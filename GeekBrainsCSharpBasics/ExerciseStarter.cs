using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics
{
    public abstract class ExerciseStarter
    {
        protected abstract Dictionary<Exercise, Action> LessonExercises { get; }

        public void RunExercises()
        {
            do
            {
                Console.WriteLine("Выберите задание: ");
                Exercise exercise = ConsoleManager.InputMenuItems(LessonExercises.Keys);

                Console.Clear();
                LessonExercises[exercise]();
                ConsoleManager.PauseAndClear();
            } while (true);
        }
    }
}
