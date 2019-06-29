using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter.ClassLibrary
{
    public class Counting
    {
        public static int currentNumber;
        public void Count(int countNumber, int interval, Action callback)
        {
            for (int i = 1; i <= countNumber; i++)
            {
                currentNumber = i;
                callback();
                System.Threading.Thread.Sleep(interval);        
            }
        }
    }
}
