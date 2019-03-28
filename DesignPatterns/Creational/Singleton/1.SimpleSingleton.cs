namespace MehrdadTajedini.DesignPatterns.Creational.Singleton
{
    public sealed class SimpleSingleton
    {
        private static SimpleSingleton instance = null;

        private SimpleSingleton()
        {
        }

        public static SimpleSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SimpleSingleton();
                }
                return instance;
            }
        }
    }
}
