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
                Exercise exercise = ConsoleHelper.InputMenuItems(LessonExercises.Keys);

                Console.Clear();
                LessonExercises[exercise]();
                ConsoleHelper.PauseAndClear();
            } while (true);
        }
    }
}
