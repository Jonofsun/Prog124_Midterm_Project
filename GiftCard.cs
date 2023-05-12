using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public class GiftCard : Product
    {
        private decimal _amount;

        public GiftCard(string name, decimal price, int points, decimal amount) : base(name, price, points)
        {
            _amount = amount;
        }

        public decimal Amount { get => _amount;}

        public override string ToString()
        {
            return base.ToString() + $" Gift Card, Amount: {Amount:C}";
        }
    }
}
