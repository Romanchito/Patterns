using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ShootingRange : Building
    {
        public override Warrior CreateWarrior()
        {
            Console.Write("ShootingRange: ");
            return new Archer();
        }
    }
}
