using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflectionproject
{
    internal class Apple:Fruit
    {
        public int VitaminA;
        public int VitaminB;

        public Apple(int vitaminA, int vitaminB, decimal price, string sort) : base(price, sort)
        {
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }
        public override void Taste()
        {
            Console.WriteLine("Sweet");
        }
    }
}
