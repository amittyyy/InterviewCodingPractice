using System.Collections;

namespace MultiValuesDictionary_ServiceTitan
{
    public class MultiValueDictionary <K,V> : IMultiValueDictionary<K,V> 
    {
        Dictionary<K, List<V>> _dictionary = new Dictionary<K, List<V>>();

        // Add your implementation here
        public bool Add(K key, V value)
        {
            //Add 
            List<V> list;
            if (this._dictionary.TryGetValue(key, out list))
            {
                if (list.Contains(value))
                {
                    return false;
                }
                else
                {
                    list.Add(value);
                    return true;
                }

            }
            else
            {
                list = new List<V>();
                list.Add(value);
                this._dictionary[key] = list;
                return true;

            }
        }

        public IEnumerable<V> Get(K key)
        {
            List<V> list;

            if (this._dictionary.TryGetValue(key, out list))
            {
                return list;
            }

            throw new KeyNotFoundException("KeyNotFoundException");


        }
        public IEnumerable<V> GetOrDefault(K key)
        {

            List<V> list;

            if (this._dictionary.TryGetValue(key, out list))
            {
                return list;
            }

            return list;
        }

        public void Remove(K key, V value)
        {
            List<V> list;
            if (this._dictionary.TryGetValue(key, out list))
            {
                if (list.Contains(value))
                {
                    list.Remove(value);
                    this._dictionary[key] = list;

                }

            }

            throw new KeyNotFoundException("KeyNotFoundException");

        }

        public void Clear(K key)
        {
            this._dictionary.Remove(key);
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            //  return this._dictionary.GetEnumerator();
            foreach (var item in this._dictionary)
            {
                foreach (var listValue in item.Value)
                {
                    yield return new KeyValuePair<K, V>(item.Key, listValue);
                }

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
