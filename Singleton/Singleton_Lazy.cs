using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton_Lazy
    {
        private static readonly Lazy<Singleton_Lazy> _instance =
            new Lazy<Singleton_Lazy>(() => new Singleton_Lazy());

        private Singleton_Lazy()
        {

        }

        public static Singleton_Lazy Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
