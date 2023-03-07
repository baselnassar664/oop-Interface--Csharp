using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.Interface
{
    internal interface IType
        {
        //defult access modifer in interface is public
        // you can not use private access modifer
        //what inside interface ?
        //1>>signature for proprety
        //2>>signature for methode
        //3>>deflut implemented methode

        //signature for proprety
        double Salary { get; set; }


        //signature for methode
         void Print();

        //3>>deflut implemnted methode
        void Printt(){
            Console.WriteLine("z");
    
             }
    }
    class MyType : IType
    {
          private double salary;
        public double Salary {
                get { return salary; }
                set { salary = value; }
            
            }

        public void Print()
        {
            Console.WriteLine("hello from mYType");
        }
    }
}
