using GeekBrainsCSharpBasics.AbstractsLibrary;
using GeekBrainsCSharpBasics.ExceptionsLibrary;
using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.InputDataLibrary
{
    public abstract class ProviderFactory
    {
        protected abstract Dictionary<Type, Func<string, IProvider>> ProvidersFactory { get; }

        public IDataProvider<TData> GetDataProvider<TData>(string filePath)
        {
            if (!ProvidersFactory.TryGetValue(typeof(TData), out Func<string, IProvider> providerGetter))
                throw new UnregisteredDataProviderTypeExeption();

            return providerGetter(filePath) as IDataProvider<TData>;
        }
    }
}
