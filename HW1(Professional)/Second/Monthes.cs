using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Monthes : IDictionary<string, Int32>
    {
        private Dictionary<string, int> monthes = new Dictionary<string, int>();

        public Monthes()
        {
            monthes.Add("January", 31);
            monthes.Add("February", 28);
            monthes.Add("March", 31);
            monthes.Add("April", 30);
            monthes.Add("May", 31);
            monthes.Add("June", 30);
            monthes.Add("July", 31);
            monthes.Add("August", 31);
            monthes.Add("September", 30);
            monthes.Add("October", 31);
            monthes.Add("November", 30);
            monthes.Add("December", 31);
        }

        public int this[string key] { get => ((IDictionary<string, int>)monthes)[key]; set { } }

        public string this[double pos]
        { 
            get 
            {
                int i = 0;
                foreach (var item in monthes)
                {
                    if (i == pos)
                    {
                        return item.Key;
                    }
                    i++;
                }
                return "";
            }
        }

        public IEnumerable<string> this[int AmountDays]
        {
            get
            {
                foreach (var item in monthes)
                {
                    if (item.Value == AmountDays)
                    {
                        yield return item.Key;
                    }
                }
                yield break;
            }
        }

        public ICollection<string> Keys => ((IDictionary<string, int>)monthes).Keys;

        public ICollection<int> Values => ((IDictionary<string, int>)monthes).Values;

        public int Count => ((ICollection<KeyValuePair<string, int>>)monthes).Count;

        public bool IsReadOnly => ((ICollection<KeyValuePair<string, int>>)monthes).IsReadOnly;

        public void Add(string key, int value)
        {
            ((IDictionary<string, int>)monthes).Add(key, value);
        }

        public void Add(KeyValuePair<string, int> item)
        {
            ((ICollection<KeyValuePair<string, int>>)monthes).Add(item);
        }

        public void Clear()
        {
            ((ICollection<KeyValuePair<string, int>>)monthes).Clear();
        }

        public bool Contains(KeyValuePair<string, int> item)
        {
            return ((ICollection<KeyValuePair<string, int>>)monthes).Contains(item);
        }

        public bool ContainsKey(string key)
        {
            return ((IDictionary<string, int>)monthes).ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<string, int>[] array, int arrayIndex)
        {
            ((ICollection<KeyValuePair<string, int>>)monthes).CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<string, int>>)monthes).GetEnumerator();
        }

        public bool Remove(string key)
        {
            return ((IDictionary<string, int>)monthes).Remove(key);
        }

        public bool Remove(KeyValuePair<string, int> item)
        {
            return ((ICollection<KeyValuePair<string, int>>)monthes).Remove(item);
        }

        public bool TryGetValue(string key, [MaybeNullWhen(false)] out int value)
        {
            return ((IDictionary<string, int>)monthes).TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)monthes).GetEnumerator();
        }
    }
}
