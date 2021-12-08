using GeekBrainsCSharpBasics.InputDataLibrary;

namespace GeekBrainsCSharpBasics.Lesson6
{
    public enum StudentOperation : short
    {
        None = 0,

        [MenuDescription("Подсчитать количество студентов по курсам", 1)]
        CountStudentsByCourse = 1,

        [MenuDescription("Подсчитать количество студентов по возрасту", 2)]
        CountStudentsByAge = 2,

        [MenuDescription("Отсортировать студентов по возрасту", 3)]
        OrderStudentsByAge = 3,

        [MenuDescription("Отсортировать студентов по курсу и возрасту", 4)]
        OrderStudentsByCourseAndAge = 4
    }
}
