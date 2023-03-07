using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.Interface
{
    internal interface ISeries
        {
             int Current{ get; }
             void GetNext();
             void Reset();

             }

    class SeriesByTwo : ISeries
    {
        private int current;

        public int Current {
           get { return current; }
            set { current = value; }
        }

        public void GetNext()
        {
            current += 2;
        }

        public void Reset()
        {
            current = 0;
        }
    }

    class SeriesByThree : ISeries
    {
        private int current;

        public int Current
        {
            get { return current; }
            set { current = value; }
        }

        public void GetNext()
        {
            current += 3;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
