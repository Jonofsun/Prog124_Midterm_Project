using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public abstract class Mechandise : Product
    {
        protected Mechandise(string name, decimal price, int points) : base(name, price, points)
        {
        }
    }
}
