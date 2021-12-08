using GeekBrainsCSharpBasics.InputDataLibrary;
using System;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms
{
    public class FormFileProvider<TData>
        where TData : new()
    {
        private readonly DataProvider _provider = new DataProvider(new DataModelProviderFactory());

        private bool IsNewFile { get; set; } = true;

        private string _filePath;

        public FormFileProvider() { }

        public TData New()
        {
            _filePath = null;
            IsNewFile = true;

            return new TData();
        }

        public TData Open()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return default;

                TData data = _provider.LoadFromFile<TData>(openFileDialog.FileName);

                _filePath = openFileDialog.FileName;
                IsNewFile = false;
                return data;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Ошибка при открытии файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return default;
        }

        public void Save(TData data)
        {
            if (IsNewFile)
            {
                SaveAs(data);
                return;
            }

            _provider.SaveIntoFile(data, _filePath);
            IsNewFile = false;
        }

        public void SaveAs(TData data)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            _provider.SaveIntoFile(data, saveFileDialog.FileName);

            _filePath = saveFileDialog.FileName;
            IsNewFile = false;
        }
    }
}
