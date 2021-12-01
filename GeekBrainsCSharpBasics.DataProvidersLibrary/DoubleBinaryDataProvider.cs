using System.IO;

namespace GeekBrainsCSharpBasics.DataProvidersLibrary
{
    public sealed class DoubleBinaryDataProvider : BinaryDataProvider<double>
    {
        protected override int BlockSize => sizeof(double);

        public DoubleBinaryDataProvider(string filePath) : base(filePath) { }

        protected override double Read(BinaryReader binaryReader) =>
            binaryReader.ReadDouble();

        protected override void Write(double value, BinaryWriter binaryWriter) =>
            binaryWriter.Write(value);
    }
}
