using System;
using System.Collections.Generic;
using System.Linq;

namespace GeekBrainsCSharpBasics
{
    public static class ConsoleManager
    {
        public static void Pause()
        {
            int currentLine = Console.CursorTop;
            Console.ReadKey();
            Console.SetCursorPosition(0, currentLine);
        }

        public static void PauseAndClear()
        {
            Pause();
            Console.Clear();
        }

        public static void CloseApplication()
        {
            if (ReadKeyYesNoValue("Закрыть приложение? (Y/N): "))
                Environment.Exit(0);
        }

        public static bool ReadKeyEnter(string message)
        {
            do
            {
                Console.WriteLine(message);
                int currentLine = Console.CursorTop;
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                    return true;

                Console.SetCursorPosition(0, currentLine);
            }
            while (true);
        }

        public static void PrintValues<TElement>(IEnumerable<TElement> values)
        {
            int blocks = 0;
            foreach (TElement value in values)
            {
                Console.Write($"{new string(' ', Math.Abs(12 - value.ToString().Length))}{value}\t");
                blocks++;
                if (blocks >= 7)
                {
                    blocks = 0;
                    Console.WriteLine();
                }
            }
        }

        public static void PrintEnumContent(this Type enumType)
        {
            Array enumValues = Enum.GetValues(enumType);

            foreach (object enumValue in enumValues)
            {
                PrintMenuItem((int)enumValue, enumValue.ToString());
            }
        }

        public static void PrintMenuItem(int number, string description) =>
            Console.WriteLine($"{number}. {description}");

        public static int ReadlineIntValue()
        {
            IntValue value = new IntValue();
            value.InputData();
            return value.Value;
        }

        public static int ReadlineIntValue(string message)
        {
            Console.Write(message);
            return ReadlineIntValue();
        }

        public static int ReadlineNonZeroPositiveIntValue(string message)
        {
            int value;
            do
            {
                value = ReadlineIntValue(message);
                if (value <= 0)
                    Console.WriteLine("Значение должно быть больше 0");
            } while (value <= 0);

            return value;
        }

        public static bool ReadKeyYesNoValue(string message)
        {
            Console.WriteLine(message);
            int currentLine = Console.CursorTop;
            do
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine();
                        return true;
                    case ConsoleKey.N:
                        Console.WriteLine();
                        return false;
                    default:
                        Console.SetCursorPosition(0, currentLine);
                        break;
                }
            }
            while (true);
        }

        public static char ReadKeyLetter(string message)
        {
            Console.WriteLine(message);
            do
            {
                char key = Console.ReadKey().KeyChar;
                if (char.IsLetter(key))
                    return key;

                Console.WriteLine("Значение не является буквой");
            }
            while (true);
        }


        public static void PrintByCenter(string value)
        {
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            Console.WriteLine(value);
        }

        public static TMenuEnum InputMenuItems<TMenuEnum>(IEnumerable<TMenuEnum> menuItems) where TMenuEnum : Enum
        {
            Dictionary<TMenuEnum, MenuDescriptionAttribute> menuDescriptions = new Dictionary<TMenuEnum, MenuDescriptionAttribute>();
            foreach (TMenuEnum menuItem in menuItems)
            {
                MenuDescriptionAttribute menuDescription = menuItem.GetAttributeValue<MenuDescriptionAttribute, MenuDescriptionAttribute>(attribute => attribute);
                if (menuDescription == null)
                    continue;

                menuDescriptions[menuItem] = menuDescription;
            }

            if (!menuDescriptions.Any())
                throw new NotFoundMenuItemsException();

            menuDescriptions = menuDescriptions.OrderBy(menuDescription => menuDescription.Value.Order)
                .ToDictionary(menuDescription => menuDescription.Key, menuDescription => menuDescription.Value);


            foreach (var menuDescription in menuDescriptions)
                Console.WriteLine($"{menuDescription.Key:D}. {menuDescription.Value.Description}");


            TMenuEnum menuItemValue = default;
            menuItemValue = menuItemValue.InputEnum();
            while (!menuDescriptions.ContainsKey(menuItemValue))
            {
                Console.WriteLine("Незарегистрированный тип");
                menuItemValue = menuItemValue.InputEnum();
            }

            return menuItemValue;
        }
    }
}
