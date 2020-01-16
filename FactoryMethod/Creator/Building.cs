using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Building
    {
        public abstract Warrior CreateWarrior();
    }
}
