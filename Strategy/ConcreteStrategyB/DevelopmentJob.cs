using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class DevelopmentJob : IJob
    {
        public void DoJob()
        {
            Console.WriteLine("I'm developing");
        }
    }
}
