using System;

namespace GeekBrainsCSharpBasics.Lesson5
{
    public class CourseAssessmentExeption : Exception
    {
        public CourseAssessmentExeption(string message) : base(message) { }
    }
}
