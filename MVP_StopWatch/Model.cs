using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVP_StopWatch
{
    public class Model
    {
        private int s;

        public string Tick()
        {
            s++;
            return s > 60 ? (s/60) + " мин" + " сек" : s.ToString();
        }

        public void Reset()
        {
            s = 0;
        }
    }
}