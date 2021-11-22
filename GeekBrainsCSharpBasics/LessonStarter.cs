using GeekBrainsCSharpBasics.Lesson1;
using GeekBrainsCSharpBasics.Lesson2;
using GeekBrainsCSharpBasics.Lesson3;
using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics
{
    public static class LessonStarter
    {
        private readonly static Dictionary<Lesson, Action> _lessons = new Dictionary<Lesson, Action>() {
            { Lesson.Lesson1, () => Lesson1Starter.Instance.RunExercises() },
            { Lesson.Lesson2, () => Lesson2Starter.Instance.RunExercises() },
            { Lesson.Lesson3, () => Lesson3Starter.Instance.RunExercises() },
            { Lesson.Exit, () => ConsoleHelper.CloseApplication() }
        };

        public static void StartLesson()
        {
            Console.WriteLine("Выберите урок:");
            do
            {
                Lesson lesson = ConsoleHelper.InputMenuItems(_lessons.Keys);

                _lessons[lesson]();
                ConsoleHelper.PauseAndClear();
            } while (true);
        }
    }
}
