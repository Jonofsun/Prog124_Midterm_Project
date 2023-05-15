using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prog124_Midterm_Project
{
    /// <summary>
    /// Interaction logic for AddNewProductPage.xaml
    /// </summary>
    public partial class AddNewProductPage : Window
    {
        //private MainWindow _mainWindow;

        //public AddNewProductPage(MainWindow mainWindow)
        //{
        //    _mainWindow = mainWindow;
        //}

        //public void UpdateListBox(MainWindow mainWindow)
        //{
        //    mainWindow.UpdateListbox(Data.ProductCollection);
        //}
        // I was trying to get the Main list box to update automaticly, I was unable to figure it out
        public AddNewProductPage()
        {
            InitializeComponent();
            PopulateSizeComboBox();
            lbProductDisplay.ItemsSource = Data.ProductCollection; lbProductDisplay.SelectedIndex = 0;
            
        }
        void PopulateSizeComboBox()
        {
            cmbProductSize.Items.Add("Short");
            cmbProductSize.Items.Add("Tall");
            cmbProductSize.Items.Add("Grande");
            cmbProductSize.Items.Add("Trenta");
            cmbProductSize.SelectedIndex = 0;
        }

        private void btnProductCoffee_Click(object sender, RoutedEventArgs e)
        {
            Coffee.DrinkSize drinkSize = (Coffee.DrinkSize)cmbProductSize.SelectedIndex;
            string name = txtProductName.Text;
            decimal price = decimal.Parse(txtProductPrice.Text);
            int points = int.Parse(txtProductPoint.Text);
            List<Product> products = new List<Product>();
            Data.AddProductToCollection(new Coffee(name, price, points, drinkSize, "roast"));
            lbProductDisplay.ItemsSource = Data.ProductCollection;
        }

        private void btnProductTea_Click(object sender, RoutedEventArgs e)
        {
            Tea.DrinkSize drinkSize =(Tea.DrinkSize)(cmbProductSize.SelectedIndex);
            string name = txtProductName.Text;
            decimal price = decimal.Parse(txtProductPrice.Text);
            int points = int.Parse(txtProductPoint.Text);

            Data.AddProductToCollection(new Tea(name, price, points, drinkSize, "tea"));
            lbProductDisplay.ItemsSource = Data.ProductCollection;
        }

        private void btnProductBreakfast_Click(object sender, RoutedEventArgs e)
        {
            bool isCheckedHeated = ckbIsHeated.IsChecked.Value;
            bool isCheckedCombo = ckbIsDairyOrCombo.IsChecked.Value;

            string name = txtProductName.Text;
            decimal price = decimal.Parse(txtProductPrice.Text);
            int points = int.Parse(txtProductPoint.Text);

            Data.AddProductToCollection(new Breakfast(name, price, points, isCheckedHeated, isCheckedCombo));
            lbProductDisplay.ItemsSource = Data.ProductCollection;
        }

        private void btnProductLunch_Click(object sender, RoutedEventArgs e)
        {
            bool isCheckedHeated = ckbIsHeated.IsChecked.Value;
            bool isCheckedCombo = ckbIsDairyOrCombo.IsChecked.Value;

            string name = txtProductName.Text;
            decimal price = decimal.Parse(txtProductPrice.Text);
            int points = int.Parse(txtProductPoint.Text);

            Data.AddProductToCollection(new Lunch(name, price, points, isCheckedHeated, isCheckedCombo));
            lbProductDisplay.ItemsSource = Data.ProductCollection;
        }

        private void btnTwitter_Click(object sender, RoutedEventArgs e)
        {
            string color = txtColorOrStyle.Text;
            string name = txtProductName.Text;
            decimal price = decimal.Parse(txtProductPrice.Text);
            int points = int.Parse(txtProductPoint.Text);
            Data.AddProductToCollection(new Twitter(name, price, points, color));
            lbProductDisplay.ItemsSource = Data.ProductCollection;
        }

        private void btnMug_Click(object sender, RoutedEventArgs e)
        {
            string color = txtColorOrStyle.Text;
            string name = txtProductName.Text;
            decimal price = decimal.Parse(txtProductPrice.Text);
            int points = int.Parse(txtProductPoint.Text);
            Data.AddProductToCollection(new Mugs(name, price, points, color));
            lbProductDisplay.ItemsSource = Data.ProductCollection;
            
        }

        private void btnGiftCard_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = decimal.Parse(txtProductAmount.Text);
            string name = txtProductName.Text;
            decimal price = decimal.Parse(txtProductPrice.Text);
            int points = int.Parse(txtProductPoint.Text);
            Data.AddProductToCollection(new GiftCard(name, price, points, amount));
            lbProductDisplay.ItemsSource = Data.ProductCollection;
        }
    }
}
