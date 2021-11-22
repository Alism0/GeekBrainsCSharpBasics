using GeekBrainsCSharpBasics.AbstractsLibrary;
using GeekBrainsCSharpBasics.ArraysLibrary;
using System;
using System.IO;

namespace GeekBrainsCSharpBasics.DataProvidersLibrary
{
    public class FileSystemDataProvider : IDataProvider<string[]>
    {
        private const int BufferSize = 100;
        private readonly string _filePath;

        public FileSystemDataProvider(string filePath) =>
            _filePath = filePath;

        public string[] Load()
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException("Файл не найден");

            using (StreamReader reader = new StreamReader(_filePath))
            {
                string[] values = new string[BufferSize];

                int count = 0;
                while (!reader.EndOfStream)
                {
                    if (values.Length == count)
                        values = values.IncreaseSize();

                    values[count] = reader.ReadLine();
                    count++;
                }

                string[] buffer = new string[count];
                Array.Copy(values, buffer, count);

                return buffer;
            }
        }

        public void Save(string[] data)
        {
            if (!File.Exists(_filePath))
                File.Create(_filePath);

            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                foreach (string value in data)
                    writer.WriteLine(value);
            }
        }
    }
}
