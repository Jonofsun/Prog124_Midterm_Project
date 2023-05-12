using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public class RegularMember : Member
    {
        public RegularMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }
        public override void DeductPoints(Product product)
        {
            int pointsDeducted = product.Points;
            if (pointsDeducted <= PointAmount)
            {
                PointAmount -= pointsDeducted;
            }
        }
        public override void AddPoints(Product product)
        {
            int pointsAdded = product.Points;
            pointsAdded += PointAmount;
        }
    }
}
