using System;

namespace GeekBrainsCSharpBasics
{
    public class MenuDescriptionAttribute : Attribute
    {
        public string Name { get; set; }

        public int? Order { get; set; }

        public MenuDescriptionAttribute(string name)
        {
            Name = name;
        }

        public MenuDescriptionAttribute(string name, int order) : this(name)
        {
            Order = order;
        }
    }
}
