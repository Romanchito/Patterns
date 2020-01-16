using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Casern : Building
    {
        public override Warrior CreateWarrior()
        {
            Console.Write("Casern: ");
            return new Gladiator();
        }
    }
}
