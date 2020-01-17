using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class RussianObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject == null) throw new ArgumentNullException(nameof(subject));
            if ((subject as Subject).Temperature < -25)
            {
                Console.WriteLine("RussianObserver cold weather");
            }

            if ((subject as Subject).Temperature > 10 && (subject as Subject).Temperature < 28)
            {
                Console.WriteLine("RussianObserver warm weather");
            }

            if ((subject as Subject).Temperature > 30)
            {
                Console.WriteLine("RussianObserver hot weather");
            }
        }
    }
}
