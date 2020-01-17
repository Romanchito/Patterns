using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class TestingJob : IJob
    {
        public void DoJob()
        {
            Console.WriteLine("I'm testing");
        }
    }
}
