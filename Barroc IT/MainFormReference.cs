using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_IT
{
    public class MainFormReference // Singleton https://en.wikipedia.org/wiki/Singleton_pattern 
    {
        private static MainScreen instance;
        private static readonly object padlock = new object();

        public MainFormReference()
        {

        }

        public static MainScreen Main // houd reference vast
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MainScreen();
                    }
                    return instance;
                }                
            }
        }        
    }
}
