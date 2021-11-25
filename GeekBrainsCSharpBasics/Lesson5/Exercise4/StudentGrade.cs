using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.Lesson5
{
    public class StudentGrade
    {
        public string Name { get; }

        public string Surname { get; }

        public IEnumerable<CourseAssessment> CourseAssessments { get; }

        public StudentGrade(string name, string surname, IEnumerable<CourseAssessment> courseAssessments)
        {
            Name = name;
            Surname = surname;
            CourseAssessments = courseAssessments;
        }
    }
}
