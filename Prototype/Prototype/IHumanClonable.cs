using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IHumanClonable
    {
        IHumanClonable Clone();
        void GetHumanInfo();
    }
}
