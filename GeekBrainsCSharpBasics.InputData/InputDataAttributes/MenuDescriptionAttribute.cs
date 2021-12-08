using System;

namespace GeekBrainsCSharpBasics.InputDataLibrary
{
    public class MenuDescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public int? Order { get; set; }

        public MenuDescriptionAttribute(string description)
        {
            Description = description;
        }

        public MenuDescriptionAttribute(string name, int order) : this(name)
        {
            Order = order;
        }
    }
}
