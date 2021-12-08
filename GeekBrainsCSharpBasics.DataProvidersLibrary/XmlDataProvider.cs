using GeekBrainsCSharpBasics.AbstractsLibrary;
using System.IO;
using System.Xml.Serialization;

namespace GeekBrainsCSharpBasics.DataProvidersLibrary
{
    public class XmlDataProvider<TData> : IDataProvider<TData>
    {
        private readonly string _filePath;

        public XmlDataProvider(string filePath) =>
            _filePath = filePath;

        public TData Load()
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException("Файл не найден");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TData));
            using (FileStream fileStream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
            {
                return (TData)xmlSerializer.Deserialize(fileStream);
            }
        }

        public void Save(TData data)
        {
            using (FileStream fileStream = new FileStream(_filePath, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(TData));
                xmlSerializer.Serialize(fileStream, data);
            }
        }
    }
}
