using GeekBrainsCSharpBasics.InputDataLibrary;

namespace GeekBrainsCSharpBasics.Lesson4
{
    public enum TwoDimensionsArrayOperation
    {
        [MenuDescription("Завершить работу с двумерным массивом", 6)]
        Exit = 0,

        [MenuDescription("Вывести значение минимального элемента", 0)]
        Min = 1,

        [MenuDescription("Вывести значение максимального элемента", 1)]
        Max = 2,

        [MenuDescription("Вывести сумму элементов массива", 2)]
        Sum = 3,

        [MenuDescription("Вывести сумму элементов массива больше заданного числа", 3)]
        SumElementsGreaterThanValue = 4,

        [MenuDescription("Вывести индекс максимального элемента", 4)]
        GetMaxValueIndexes = 5,

        [MenuDescription("Напечатать элементы массива", 5)]
        Print = 6
    }
}
