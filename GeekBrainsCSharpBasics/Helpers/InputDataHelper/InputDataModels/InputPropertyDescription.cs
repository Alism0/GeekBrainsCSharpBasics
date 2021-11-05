using System.Reflection;

namespace GeekBrainsCSharpBasics
{
    public class InputPropertyDescription
    {
        public PropertyInfo Property { get; set; }

        public InputDescriptionPropertyAttribute InputDescription { get; set; }
    }
}
