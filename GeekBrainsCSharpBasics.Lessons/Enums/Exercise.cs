using GeekBrainsCSharpBasics.InputDataLibrary;

namespace GeekBrainsCSharpBasics.LessonsLibrary
{
    public enum Exercise : short
    {
        [MenuDescription("Закрыть приложение", 7)]
        Exit = 0,

        [MenuDescription("Запустить задание 1", 0)]
        Exercise1 = 1,

        [MenuDescription("Запустить задание 2", 1)]
        Exercise2 = 2,

        [MenuDescription("Запустить задание 3", 2)]
        Exercise3 = 3,

        [MenuDescription("Запустить задание 4", 3)]
        Exercise4 = 4,

        [MenuDescription("Запустить задание 5", 4)]
        Exercise5 = 5,

        [MenuDescription("Запустить задание 6", 5)]
        Exercise6 = 6,

        [MenuDescription("Запустить задание 7", 6)]
        Exercise7 = 7
    }
}
