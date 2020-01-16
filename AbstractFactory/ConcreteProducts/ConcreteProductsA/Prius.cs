using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Prius : IHatchBack
    {
        public void StartHatchBack()
        {
            Console.WriteLine("HatchBack Prius start");
        }
    }
}
