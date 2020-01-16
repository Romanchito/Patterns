using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        public void TestMethod()
        {
            Console.WriteLine("Test with Toyota factory");
            ClientMethod(new Toyota());
            Console.WriteLine();

            Console.WriteLine("Test with Volvo factory");
            ClientMethod(new Volvo());
            Console.WriteLine();
        }

        private void ClientMethod(ICarManagerFactory carManagerFactory)
        {
            var sedan = carManagerFactory.CreateSedan();
            var hatchback = carManagerFactory.CreateHatchBack();

            sedan.StartSedan();
            hatchback.StartHatchBack();
        }
    }
}
