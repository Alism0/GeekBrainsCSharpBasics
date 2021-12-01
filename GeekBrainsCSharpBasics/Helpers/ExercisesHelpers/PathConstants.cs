using System;

namespace GeekBrainsCSharpBasics
{
    public static class PathConstants
    {
        public readonly static string ArrayFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}/Files/ArrayFile.txt";
        public readonly static string LoginDataFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}/Files/LoginData.txt";
        public readonly static string BinDataFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}/Files/data.bin";
        public readonly static string StudentAssessmentsFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}/Files/StudentAssessments.txt";
        public readonly static string StudentsFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}/Files/students.csv";
    }
}
