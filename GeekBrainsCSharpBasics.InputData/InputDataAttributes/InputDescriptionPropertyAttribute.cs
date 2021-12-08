using System;

namespace GeekBrainsCSharpBasics.InputDataLibrary
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class InputDescriptionPropertyAttribute : InputDescriptionAttribute
    {
        public string OutputFormat { get; set; }

        public int Order { get; set; }

        public string Mask { get; set; }

        public InputDescriptionPropertyAttribute() : base() { }

        public InputDescriptionPropertyAttribute(string description) : base(description)
        {
        }

        public InputDescriptionPropertyAttribute(string description, int order) : base(description)
        {
            Order = order;
        }

        public InputDescriptionPropertyAttribute(string description, int order, string format) : this(description, order)
        {
            OutputFormat = format;
        }
    }
}
