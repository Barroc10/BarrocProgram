using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_IT
{
    public class MainFormReference
    {
        private static MainScreen instance;
        private static readonly object o = new object();

        public MainFormReference()
        {

        }

        public static MainScreen Main // houd reference vast
        {
            get
            {
                lock (o)
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
