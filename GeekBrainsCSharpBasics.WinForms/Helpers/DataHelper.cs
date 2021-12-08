using GeekBrainsCSharpBasics.InputDataLibrary;

namespace GeekBrainsCSharpBasics.WinForms.Helpers
{
    public static class DataHelper
    {
        private static readonly DataProvider _provider = new DataProvider(new DataModelProviderFactory());

        public static TData Load<TData>(string filePath) =>
            _provider.LoadFromFile<TData>(filePath);

        public static void Save<TData>(TData data, string filePath) =>
            _provider.SaveIntoFile(data, filePath);
    }
}
