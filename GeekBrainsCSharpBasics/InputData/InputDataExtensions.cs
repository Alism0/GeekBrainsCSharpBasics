using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GeekBrainsCSharpBasics
{
    public static class InputDataExtensions
    {
        public static string InputValue(this string _, string mask = null)
        {
            if (string.IsNullOrEmpty(mask))
                return Console.ReadLine();

            return ParseInputValue(mask);
        }

        public static double InputValue(this double doubleValue)
        {
            ParseInputValue((value) => double.TryParse(value, out doubleValue));
            return doubleValue;
        }

        public static int InputValue(this int intValue)
        {
            ParseInputValue((value) => int.TryParse(value, out intValue));
            return intValue;
        }

        public static short InputValue(this short intValue)
        {
            ParseInputValue((value) => short.TryParse(value, out intValue));
            return intValue;
        }

        public static void InputData<TInputData>(this TInputData inputData) where TInputData : IInputData
        {
            PropertyInfo[] properties = inputData.GetType().GetProperties();
            List<InputPropertyDescription> inputPropertyDescriptions = new List<InputPropertyDescription>();
            foreach (PropertyInfo property in properties)
            {
                InputDescriptionPropertyAttribute inputDescriptionProperty = property.GetCustomAttribute<InputDescriptionPropertyAttribute>();
                if (inputDescriptionProperty == null)
                    continue;

                inputPropertyDescriptions.Add(new InputPropertyDescription
                {
                    Property = property,
                    InputDescription = inputDescriptionProperty
                });
            }

            inputPropertyDescriptions.OrderBy(inputPropertyDescription => inputPropertyDescription.InputDescription.Order).ToList()
                .ForEach(inputPropertyDescription => {
                    PrintDescription(inputPropertyDescription.InputDescription);

                    if (typeof(int) == inputPropertyDescription.Property.PropertyType)
                    {
                        int result = 0;
                        result = result.InputValue();
                        inputPropertyDescription.Property.SetValue(inputData, result);

                        return;
                    }

                    if (typeof(double) == inputPropertyDescription.Property.PropertyType)
                    {
                        double result = default;
                        result = result.InputValue();
                        inputPropertyDescription.Property.SetValue(inputData, result);

                        return;
                    }

                    if (typeof(string) == inputPropertyDescription.Property.PropertyType)
                    {
                        string result = default;
                        result = result.InputValue(inputPropertyDescription.InputDescription.Mask);

                        inputPropertyDescription.Property.SetValue(inputData, result);

                        return;
                    }

                    throw new Exception($"Незарегестрированный тип данных: {inputPropertyDescription.Property.PropertyType.GetType().Name}");
                });
        }

        public static string FormatPropertyValue(this IInputData inputData, string propertyName)
        {
            PropertyInfo property = inputData.GetType().GetProperty(propertyName);
            if (property == null)
                return null;

            dynamic value = property.GetValue(inputData);
            InputDescriptionPropertyAttribute inputDescriptionProperty = property.GetCustomAttribute<InputDescriptionPropertyAttribute>();
            if (inputDescriptionProperty == null)
                return value?.ToString();

            string description = inputDescriptionProperty.Description;
            string format = inputDescriptionProperty.OutputFormat;
            if (string.IsNullOrEmpty(format))
                return $"{description}{value?.ToString()}";

            if (value is int || value is double)
                return $"{description}{value?.ToString(format)}";

            return $"{description}{value?.ToString()}";
        }

        public static void PrintDescription(this IInputData inputData)
        {
            Type inputDataType = inputData.GetType();
            InputDescriptionAttribute inputDescription = inputDataType.GetCustomAttribute<InputDescriptionAttribute>();
            PrintDescription(inputDescription);
        }

        public static int InputEnum<TEnum>(this int _) where TEnum : struct
        {
            int enumValue = default;
            enumValue = enumValue.InputValue();

            while (!Enum.IsDefined(typeof(TEnum), enumValue))
            {
                Console.WriteLine("Незарегистрированный тип");
                enumValue = enumValue.InputValue();
            }

            return enumValue;
        }

        public static TEnum InputEnum<TEnum>(this TEnum _) where TEnum : Enum
        {
            short enumValue = default;
            enumValue = enumValue.InputValue();

            while (!Enum.IsDefined(typeof(TEnum), enumValue))
            {
                Console.WriteLine("Незарегистрированный тип");
                enumValue = enumValue.InputValue();
            }

            return (TEnum)Enum.Parse(typeof(TEnum), enumValue.ToString());
        }

        private static void ParseInputValue(Func<string, bool> checkValue)
        {
            do
            {
                if (checkValue(Console.ReadLine()))
                    return;

                Console.WriteLine("Некорректный тип данных");
            } while (true);
        }

        private static string ParseInputValue(string mask)
        {
            do
            {
                string stringValue = Console.ReadLine();
                if (stringValue.IsMatch(mask))
                    return stringValue;

                Console.WriteLine("Входная строка не соответствует шаблону");
            } while (true);
        }

        private static void PrintDescription(IInputDescription inputDescription)
        {
            if (!string.IsNullOrEmpty(inputDescription?.Description))
                Console.Write(inputDescription.Description);
        }
    }
}
