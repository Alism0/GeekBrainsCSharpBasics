namespace GeekBrainsCSharpBasics
{
    public enum Lesson : short
    {
        [MenuDescription("Выход", 9)]
        Exit = 0,

        [MenuDescription("Урок 1", 0)]
        Lesson1 = 1,

        [MenuDescription("Урок 2", 1)]
        Lesson2 = 2,

        [MenuDescription("Урок 3", 2)]
        Lesson3 = 3,

        [MenuDescription("Урок 4", 3)]
        Lesson4 = 4,

        [MenuDescription("Урок 5", 4)]
        Lesson5 = 5,

        [MenuDescription("Урок 6", 5)]
        Lesson6 = 6
    }
}
