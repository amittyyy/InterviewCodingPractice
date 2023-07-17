namespace MultiMapConcept
{
    public class DicGentMultiMap<V>
    {
        Dictionary<string, List<V>> _dict = new Dictionary<string, List<V>>();

        public void Add(string key, V value)
        {
            List<V>? list = null;
            //TODO check key and add values in same group
            if(_dict.TryGetValue(key, out list))
            {
                list.Add(value);
            }
            //TODO add new key values pair
            else
            {
                list = new List<V>();
                list.Add(value);
                _dict.Add(key, list);                
            }

        }

        public IEnumerable<string> Keys()
        {
            return _dict.Keys;
        }

        public List<V> FindByKey(string key)
        {
            List<V>? list = new List<V>();

            if (_dict.TryGetValue(key, out list))
            {
                //list = new List<V>();
                list = _dict[key];
            }
            return list;

        }


    }
}
