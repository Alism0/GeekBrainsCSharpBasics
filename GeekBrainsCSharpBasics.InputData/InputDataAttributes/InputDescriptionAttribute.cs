using System;

namespace GeekBrainsCSharpBasics.InputDataLibrary
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InputDescriptionAttribute : Attribute, IInputDescription
    {
        public string Description { get; set; }

        public InputDescriptionAttribute() { }

        public InputDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
