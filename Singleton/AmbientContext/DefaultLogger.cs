using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.AmbientContext
{
    internal class DefaultLogger : ILogger
    {
        public void Write()
        {
            Console.WriteLine("Default Logger");
        }
    }
}
