using GeekBrainsCSharpBasics.AbstractsLibrary;
using GeekBrainsCSharpBasics.Lesson5;
using GeekBrainsCSharpBasics.Lesson6;
using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics
{
    public static class LoadDataHelper
    {
        private readonly static Dictionary<Type, IParser> Parsers = new Dictionary<Type, IParser>()
        {
            { typeof(StudentGrade), new StudentGradeParser() },
            { typeof(Student), new StudentParser() },
        };

        private readonly static Dictionary<Type, string> Paths = new Dictionary<Type, string>()
        {
            { typeof(StudentGrade), PathConstants.StudentAssessmentsFilePath },
            { typeof(Student), PathConstants.StudentsFilePath },
        };

        public static TData[] LoadData<TData>()
        {
            ITextParser<TData> parser = GetParser<TData>();
            string path = GetPath<TData>();

            string[] data = DataHelper.LoadFromFile<string>(path);
            TData[] values = new TData[data.Length];

            for (int i = 0; i < data.Length; i++)
                values[i] = parser.Parse(data[i]);

            return values;
        }

        private static ITextParser<TData> GetParser<TData>()
        {
            if (!Parsers.TryGetValue(typeof(TData), out IParser parser))
                throw new UnregisteredDataTypeException();

            return parser as ITextParser<TData>;
        }

        private static string GetPath<TData>()
        {
            if (!Paths.TryGetValue(typeof(TData), out string path))
                throw new UnregisteredDataTypeException();

            return path;
        }
    }
}
