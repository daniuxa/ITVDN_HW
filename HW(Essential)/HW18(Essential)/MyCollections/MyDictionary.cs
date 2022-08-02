using System.Collections;

namespace MyCollections
{
    public class MyDictionary<TKey, TValue> : IEnumerable<NodeStruct<TKey, TValue>>
    {
        /*private TKey[] keys;
        private TValue[] values;*/
        private NodeStruct<TKey, TValue>[] array;
        private int Size;
        private int CurrentSize;
        public MyDictionary()
        {
            array = new NodeStruct<TKey, TValue>[5];
            CurrentSize = 0;
            Size = 5;
        }

        public int Length
        {
            get
            {
                return CurrentSize;
            }
        }

        internal protected void Add(TKey key, TValue value)
        {
            if (Size / 2 <= CurrentSize)
            {
                NodeStruct<TKey, TValue>[] NewArray = new NodeStruct<TKey, TValue>[Size * 2];
                Array.Copy(array, NewArray, Size);
                Size *= 2;
                array = NewArray;
            }
            array[CurrentSize] = new NodeStruct<TKey, TValue>(key, value);
            CurrentSize++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<NodeStruct<TKey, TValue>> IEnumerable<NodeStruct<TKey, TValue>>.GetEnumerator()
        {
            for (int i = 0; i < CurrentSize; i++)
            {
                yield return array[i];
            }
        }

        public NodeStruct<TKey, TValue> this[int index]
        {
            get
            {
                if (index > CurrentSize - 1 && index < 0)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index > CurrentSize - 1 && index < 0)
                {
                    array[index] = value;
                }
            }
        }
    }
}