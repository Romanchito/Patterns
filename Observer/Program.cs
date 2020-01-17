using System;

namespace Observer
{
    
    class Program
    {
      
        static void Main(string[] args)
        {
            var subject = new Subject();
            var russian = new RussianObserver();
            var egyptian = new EgyptObserver();

            subject.Attach(russian);
            subject.Attach(egyptian);

            subject.Notify();
            subject.Notify();
            subject.Notify();

            subject.Remove(egyptian);

            subject.Notify();
            subject.Notify();
        }
        
    }
}
