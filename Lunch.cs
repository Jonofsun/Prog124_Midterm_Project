using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public class Lunch : Food
    {
        public bool IsCombo { get; set; }
        public Lunch(string name, decimal price, int points, bool isHeated, bool isCombo) : base(name, price, points, isHeated)
        {
            IsCombo = isCombo;
        }
        public override string ToString()
        {
            return base.ToString() + $", Is Combo: {IsCombo}";
        }
    }
}
