using System;
using System.Collections.Generic;
using System.Linq;

namespace GeekBrainsCSharpBasics.Lesson5
{
    public static class AssessmentExtensions
    {
        public static double CalculateAverageScore(this StudentGrade studentGrade) =>
            Math.Round((double)studentGrade.CourseAssessments.Select(assessment => assessment.Value).Sum() / studentGrade.CourseAssessments.Count(), 1);

        public static Dictionary<string, IEnumerable<StudentGrade>> GetOrderedStudentsScores(this IEnumerable<StudentGrade> studentGrades) =>
            studentGrades
            .GroupBy(group => group.CalculateAverageScore().ToString("F1"))
            .OrderBy(group => group.Key)
            .ToDictionary(group => group.Key, group => group.Select(studentGrade => studentGrade));
    }
}
