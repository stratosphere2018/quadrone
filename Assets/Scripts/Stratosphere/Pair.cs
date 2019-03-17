using System;

namespace Stratosphere
{
    public class Pair<TKey, TValue>
    {
        public TKey key;
        public TValue value;

        public Pair()
        {
        }

        public Pair(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
