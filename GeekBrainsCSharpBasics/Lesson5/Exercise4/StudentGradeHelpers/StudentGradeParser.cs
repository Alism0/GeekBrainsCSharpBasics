using System.Linq;

namespace GeekBrainsCSharpBasics.Lesson5
{
    public class StudentGradeParser : ITextParser<StudentGrade>
    {
        private const string StudentGrade = "^([А-Яа-я]{1,20})[\\s]{1}([А-Яа-я]{1,15})[\\s]{1}([1-5]{1})[\\s]{1}([1-5]{1})[\\s]{1}([1-5]{1})$";

        public StudentGrade Parse(string data)
        {
            string[] values = data.GetAllMatchGroupValues(StudentGrade).ToArray();
            if (!values.Any())
                throw new NotSupportInputDataFormatExeption();

            return new StudentGrade(
                values[1],
                values[0],
                values.Skip(2).Select(value => new CourseAssessment(int.Parse(value)))
                );
        }
    }
}
