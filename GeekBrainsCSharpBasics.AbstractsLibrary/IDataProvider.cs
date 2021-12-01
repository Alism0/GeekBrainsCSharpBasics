namespace GeekBrainsCSharpBasics.AbstractsLibrary
{
    public interface IDataProvider<TData> : IProvider
    {
        TData Load();

        void Save(TData data);
    }
}
