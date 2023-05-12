using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public class GoldMember : Member
    {
        public GoldMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }
        public override void DeductPoints(Product product)
        {
            int pointsDeducted = (product.Points / 2) - 50;
            if (pointsDeducted < 0)
            {
                pointsDeducted += 0;
            }
            pointsDeducted -= pointsDeducted;
        }
        public override void AddPoints(Product product)
        {
            PointAmount += product.Points + 50;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Gold Member";
        }
    }
}
