using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.Lesson6
{
    public sealed class Lesson6Starter : ExerciseStarter
    {
        private readonly static Lesson6Starter _starter = new Lesson6Starter();

        public static Lesson6Starter Instance => _starter;

        #region Функции запуска заданий

        protected override Dictionary<Exercise, Action> LessonExercises => new Dictionary<Exercise, Action>() {
            { Exercise.Exercise1, () => MathFunctionHelper.PrintMathFunctionValues() },
            { Exercise.Exercise2, () => MathFunctionHelper.PrintMathFunctionMinValue() },
            { Exercise.Exercise3, () => StudentHelper.Run() },
            { Exercise.Exit, () => ConsoleManager.CloseApplication() }
        };

        #endregion

        private Lesson6Starter() { }
    }
}
