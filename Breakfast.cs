using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public class Breakfast : Food
    {
        public bool HasDairy { get; set; }
        public Breakfast(string name, decimal price, int points, bool isHeated, bool hasDairy) : base(name, price, points, isHeated)
        {
            HasDairy = hasDairy;
        }
        public override string ToString()
        {
            return base.ToString() + $", Has Dairy: {HasDairy}";
        }
    }
}
