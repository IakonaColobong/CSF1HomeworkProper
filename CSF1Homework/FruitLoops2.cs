using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoops2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loop Project");
            //Console.ReadLine();
            string add = "";
            string[] fruits = new string[6];
            fruits[0] = "guava";
            fruits[1] = "lychee";
            fruits[2] = "mango";
            fruits[3] = "ulu";
            fruits[4] = "lilikoi";
            fruits[5] = "pineapple";

            Console.WriteLine("Island Fruits:");
            for (int i = fruits.GetLowerBound(0); i <= fruits.GetUpperBound(0); i++)
            {
                Console.WriteLine(fruits[i]);

                Console.WriteLine(add);
                add += ".";
            }

        }
    }
}
