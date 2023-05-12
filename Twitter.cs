using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public class Twitter : Mechandise
    {
        public string Color { get; set; }
        public Twitter(string name, decimal price, int points, string color) : base(name, price, points)
        {
            Color = color;
        }
        public override string ToString()
        {
            return base.ToString() + $", Color: {Color}";
        }
    }
}
