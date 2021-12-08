using GeekBrainsCSharpBasics.AbstractsLibrary;
using GeekBrainsCSharpBasics.DataProvidersLibrary;
using GeekBrainsCSharpBasics.InputDataLibrary;
using GeekBrainsCSharpBasics.StudentsLibrary;
using GeekBrainsCSharpBasics.WinForms.Lesson8;
using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.WinForms
{
    public class DataModelProviderFactory : ProviderFactory
    {
        protected override Dictionary<Type, Func<string, IProvider>> ProvidersFactory => new Dictionary<Type, Func<string, IProvider>>
        {
            { typeof(List<Question>), filePath => new XmlDataProvider<List<Question>>(filePath) },
            { typeof(List<LogNote>), filePath => new XmlDataProvider<List<LogNote>>(filePath) },
            { typeof(Student[]), filePath => new XmlDataProvider<Student[]>(filePath) }
        };
    }
}
