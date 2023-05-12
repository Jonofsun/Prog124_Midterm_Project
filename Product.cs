using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Sku { get; set; }
        public decimal Price { get; set; }
        public int Points { get; set; }
        public static int NumberOfProducts { get; set; }

        public Product(string name, decimal price, int points)
        {
            Name = name;
            Price = price;
            Points = points;

            Random random = new Random();
            Sku = random.Next(1000000, 10000000);

            NumberOfProducts++;
        }
        public override string ToString()
        {
            return $"{GetType().Name}: SKU {Sku}, Name: {Name}, Price: {Price:C}, Points: {Points}";
        }
    }
}
