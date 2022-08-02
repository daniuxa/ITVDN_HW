using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14_Essential_Collections2
{
    internal class MyList2<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator
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

        int position = -1;
        public T Current 
        {
            get
            {
                if (position < CurrentSize)
                {
                    return array[position];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public MyList2()
        {
            array = new T[5];
            Size = 5;
            CurrentSize = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
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

        public bool MoveNext()
        {
            if (position < CurrentSize - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
