using GeekBrainsCSharpBasics.InputDataLibrary;
using GeekBrainsCSharpBasics.StudentsLibrary;

namespace GeekBrainsCSharpBasics.WinForms
{
    public static class FileConverter
    {
        private static readonly LoadDataProvider _loadDataProvider = new StudentsProvider();
        private static readonly DataProvider _dataProvider = new DataProvider(new DataModelProviderFactory());

        public static void Convert<TData>(string sourceFile, string destinationFile)
        {
            TData[] data = _loadDataProvider.LoadData<TData>(sourceFile);
            _dataProvider.SaveIntoFile(data, destinationFile);
        }
    }
}
