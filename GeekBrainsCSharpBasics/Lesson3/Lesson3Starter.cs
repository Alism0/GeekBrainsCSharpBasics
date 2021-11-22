using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.Lesson3
{
    public sealed class Lesson3Starter : ExerciseStarter
    {

        private readonly static Lesson3Starter _starter = new Lesson3Starter();
        public static Lesson3Starter Instance => _starter;

        #region Функции запуска заданий

        protected override Dictionary<Exercise, Action> LessonExercises => new Dictionary<Exercise, Action>() {
            { Exercise.Exercise1, () => RunExercise1() },
            { Exercise.Exercise2, () => ExercisesHelper.GetPositiveOddNumbersSum() },
            { Exercise.Exercise3, () => RunExercise3() },
            { Exercise.Exit, () => ConsoleHelper.CloseApplication() }
        };

        #endregion

        private Lesson3Starter() { }

        private static void RunExercise1() =>
            new ComplexNumberCalculator().Calculate();

        private static void RunExercise3() =>
            new RationalNumberCalculator().Calculate();
    }
}
