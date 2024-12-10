using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassLibrary {

    public class LearnClass
    {
        public int TimeInSeconds(int a, int b) 
        {
            return a * 3600 + b * 60;
        }

        public void SecondInHoursAndMinuts(int sec, out int hr, out int min)
        {
            hr = sec / 3600;
            min = (sec % 3600) / 60;
        }
    } 
}
