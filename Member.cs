using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Midterm_Project
{
    public abstract class Member
    {
        private int _memberNumber;
        private ObservableCollection<Product> _previousTransactions;

        public string FirstName { get; }
        public string LastName { get; }
        public int MemberNumber { get { return _memberNumber; } }
        public int PointAmount { get; set; }
        public DateTime MemberSince { get; }
        public ObservableCollection<Product> PreviousTransactions { get => _previousTransactions; }

        public Member(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Random random = new Random();
            _memberNumber = random.Next(1000000, 10000000);

            PointAmount = 0;
            MemberSince = DateTime.Now;
            _previousTransactions = new ObservableCollection<Product>(); // This could be an issue Noting this down
        }
        public abstract void DeductPoints(Product product);

        public abstract void AddPoints(Product product);

        public void AddProduct(Product product)
        {
            _previousTransactions.Add(product);
        }
        public override string ToString()
        {
            return $"{GetType().Name} - {FirstName} {LastName} - Points ({PointAmount}) - Member Number ({MemberNumber})";
        }
    }
}
