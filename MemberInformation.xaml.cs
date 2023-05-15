using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prog124_Midterm_Project
{
    /// <summary>
    /// Interaction logic for MemberInformation.xaml
    /// </summary>
    public partial class MemberInformation : Window
    {
        List<Product> _goldProducts;
        List<Product> _regularProduct;
        public MemberInformation()
        {
            InitializeComponent();
            lbMemberInformation.ItemsSource = Data.MemberCollection; lbMemberInformation.SelectedIndex = 0;
        }

        private void btnMembershipAddMembers_Click(object sender, RoutedEventArgs e)
        {
            bool isRegular = rbRegularMember.IsChecked.Value;
            bool isGold = rbGoldMember.IsChecked.Value;
            string fName = txtMembershipFirstN.Text;
            string lName = txtMembershipLastN.Text;

            if ( isRegular )
            {
                Data.AddmemberToCollection(new RegularMember(fName, lName));
            }
            else if( isGold )
            {
                Data.AddmemberToCollection(new GoldMember(fName, lName));
            }
            else { MessageBox.Show("Please select a membership"); }
            lbMemberInformation.ItemsSource = Data.MemberCollection;
        }

        private void lbMemberInformation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = lbMemberInformation.SelectedIndex;
            lbMemberInformation.SelectedIndex = selectedIndex;
            lbMemberInformation.Focus();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            lbMemberInformation.ItemsSource = Data.MemberCollection;
            
            foreach (Member membership in Data.MemberCollection)
            {
                lbMembershipTransactionHistory.ItemsSource = membership.PreviousTransactions;
                break;
            }
        }
    }
}
