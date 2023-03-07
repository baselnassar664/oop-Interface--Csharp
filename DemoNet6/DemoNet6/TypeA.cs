using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6
{
    internal class TypeA
    {
        public int A{ get; set; }

        
        public TypeA(int _a) {
            A = _a;
        }
       
        public void StaticBindedShow()
        {
            Console.WriteLine("Iam Parent");

        }

        public virtual void DynamimcBindedShow()
        {

            Console.WriteLine(A);
        }


    }

}
