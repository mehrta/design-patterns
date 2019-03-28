using System;

namespace MehrdadTajedini.DesignPatterns.Creational.Singleton
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton());
        public static LazySingleton Instance
        {
            get { return lazy.Value; }
        }

        private LazySingleton()
        {
        }
    }
}
