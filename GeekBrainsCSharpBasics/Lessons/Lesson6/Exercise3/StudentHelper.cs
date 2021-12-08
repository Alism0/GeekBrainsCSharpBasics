using GeekBrainsCSharpBasics.StudentsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeekBrainsCSharpBasics.Lesson6
{
    public static class StudentHelper
    {
        private static readonly StudentsProvider _studentsProvider = new StudentsProvider();

        private const int MaxCourse = 6;

        private readonly static Dictionary<StudentOperation, Action<Student[]>> StudentOperations = new Dictionary<StudentOperation, Action<Student[]>>()
        {
            { StudentOperation.CountStudentsByCourse, CountStudentsByCourse },
            { StudentOperation.CountStudentsByAge, CountStudentsByAge },
            { StudentOperation.OrderStudentsByAge, OrderStudentsByAge },
            { StudentOperation.OrderStudentsByCourseAndAge, OrderStudentsByCourseAndAge }
        };

        public static void Run()
        {
            Student[] students = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Информация о студентах");
                Console.WriteLine();
                if (!ConsoleManager.ReadKeyYesNoValue("Продолжить? (Y/N)"))
                    return;

                Console.WriteLine();
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine();
                StudentOperation studentOperationKey = ConsoleManager.InputMenuItems(StudentOperations.Keys);

                students = students ?? _studentsProvider.LoadData<Student>(PathConstants.StudentsFilePath);
                StudentOperations[studentOperationKey](students);
            } while (!ConsoleManager.ReadKeyYesNoValue("Завершить? (Y/N)"));
        }

        private static void CountStudentsByCourse(Student[] students)
        {
            Console.WriteLine();
            Console.WriteLine("Ввод диапазона курсов");
            Console.WriteLine();

            (int MinValue, int MaxValue) = ConsoleManager.ReadlineIntValuesRange();
            Console.WriteLine();

            int count = students.Where(student => student.Course >= MinValue && student.Course <= MaxValue).Count();
            Console.WriteLine($"Количество студентов учащихся на {MinValue:D} - {MaxValue} курсах: {count}");
        }

        private static void CountStudentsByAge(Student[] students)
        {
            int minAge = ConsoleManager.ReadlineNonZeroPositiveIntValue("Введите минимальный возраст: ");
            int maxAge = ConsoleManager.ReadlineNonZeroPositiveIntValue("Введите максимальный возраст: ");
            CalculationHelper.SortRanges(ref minAge, ref maxAge);

            int studentsMaxCourse = students.Max(student => student.Course);
            int maxCourse = studentsMaxCourse > MaxCourse ? studentsMaxCourse : MaxCourse;

            int[] courseStudentsCounts = new int[maxCourse];
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Age >= minAge && students[i].Age <= maxAge)
                    courseStudentsCounts[students[i].Course - 1]++;
            }

            Console.WriteLine($"Количество студентов в возрасте {minAge} - {maxAge} на курсах 1 - {maxCourse}");
            Console.WriteLine();
            Console.WriteLine($"{"Курс",4} {"Количество",10}");
            for (int i = 0; i < courseStudentsCounts.Length; i++)
                Console.WriteLine($"{i + 1,4} {courseStudentsCounts[i],10}");
        }

        private static void OrderStudentsByAge(Student[] students) =>
            PrintStudents(students.OrderBy(student => student.Age));

        private static void OrderStudentsByCourseAndAge(Student[] students) =>
            PrintStudents(students.OrderBy(student => student.Course).ThenBy(student => student.Age));

        private static void PrintStudents(IEnumerable<Student> students)
        {
            Console.WriteLine($"{"Имя",15} {"Фамилия",15} {"Возраст",8} {"Курс",6}");
            Console.WriteLine();
            foreach (Student student in students)
                Console.WriteLine($"{student.Name,15} {student.Surname,15} {student.Age,8} {student.Course,6}");
        }
    }
}
