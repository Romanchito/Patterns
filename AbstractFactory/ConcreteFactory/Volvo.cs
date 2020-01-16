using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Volvo : ICarManagerFactory
    {
        public IHatchBack CreateHatchBack()
        {
            return new V40();
        }

        public ISedan CreateSedan()
        {
            return new S60();
        }
    }
}
