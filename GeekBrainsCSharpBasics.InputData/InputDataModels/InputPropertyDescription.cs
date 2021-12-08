using System.Reflection;

namespace GeekBrainsCSharpBasics.InputDataLibrary
{
    public class InputPropertyDescription
    {
        public PropertyInfo Property { get; set; }

        public InputDescriptionPropertyAttribute InputDescription { get; set; }
    }
}
