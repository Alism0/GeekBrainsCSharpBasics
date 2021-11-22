namespace GeekBrainsCSharpBasics.Lesson4
{
    public enum CustomArrayOperation
    {
        [MenuDescription("Завершить работу с массивом", 5)]
        Exit = 0,

        [MenuDescription("Вывести сумму элементов", 0)]
        Sum = 1,

        [MenuDescription("Вывести количество максимальных элементов", 1)]
        MaxCount = 2,

        [MenuDescription("Вывести инвертированный массив", 2)]
        Inverse = 3,

        [MenuDescription("Умножить элементы массива", 3)]
        Multi = 4,

        [MenuDescription("Напечатать элементы массива", 4)]
        Print = 5
    }
}
