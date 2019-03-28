namespace MehrdadTajedini.DesignPatterns.Creational.Singleton
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = null;
        private static readonly object syncLock = new object();

        ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                    return instance;
                }
            }
        }
    }

}
