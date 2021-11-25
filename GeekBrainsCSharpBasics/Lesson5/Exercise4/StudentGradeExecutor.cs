using System;
using System.Collections.Generic;
using System.Linq;

namespace GeekBrainsCSharpBasics.Lesson5
{
    public static class StudentGradeExecutor
    {
        private const int WorstScoreWinnersPlacesValue = 3;

        private readonly static string StudentAssessmentsFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}/Files/StudentAssessments.txt";

        private readonly static ITextParser<StudentGrade> Parser = new StudentGradeParser();

        public static void CongratulateWorstScoreWinners()
        {
            Console.WriteLine("Проверка оценок учеников или публичная казнь неуспевающих");
            Console.WriteLine();
            Console.WriteLine("Победители:");
            Console.WriteLine();

            if (!TryLoadStudentAssessmentResults(out List<StudentGrade> studentGrades))
            {
                Console.WriteLine("Задание будет завершено");
                return;
            }

            foreach (var worstStudentsScore in studentGrades.GetOrderedStudentsScores().Take(WorstScoreWinnersPlacesValue).Reverse())
            {
                Console.WriteLine($"Средний бал: {worstStudentsScore.Key}");
                Console.WriteLine($"Победители: {string.Join(", ", worstStudentsScore.Value.Select(studentGrade => $"{studentGrade.Surname} {studentGrade.Name}"))}");
                Console.WriteLine();
            }

            Console.WriteLine("Поздравляем!");
        }

        private static bool TryLoadStudentAssessmentResults(out List<StudentGrade> studentGrades)
        {
            studentGrades = new List<StudentGrade>();
            try
            {
                string[] studentAssessments = DataHelper.LoadFromFile(StudentAssessmentsFilePath);
                if (studentAssessments.Length < 10 || studentAssessments.Length > 99)
                    throw new CourseAssessmentExeption("Некорретное количество учеников");

                foreach (string studentAssessmentValue in studentAssessments)
                    studentGrades.Add(Parser.Parse(studentAssessmentValue));
            }
            catch (NotSupportInputDataFormatExeption exeption)
            {
                Console.WriteLine(exeption.Message);
                return false;
            }
            catch (CourseAssessmentExeption exeption)
            {
                Console.WriteLine(exeption.Message);
                return false;
            }
            return true;
        }
    }
}
