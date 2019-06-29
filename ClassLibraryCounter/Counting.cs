using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter.ClassLibrary
{
    public class Counting
    {
        public void Count(int countNumber, int interval, Action<int> callback)
        {
            for (int i = 1; i <= countNumber; i++)
            {
                callback(i);
                System.Threading.Thread.Sleep(interval);        
            }
        }
    }
}
