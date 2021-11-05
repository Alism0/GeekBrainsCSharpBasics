using System;

namespace GeekBrainsCSharpBasics
{
    [AttributeUsage(AttributeTargets.Property)]
    public class InputDescriptionPropertyAttribute : InputDescriptionAttribute
    {
        public string Format { get; set; }

        public int Order { get; set; }

        public InputDescriptionPropertyAttribute(string description) : base(description)
        {
        }

        public InputDescriptionPropertyAttribute(string description, int order) : base(description)
        {
            Order = order;
        }

        public InputDescriptionPropertyAttribute(string description, int order, string format) : this(description, order)
        {
            Format = format;
        }
    }
}
