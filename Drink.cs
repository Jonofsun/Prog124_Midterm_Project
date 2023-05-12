using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public abstract class Drink : Product
    {
        public enum DrinkSize { Short, Tall, Grande, Venti, Trenta };
        public DrinkSize Size { get; set; }

        public Drink(string name, decimal price, int points, DrinkSize size) : base(name, price, points)
        {
            Size = size;
        }
    }
}
