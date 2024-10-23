using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflectionproject
{
    internal class Orange : Fruit
    {
        public int VitaminC;

        public Orange(int vitaminC, decimal price, string sort) : base(price, sort)
        {
            VitaminC = vitaminC;
        }

        public override void Taste()
        {
            Console.WriteLine("Sour-Sweet");
        }
    }
}
