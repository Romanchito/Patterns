using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class S60 : ISedan
    {
        public void StartSedan()
        {
            Console.WriteLine("Sedan V60 start");
        }
    }
}
