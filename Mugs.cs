using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public class Mugs : Mechandise
    {
        public string Design { get; set; }
        public Mugs(string name, decimal price, int points, string design) : base(name, price, points)
        {
            Design = design;
        }
        public override string ToString()
        {
            return base.ToString() + $" Mug Design {Design}";
        }
    }
}
