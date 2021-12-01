using GeekBrainsCSharpBasics.AbstractsLibrary;
using GeekBrainsCSharpBasics.DataProvidersLibrary;
using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics
{
    public static class DataProviderFactory
    {

        private readonly static Dictionary<Type, Func<string, IProvider>> ProvidersFactory = new Dictionary<Type, Func<string, IProvider>>
        {
            { typeof(string), (filePath) => new FileSystemDataProvider(filePath) },
            { typeof(double), (filePath) => new DoubleBinaryDataProvider(filePath) }
        };

        public static IDataProvider<TData[]> GetDataProvider<TData>(string filePath)
        {
            if (!ProvidersFactory.TryGetValue(typeof(TData), out Func<string, IProvider> providerGetter))
                throw new UnregisteredDataProviderTypeExeption();

            return providerGetter(filePath) as IDataProvider<TData[]>;
        }
    }
}
