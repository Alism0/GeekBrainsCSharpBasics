using GeekBrainsCSharpBasics.AbstractsLibrary;

namespace GeekBrainsCSharpBasics
{
    public static class DataHelper
    {
        public static TData[] LoadFromFile<TData>(string filePath)
        {
            IDataProvider<TData[]> dataProvider = DataProviderFactory.GetDataProvider<TData>(filePath);
            return dataProvider.Load();
        }

        public static void SaveIntoFile<TData>(TData[] array, string filePath)
        {
            IDataProvider<TData[]> dataProvider = DataProviderFactory.GetDataProvider<TData>(filePath);
            dataProvider.Save(array);
        }
    }
}
