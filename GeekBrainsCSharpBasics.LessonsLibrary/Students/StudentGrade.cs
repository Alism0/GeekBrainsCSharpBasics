using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.StudentsLibrary
{
    public class StudentGrade
    {
        public string Name { get; }

        public string Surname { get; }

        public IEnumerable<StudentAssessment> CourseAssessments { get; }

        public StudentGrade(string name, string surname, IEnumerable<StudentAssessment> courseAssessments)
        {
            Name = name;
            Surname = surname;
            CourseAssessments = courseAssessments;
        }

        public StudentGrade() { }
    }
}
