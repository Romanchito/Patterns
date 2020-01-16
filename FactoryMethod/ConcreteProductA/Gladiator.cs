using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Gladiator : Warrior
    {
        protected internal override void SetReady()
        {
            Console.WriteLine("Gladiator is ready");
        }
    }
}
