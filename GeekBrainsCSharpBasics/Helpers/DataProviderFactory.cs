using GeekBrainsCSharpBasics.AbstractsLibrary;
using GeekBrainsCSharpBasics.DataProvidersLibrary;
using System;

namespace GeekBrainsCSharpBasics
{
    public static class DataProviderFactory
    {
        private static Func<string, IDataProvider<string[]>> Factory => (filePath) => new FileSystemDataProvider(filePath);

        public static IDataProvider<string[]> GetDataProvider(string filePath) =>
            Factory(filePath);
    }
}
