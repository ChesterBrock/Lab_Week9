/// Chapter No. 9		Exercise No. 1
/// File Name: Pizza.cs
/// @author: Chester Brock 
/// Date:  Nov 19, 2021
///
/// Problem Statement: Create a class named Pizza that stores information about a single pizza
/// 
/// 
/// Overall Plan:
/// 1) Create a class named Pizza 
/// 2) Private instance variables to store the size of the pizza (either small, medium, or large
/// 3) Constructors that set all instance variables.
/// 4) Public methods to do get and set the instance variables.
/// 5) A public method named CalculateCost() that returns a double that is the cost of the pizza.
/// 6) Override the ToString method that returns the pizza size, quantity of each topping and the pizza cost as calculated by the calcCost method.
/// 7)Write a program (in the main) to test all the methods in your class definition.
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week9
{
    class Pizza
    {
        // instance variables 
        private String pizzaSize;
        private int cheeseTop;
        private int peppTop;
        private int hamTop;

        // full constructor 
        public Pizza(String pizzaSize, int cheeseTop, int peppTop, int hamTop)
        {
            this.PizzaSize = pizzaSize;
            this.CheeseTop = cheeseTop;
            this.PeppTop = peppTop;
            this.HamTop = hamTop;
        }


        // get and set methods 
        public string PizzaSize { get => pizzaSize; set => pizzaSize = value; }
        public int CheeseTop { get => cheeseTop; set => cheeseTop = value; }
        public int PeppTop { get => peppTop; set => peppTop = value; }
        public int HamTop { get => hamTop; set => hamTop = value; }

        //methods
        public double CalculateCost()
        {
            double cost = (this.cheeseTop * 2) + (this.peppTop * 2) + (this.hamTop *2);
            if (this.pizzaSize.Equals("small"))
            {
                cost += 10.00;
            }
            else if (this.pizzaSize.Equals("medium"))
            {
                cost += 12.00;
            }
            else if(this.pizzaSize.Equals("large")){
                cost += 14.00;
            }
            else
            {
                Console.WriteLine("Not value input.");
            }
            return cost;
        }

        // toString 
        public String toString()
        {
            return "Pizza Size [ " + this.pizzaSize + " ] Cheese top [ " + this.cheeseTop + " ] pepperoni top [ " + this.peppTop + " ] Ham top [ " + this.hamTop + " ] Pizza cost [ $" + this.CalculateCost() + " ] ";
        }
    }
}
