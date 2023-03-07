using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6
{
    internal class typeB:TypeA
    {
        public int B { get; set; }
        public typeB(int _a,int _B) : base(_a)
        {
            B= _B;
        }
        //override with new
        public new void StaticBindedShow()
        {
            Console.WriteLine("Iam child");

        }
        //override with virtual
        public override void DynamimcBindedShow()
        {
            Console.WriteLine($"{A},{B}");
        }

    }
}
