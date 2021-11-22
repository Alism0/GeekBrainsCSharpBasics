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
            { Exercise.Exercise1, () => new ComplexNumberCalculator().Calculate() },
            { Exercise.Exercise2, () => ExercisesHelper.GetPositiveOddNumbersSum() },
            { Exercise.Exercise3, () => new RationalNumberCalculator().Calculate() },
            { Exercise.Exit, () => ConsoleManager.CloseApplication() }
        };

        #endregion

        private Lesson3Starter() { }
    }
}
