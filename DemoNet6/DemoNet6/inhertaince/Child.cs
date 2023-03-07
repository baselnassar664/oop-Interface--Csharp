using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.inhertaince
{
    internal class Child:Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y) //constrouctor charing in inhertaince refer to parent constrouctor
        {
            Z = z;
            Console.WriteLine("child");
        }

        public override string ToString()
        {
            return $"x={X},y={Y},Z={Z}";
        }

        public new int GetProduct() //override method by new >>override change body for methode
        {
            return X * Y * Z;
        }

    }
}
