using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GeekBrainsCSharpBasics
{
    public static class EnumExtensions
    {
        public static TValue GetAttributeValue<TValue, TAttribute>(this Enum enumerationValue, Func<TAttribute, TValue> extractor)
            where TAttribute : Attribute
        {
            TAttribute attribute = enumerationValue
                .GetType()
                .GetMember(enumerationValue.ToString())
                .FirstOrDefault()
                ?.GetCustomAttribute<TAttribute>();

            return attribute != null
                ? extractor(attribute)
                : default;
        }

        public static List<TEnum> GetValuesWithAttribute<TEnum, TAttribute>()
            where TEnum : Enum
            where TAttribute : Attribute
        {
            List<TEnum> values = new List<TEnum>();
            FieldInfo[] fieldsInfo = typeof(TEnum).GetFields();

            foreach (TEnum value in Enum.GetValues(typeof(TEnum)))
            {
                if (fieldsInfo.FirstOrDefault(field => field.Name == value.ToString())?.GetCustomAttribute<TAttribute>() != null)
                    values.Add(value);
            }

            return values;
        }
    }
}
