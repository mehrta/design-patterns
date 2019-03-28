namespace MehrdadTajedini.DesignPatterns.Creational.Singleton
{
    public sealed class StaticFieldSingleton
    {
        private static readonly StaticFieldSingleton instance = new StaticFieldSingleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static StaticFieldSingleton()
        {
        }

        private StaticFieldSingleton()
        {
        }

        public static StaticFieldSingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
