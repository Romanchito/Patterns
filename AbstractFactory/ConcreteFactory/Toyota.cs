using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Toyota : ICarManagerFactory
    {
        public IHatchBack CreateHatchBack()
        {
            return new Prius();
        }

        public ISedan CreateSedan()
        {
            return new Camry();
        }
    }
}
