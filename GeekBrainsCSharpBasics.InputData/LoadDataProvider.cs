using GeekBrainsCSharpBasics.AbstractsLibrary;
using GeekBrainsCSharpBasics.ExceptionsLibrary;
using GeekBrainsCSharpBasics.InputDataLibrary;
using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics
{
    public abstract class LoadDataProvider
    {
        protected abstract DataProvider DataProvider { get; }

        protected abstract Dictionary<Type, IParser> Parsers { get; }

        public TData[] LoadData<TData>(string filePath)
        {
            ITextParser<TData> parser = GetParser<TData>();
            string[] data = DataProvider.LoadFromFile<string[]>(filePath);
            TData[] values = new TData[data.Length];

            for (int i = 0; i < data.Length; i++)
                values[i] = parser.Parse(data[i]);

            return values;
        }

        private ITextParser<TData> GetParser<TData>()
        {
            if (!Parsers.TryGetValue(typeof(TData), out IParser parser))
                throw new UnregisteredDataTypeException();

            return parser as ITextParser<TData>;
        }
    }
}
