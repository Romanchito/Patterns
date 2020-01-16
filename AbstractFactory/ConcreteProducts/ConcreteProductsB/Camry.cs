using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Camry : ISedan
    {
        public void StartSedan()
        {
            Console.WriteLine("Sedan Camry start");
        }
    }
}
