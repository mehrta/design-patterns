using System.Collections;

namespace MehrdadTajedini.DesignPatterns.Behavioral.Iterator
{
    public class Enumerator: IEnumerator
    {
        Enumerable collection;
        int position = -1;

        public Enumerator(Enumerable collection)
        {
            this.collection = collection;
        }

        object IEnumerator.Current
        {
            get
            {
                return collection.Items[position];
            }
        }

        bool IEnumerator.MoveNext()
        {
            position++;
            return position < collection.Items.Length;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}
