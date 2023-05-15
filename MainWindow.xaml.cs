using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog124_Midterm_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Jonathan Reed
    /// Programming 124
    /// Midterm - coffee store app
    /// 5/14/23
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            lbMainProducts.ItemsSource = Data.ProductCollection; lbMainProducts.SelectedIndex = 0;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNewProductPage productPage = new AddNewProductPage();
            productPage.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MemberInformation memberInformation = new MemberInformation();
            memberInformation.Show();
        }

        private void btnRefreash_Click(object sender, RoutedEventArgs e) // this is here because, my main display does not update automaticly
        {
            lbMainProducts.ItemsSource = Data.ProductCollection;
            cmbMainMembershipInformation.ItemsSource = Data.MemberCollection;
        }
        public void UpdateListbox(IEnumerable<Product> products) { lbMainProducts.ItemsSource = Data.ProductCollection; } // An atempt to update the listbox as each item is added, not working

        private void btnMainBuyProduct_Click(object sender, RoutedEventArgs e)
        {
            int currentMemberPosition = cmbMainMembershipInformation.SelectedIndex;
            int currentMembershipID = 0;
            //MessageBox.Show(currentMemberNum.ToString());
            //for (int i = 0; i < cmbMainMembershipInformation.Items.Count; i++)
            //{
            //    cmbMainMembershipInformation.Items.;
            //}
            foreach (Member membership in cmbMainMembershipInformation.Items)
            {
                int count = 0;
                if (count == currentMemberPosition)
                {
                    currentMembershipID = membership.MemberNumber;
                    //Data.CurrentMember.AddProduct();
                    Product buyProduct = (Product)(lbMainProducts.SelectedItem);
                    membership.AddProduct(buyProduct);
                    membership.AddPoints(buyProduct);
                    lbMainReceipt.ItemsSource = membership.PreviousTransactions;
                    break;
                }
                //lbMainProducts.SelectedIndex = 0;
                //Product addProduct = Data.CurrentProduct;
                //int selectedIndex = membership.MemberNumber;
                //string currentMember = membership;
                //addProduct = lbMainProducts.SelectedIndex;
                //Data.CurrentMember.AddProduct(addProduct);
                //MessageBox.Show(selectedIndex.ToString());

                //Data.CurrentMember currentMember
                //var product = membership as Product;
                
                count++;
            }
            //int selectedIndex = cmbMainMembershipInformation.SelectedIndex;
            //Data.MemberCollection = cmbMainMembershipInformation.Items[selectedIndex];
            //cmbMainMembershipInformation.SelectedIndex = selectedIndex;

            //lbMainProducts.Items.
            //Product product = (Product)(lbMainProducts.Items[selectedIndex]);
            //Data.CurrentMember.AddProduct(product);

            //lblUserPoints.Content = Member.
        }

        private void btnMainPurchaseWithPoints_Click(object sender, RoutedEventArgs e)
        {
            int currentMemberPosition = cmbMainMembershipInformation.SelectedIndex;
            int currentMembershipID = 0;
            foreach (Member membership in cmbMainMembershipInformation.Items)
            {
                int count = 0;
                if (count == currentMemberPosition)
                {
                    currentMembershipID = membership.MemberNumber;
                    Product buyProduct = (Product)(lbMainProducts.SelectedItem);
                    membership.AddProduct(buyProduct);
                    membership.DeductPoints(buyProduct);
                    lbMainReceipt.ItemsSource = membership.PreviousTransactions;
                    break;
                }

                count++;
            }
        }
    }
}
