using GeekBrainsCSharpBasics.AbstractsLibrary;

namespace GeekBrainsCSharpBasics.Lesson6
{
    public sealed class StudentParser : ITextParser<Student>
    {
        public Student Parse(string data)
        {
            string[] values = data.Split(';');

            return new Student(values[0], values[1], values[2], values[3], values[4], int.Parse(values[5]), int.Parse(values[6]), int.Parse(values[7]), values[8]);
        }
    }
}
