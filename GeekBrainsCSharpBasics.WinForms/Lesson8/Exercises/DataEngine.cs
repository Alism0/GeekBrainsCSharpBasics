using System.Collections;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.WinForms.Lesson8
{
    public class DataEngine<TData> : IEnumerable<TData>
    {
        private readonly List<TData> _data;

        public int Count => _data.Count;

        public TData this[int index] =>
            _data[index];

        public DataEngine() =>
            _data = new List<TData>();
        public DataEngine(List<TData> data) =>
            _data = data;

        public void Add(TData data) =>
            _data.Add(data);

        public void Remove(int index)
        {
            if (_data != null && index >= 0 && index < _data.Count)
                _data.RemoveAt(index);
        }

        public IEnumerator<TData> GetEnumerator() =>
            _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() =>
            GetEnumerator();
    }
}
