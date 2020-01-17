using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Programmer
    {        
        public void Working(IJob job)
        {
            if(job != null)
            {
                job.DoJob();
            }
        }
    }
}
