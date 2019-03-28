using System.Collections;

namespace MehrdadTajedini.DesignPatterns.Behavioral.Iterator
{
    public sealed class Enumerable : IEnumerable
    {
        public int[] Items { get; }

        public Enumerable()
        {
            // Initialize and fill collection with some data
            Items = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Items[i] = i;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}
