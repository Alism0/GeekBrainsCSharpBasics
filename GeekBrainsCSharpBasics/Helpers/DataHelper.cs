using GeekBrainsCSharpBasics.AbstractsLibrary;
using System;

namespace GeekBrainsCSharpBasics
{
    public static class DataHelper
    {
        public readonly static string ArrayFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}/Files/ArrayFile.txt";
        public readonly static string LoginDataFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}/Files/LoginData.txt";

        public static string[] LoadFromFile(string filePath)
        {
            IDataProvider<string[]> dataProvider = DataProviderFactory.GetDataProvider(filePath);
            return dataProvider.Load();
        }

        public static void SaveIntoFile(string[] array, string filePath)
        {
            IDataProvider<string[]> dataProvider = DataProviderFactory.GetDataProvider(filePath);
            dataProvider.Save(array);
        }
    }
}
