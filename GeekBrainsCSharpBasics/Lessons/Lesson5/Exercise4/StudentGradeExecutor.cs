using GeekBrainsCSharpBasics.StudentsLibrary;
using System;
using System.Linq;

namespace GeekBrainsCSharpBasics.Lesson5
{
    public static class StudentGradeExecutor
    {
        private static readonly StudentsProvider _studentsProvider = new StudentsProvider();

        private const int WorstScoreWinnersPlacesValue = 3;

        public static void CongratulateWorstScoreWinners()
        {
            Console.WriteLine("Проверка оценок учеников или публичная казнь неуспевающих");
            Console.WriteLine();
            Console.WriteLine("Победители:");
            Console.WriteLine();

            if (!TryLoadStudentAssessmentResults(out StudentGrade[] studentGrades))
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

        private static bool TryLoadStudentAssessmentResults(out StudentGrade[] studentGrades)
        {
            studentGrades = null;
            try
            {
                if (!LoadDataExeptionHelper.TryLoadData(() => _studentsProvider.LoadData<StudentGrade>(PathConstants.StudentAssessmentsFilePath), out StudentGrade[] data))
                    return false;

                if (data.Length < 10 || data.Length > 99)
                    throw new CourseAssessmentExeption("Некорретное количество учеников");

                studentGrades = data;
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
