using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public abstract class Food : Product
    {
        public bool IsHeated { get; set; }
        public Food(string name, decimal price, int points, bool isHeated) : base(name, price, points)
        {
            IsHeated = isHeated;
        }
    }
}
