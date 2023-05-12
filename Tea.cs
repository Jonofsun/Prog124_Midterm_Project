using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public class Tea : Drink
    {
        public string TeaType { get; set; }
        public Tea(string name, decimal price, int points, DrinkSize size, string teaType) : base(name, price, points, size)
        {
            TeaType = teaType;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tea Type: {TeaType}";
        }
    }
}
