using Adapter.Interface;
using Adapter.UntouchableClass;
using System;

namespace Adapter.Agregate_Adapter
{
    public class AgregateAdapter : ICity
    {
        private Englishman person = new Englishman();
        public void CityInfo(string city)
        {
            Console.WriteLine($"{person.Say()} I'm from {city}");
        }
    }
}
