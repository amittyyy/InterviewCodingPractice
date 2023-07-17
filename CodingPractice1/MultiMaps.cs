using System.Collections;

namespace MultiMapConcept
{
    public class MultiMaps
    {

        private ArrayList _multiMap = new ArrayList();

        //private Dictionary<string, string> _multiMapDic = new Dictionary<string, string>();

        public void addList(object key, object arrInserter)
        {
             ArrayList elements = null;
            //TODO if key already exist, add to arrayList
            foreach(MultiMapPairs pair in _multiMap)
            {
                if(key.Equals(pair._key))
                {
                    elements = pair._elements;
                    break;
                }
            }

            //TODO add value into correct key

            if(elements != null)
            {
                elements.Add(arrInserter);
            }

            //TODO else insert into multimap
            else
            {
                MultiMapPairs mpr = new MultiMapPairs(key, arrInserter);
                _multiMap.Add(mpr);
                
            }
        }

        public ArrayList FindByKey(object key)
        {
            ArrayList data = new ArrayList();

            foreach(MultiMapPairs pair in _multiMap)
            {
                if(key.Equals(pair._key))
                {
                    data.Add(pair._elements);
                    break;
                }
            }

            return data;
        }

        public ArrayList Keys()
        {
            ArrayList dataKeys = new ArrayList();
            foreach (MultiMapPairs item in _multiMap)
            {
                dataKeys.Add(item._key);
            }

            return dataKeys;
        }

    }

    public class MultiMapPairs
    {
        public object _key;
        public ArrayList _elements = new ArrayList();

        public MultiMapPairs(object key, object elements)
        {
            _key = key;
            _elements.Add(elements);
        }
    }
}
