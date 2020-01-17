using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class EgyptObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject == null) throw new ArgumentNullException(nameof(subject));
           if((subject as Subject).Temperature < 10)
            {
                Console.WriteLine("EgyptObserver cold weather");
            }

            if ((subject as Subject).Temperature > 17 && (subject as Subject).Temperature < 30)
            {
                Console.WriteLine("EgyptObserver warm weather");
            }

            if ((subject as Subject).Temperature > 38)
            {
                Console.WriteLine("EgyptObserver hot weather");
            }
        }
    }
}
