using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_IT
{
    public class Timer : System.Timers.Timer
    {
        public Timer()
        {
            this.Interval = (60 - DateTime.Now.Second) * 1000;
            this.Enabled = true;
        }

        public static string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }

        public static string GetDate()
        {
            return DateTime.Now.ToShortDateString();
        }
    }
}
