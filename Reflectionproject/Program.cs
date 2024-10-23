using Microsoft.VisualBasic.FileIO;
using System.Reflection;

namespace Reflectionproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(100, 70, 4, "Red apple");
            Orange orange = new Orange(130, 5, "Grapefruit");
            PineApple pineapple = new PineApple(60, 120, 10, "Smooth Cayenna");



            Fruit[] fruits = { apple, orange, pineapple };

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine("--------------");
                Type type = fruit.GetType();
                Console.WriteLine(type.Name);


                FieldInfo[] fields = type.GetFields();
                foreach (var field in fields)
                {
                    var value = field.GetValue(fruit);
                    Console.WriteLine($"{field.Name}:{value}");
                }
            }
        }
            
        
    }
}