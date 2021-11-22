using GeekBrainsCSharpBasics.ArraysLibrary;
using System;

namespace GeekBrainsCSharpBasics.Lesson4
{
    public static class ArraysStarter
    {
        public static void RunCustomArrayOperations()
        {
            Console.Write("Работа с массивом");
            Console.WriteLine();

            CustomArray customArray;
            if (ConsoleManager.ReadKeyYesNoValue("Инициализировать массив рандомно? (Y/N): "))
            {
                int size = ConsoleManager.ReadlineNonZeroPositiveIntValue("Введите размер массива: ");
                int step = ConsoleManager.ReadlineNonZeroPositiveIntValue("Введите шаг инициализации массива: ");
                customArray = new CustomArray(size, step);
            }
            else
                customArray = new CustomArray(DataProviderFactory.GetDataProvider(DataHelper.ArrayFilePath));

            do
            {
                Console.Write("Доступные операции:");
                Console.WriteLine();

                CustomArrayOperation operation = ConsoleManager.InputMenuItems(EnumExtensions.GetValuesWithAttribute<CustomArrayOperation, MenuDescriptionAttribute>());

                switch (operation)
                {
                    case CustomArrayOperation.Sum:
                        Console.WriteLine();
                        Console.Write("Результат операции: ");
                        Console.Write(customArray.ElementsSum);
                        break;
                    case CustomArrayOperation.MaxCount:
                        Console.WriteLine();
                        Console.Write("Результат операции: ");
                        Console.Write(customArray.MaxCount);
                        break;
                    case CustomArrayOperation.Multi:
                        Console.WriteLine();
                        customArray.Multi(ConsoleManager.ReadlineIntValue("Введите множитель: "));
                        Console.WriteLine();
                        break;
                    case CustomArrayOperation.Inverse:
                        Console.WriteLine();
                        Console.WriteLine("Результат операции: ");
                        ConsoleManager.PrintValues(customArray.Inverse().ConvertToStrings());
                        break;
                    case CustomArrayOperation.Print:
                        Console.WriteLine();
                        Console.WriteLine("Результат операции: ");
                        ConsoleManager.PrintValues(customArray.Array.ConvertToStrings());
                        break;
                    default:
                        if (ConsoleManager.ReadKeyYesNoValue("Завершить работу с массивом?: (Y/N) "))
                            return;
                        break;
                }

                Console.WriteLine();
            } while (true);
        }

        public static void RunTwoDimensionsArrayOperations()
        {
            Console.Write("Работа с двумерным массивом");
            Console.WriteLine();

            int firstDimensionSize = ConsoleManager.ReadlineNonZeroPositiveIntValue("Введите размер 1-го измерения: ");
            int secondDimensionSize = ConsoleManager.ReadlineNonZeroPositiveIntValue("Введите размер 2-го измерения: ");

            TwoDimensionsArray twoDimensionsArray = new TwoDimensionsArray(firstDimensionSize, secondDimensionSize);
            do
            {
                Console.Write("Доступные операции:");
                Console.WriteLine();

                TwoDimensionsArrayOperation operation = ConsoleManager
                    .InputMenuItems(EnumExtensions.GetValuesWithAttribute<TwoDimensionsArrayOperation, MenuDescriptionAttribute>());

                switch (operation)
                {
                    case TwoDimensionsArrayOperation.Min:
                        Console.Write("Результат операции: ");
                        Console.WriteLine(twoDimensionsArray.Min);
                        break;
                    case TwoDimensionsArrayOperation.Max:
                        Console.Write("Результат операции: ");
                        Console.WriteLine(twoDimensionsArray.Max);
                        break;
                    case TwoDimensionsArrayOperation.GetMaxValueIndexes:
                        (int firstIndex, int secondIndex) maxValueIndexes = twoDimensionsArray.GetMaxValueIndexes();
                        Console.Write("Результат операции: ");
                        Console.WriteLine(maxValueIndexes);
                        break;
                    case TwoDimensionsArrayOperation.Sum:
                        Console.Write("Результат операции: ");
                        Console.WriteLine(twoDimensionsArray.ElementsSum());
                        break;
                    case TwoDimensionsArrayOperation.SumElementsGreaterThanValue:
                        Console.WriteLine("Подсчет суммы значений элементов массива больше заданного числа");
                        int minValue = ConsoleManager.ReadlineNonZeroPositiveIntValue("Введите значение: ");
                        Console.Write("Результат операции: ");
                        Console.WriteLine(twoDimensionsArray.SumElementsGreaterThanValue(minValue));
                        break;

                    case TwoDimensionsArrayOperation.Print:
                        Console.WriteLine("Результат операции: ");
                        twoDimensionsArray.Array.GetDimensions().ForEach(value => {
                            ConsoleManager.PrintValues(value);
                            Console.WriteLine();
                        });
                        break;
                    default:
                        if (ConsoleManager.ReadKeyYesNoValue("Завершить работу с массивом?: (Y/N) "))
                            return;
                        break;
                }

                Console.WriteLine();
            } while (true);
        }
    }
}
