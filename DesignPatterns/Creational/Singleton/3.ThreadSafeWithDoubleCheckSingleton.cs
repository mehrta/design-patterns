namespace MehrdadTajedini.DesignPatterns.Creational.Singleton
{
    public sealed class ThreadSafeWithDoubleCheckSingleton
    {
        private static ThreadSafeWithDoubleCheckSingleton instance = null;
        private static readonly object padlock = new object();

        ThreadSafeWithDoubleCheckSingleton()
        {
        }

        public static ThreadSafeWithDoubleCheckSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeWithDoubleCheckSingleton();
                        }
                    }
                }
                return instance;
            }
        }

    }
}
