using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14_Essential_Collections2
{
    internal class MyList<T> : IEnumerable<T>, IEnumerable
    {
        private T[] array;
        private int Size;
        private int CurrentSize;
        public int Length 
        { 
            get
            {
                return CurrentSize;
            }  
        }
        public MyList()
        {
            array = new T[5];
            Size = 5;
            CurrentSize = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < CurrentSize; i++)
            {
                yield return array[i];
            }
        }

        public T this[int index]
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Add(T item)
        {
            if (Size / 2 <= CurrentSize)
            {
                T[] NewArray = new T[Size * 2];
                Array.Copy(array, NewArray, Size);
                Size *= 2;
                array = NewArray;
            }
            array[CurrentSize] = item;
            CurrentSize++;
        }
    }
}
