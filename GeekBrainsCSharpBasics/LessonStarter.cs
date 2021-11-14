using GeekBrainsCSharpBasics.Lesson1;
using GeekBrainsCSharpBasics.Lesson2;
using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics
{
    public static class LessonStarter
    {
        private readonly static Dictionary<Lessons, Action> _lessons = new Dictionary<Lessons, Action>() {
            { Lessons.Lesson1, () => Lesson1Starter.Instance.RunExercises() },
            { Lessons.Lesson2, () => Lesson2Starter.Instance.RunExercises() }
        };

        public static void StartLesson()
        {
            Console.WriteLine("Выберите урок:");
            ConsoleHelper.PrintEnumContent(typeof(Lessons));
            int lesson = default;
            lesson = lesson.InputEnum<Lessons>();
            while (!_lessons.ContainsKey((Lessons)lesson))
            {
                Console.WriteLine("Незарегистрированный тип");
            }

            _lessons[(Lessons)lesson]();
        }
    }
}
