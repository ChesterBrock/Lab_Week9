

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week9
{
    class Program
    {
        static void Main(string[] args)
        {

            // creating a new pizza object
            Pizza pizza1 = new Pizza("small", 2, 2, 2);
            Console.WriteLine(pizza1.toString());

            pizza1.PizzaSize = "medium";
            pizza1.HamTop = 1;
            pizza1.PeppTop = 1;
            pizza1.CheeseTop = 1;

            Console.WriteLine(pizza1.toString());

            Console.ReadLine();
        }
    }
}
