namespace GeekBrainsCSharpBasics
{
    public enum Lesson
    {
        [MenuDescription("Выход", 4)]
        Exit = 0,

        [MenuDescription("Урок 1", 0)]
        Lesson1 = 1,

        [MenuDescription("Урок 2", 1)]
        Lesson2 = 2,

        [MenuDescription("Урок 3", 2)]
        Lesson3 = 3,

        [MenuDescription("Урок 4", 3)]
        Lesson4 = 4
    }
}
