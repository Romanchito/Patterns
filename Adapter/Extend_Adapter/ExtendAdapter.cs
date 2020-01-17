using Adapter.Interface;
using Adapter.UntouchableClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Extend_Adapter
{
    public class ExtendAdapter : Englishman, ICity
    {
        public void CityInfo(string city)
        {
            Console.WriteLine($"{this.Say()}, I'm living in {city}");
        }
    }
}
