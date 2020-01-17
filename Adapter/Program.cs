using System;
using Adapter.Agregate_Adapter;
using Adapter.Extend_Adapter;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            AgregateAdapter adapter1 = new AgregateAdapter();
            ExtendAdapter adapter2 = new ExtendAdapter();

            adapter1.CityInfo("London");
            adapter1.CityInfo("Kardiff");
        }
    }
}
