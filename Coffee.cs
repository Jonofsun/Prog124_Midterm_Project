using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public class Coffee : Drink
    {
        public string Roast { get; set; }

        public Coffee(string name, decimal price, int points, DrinkSize size, string roast) : base(name, price, points, size)
        {
            Roast = roast;
        }

        public override string ToString()
        {
            return base.ToString() + $", Roast: {Roast}";
        }
    }
}
