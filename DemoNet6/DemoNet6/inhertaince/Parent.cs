using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.inhertaince
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("parent");
        }
         public int GetProduct()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"X={X},Y={Y}";
        }
    }
}
