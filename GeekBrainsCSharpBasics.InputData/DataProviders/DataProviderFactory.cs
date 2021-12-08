using GeekBrainsCSharpBasics.AbstractsLibrary;
using GeekBrainsCSharpBasics.DataProvidersLibrary;
using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.InputDataLibrary
{
    public class DataProviderFactory : ProviderFactory
    {
        protected override Dictionary<Type, Func<string, IProvider>> ProvidersFactory => new Dictionary<Type, Func<string, IProvider>>
        {
            { typeof(string[]), (filePath) => new FileSystemDataProvider(filePath) },
            { typeof(double[]), (filePath) => new DoubleBinaryDataProvider(filePath) }
        };
    }
}
