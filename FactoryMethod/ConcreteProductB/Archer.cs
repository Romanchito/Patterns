using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Archer : Warrior
    {
        protected internal override void SetReady()
        {
            Console.WriteLine("Archer is ready");
        }
    }
}
