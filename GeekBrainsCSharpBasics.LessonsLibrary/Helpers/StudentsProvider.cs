using GeekBrainsCSharpBasics.AbstractsLibrary;
using GeekBrainsCSharpBasics.InputDataLibrary;
using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.StudentsLibrary
{
    public class StudentsProvider : LoadDataProvider
    {
        protected override DataProvider DataProvider => new DataProvider(new DataProviderFactory());

        protected override Dictionary<Type, IParser> Parsers => new Dictionary<Type, IParser>()
        {
            { typeof(StudentGrade), new StudentGradeParser() },
            { typeof(Student), new StudentParser() },
        };
    }
}
