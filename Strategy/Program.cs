using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer tester = new Programmer();            

            tester.Working(new TestingJob());
            tester.Working(new DevelopmentJob());
        }
    }
}
