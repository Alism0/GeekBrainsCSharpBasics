namespace GeekBrainsCSharpBasics.AbstractsLibrary
{
    public interface IDataProvider<TData>
    {
        TData Load();

        void Save(TData data);
    }
}
