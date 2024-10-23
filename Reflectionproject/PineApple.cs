using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflectionproject
{
    internal class PineApple:Fruit
    {
        public int VitaminE;
        public int VitaminD;

        public PineApple(int vitaminE, int vitaminD, decimal price, string sort) : base(price, sort)
        {
            VitaminE = vitaminE;
            VitaminD = vitaminD;
        }

        public override void Taste()
        {
            Console.WriteLine("Sour");
        }
    }
}
