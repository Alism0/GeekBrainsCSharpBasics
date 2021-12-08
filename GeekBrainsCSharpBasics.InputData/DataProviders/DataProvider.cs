using GeekBrainsCSharpBasics.AbstractsLibrary;

namespace GeekBrainsCSharpBasics.InputDataLibrary
{
    public class DataProvider
    {
        private readonly ProviderFactory _dataProviderFactory;

        public DataProvider(ProviderFactory dataProviderFactory) =>
            _dataProviderFactory = dataProviderFactory;

        public TData LoadFromFile<TData>(string filePath)
        {
            IDataProvider<TData> dataProvider = _dataProviderFactory.GetDataProvider<TData>(filePath);
            return dataProvider.Load();
        }

        public void SaveIntoFile<TData>(TData data, string filePath)
        {
            IDataProvider<TData> dataProvider = _dataProviderFactory.GetDataProvider<TData>(filePath);
            dataProvider.Save(data);
        }
    }
}
