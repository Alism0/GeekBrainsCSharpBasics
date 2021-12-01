using GeekBrainsCSharpBasics.AbstractsLibrary;
using System.IO;

namespace GeekBrainsCSharpBasics.DataProvidersLibrary
{
    public abstract class BinaryDataProvider<TData> : IDataProvider<TData[]>
    {
        private readonly string _filePath;

        protected abstract int BlockSize { get; }

        public BinaryDataProvider(string filePath) =>
            _filePath = filePath;

        public TData[] Load()
        {
            using (FileStream fileStream = new FileStream(_filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    TData[] values = new TData[fileStream.Length / BlockSize];
                    for (int i = 0; i < fileStream.Length / BlockSize; i++)
                        values[i] = Read(binaryReader);

                    return values;
                }
            }
        }

        public void Save(TData[] data)
        {
            using (FileStream fileStream = new FileStream(_filePath, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    foreach (TData value in data)
                        Write(value, binaryWriter);
                }
            }
        }

        protected abstract void Write(TData value, BinaryWriter binaryWriter);

        protected abstract TData Read(BinaryReader binaryReader);
    }
}
