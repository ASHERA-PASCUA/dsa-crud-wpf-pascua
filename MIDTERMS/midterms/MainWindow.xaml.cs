using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;
using static midterms.MainWindow;

namespace midterms
{
    /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
 public partial class MainWindow : Window
 {
     public ObservableCollection<Product> Products { get; set; }

     public MainWindow()
     {
         InitializeComponent();

         Products = new ObservableCollection<Product>();

         DataContext = this;
     }

     public class Product
     {
         public int ProductId { get; set; }

         public string ProductName { get; set; }

         public string Description { get; set; }

         public decimal Price { get; set; }
            public int Productid { get; set; }

            public string Productname { get; set; }

            public string Descriptions { get; set; }

            public decimal Prices { get; set; }


        }


        private void Add_Click(object sender, RoutedEventArgs e)
     {
         try
         {

             if (string.IsNullOrWhiteSpace(txtProductID.Text) ||
                 string.IsNullOrWhiteSpace(txtProductName.Text) ||
                 string.IsNullOrWhiteSpace(txtDescription.Text) ||
                 string.IsNullOrWhiteSpace(txtPrice.Text))
             {
                 MessageBox.Show("Please fill up all fields.");

                 return;
             }


             int id;

             if (!int.TryParse(txtProductID.Text, out id))
             {
                 MessageBox.Show("ID should only contain whole numbers.");

                 txtProductID.Focus();

                 return;
             }

             Products.Add(new Product()
             {
                 ProductId = id,
                 ProductName = txtProductName.Text,
                 Description = txtDescription.Text,
                 Price = txtPrice.Text
             });

             MessageBox.Show("Employee added successfully!");


             txtProductID.Clear();
             txtProductName.Clear();
             txtDescirption.Clear();
             txtPrice.Clear();
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error: " + ex.Message);
         }
     }

     private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
     {

     }
 }

    public ObservableCollection<Product> Products { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        Products = new ObservableCollection<Product>();

        DataContext = this;
    }

    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }


    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
        try
        {

            if (string.IsNullOrWhiteSpace(txtProductID.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill up all fields.");

                return;
            }


            int id;

            if (!int.TryParse(txtProductID.Text, out id))
            {
                MessageBox.Show("ID should only contain whole numbers.");

                txtProductID.Focus();

                return;
            }

            Products.Add(new Product()
            {
                ProductId = id,
                ProductName = txtProductName.Text,
                Description = txtDescription.Text,
                Price = txtPrice.Text
            });

            MessageBox.Show("Employee added successfully!");


            txtProductID.Clear();
            txtProductName.Clear();
            txtDescirption.Clear();
            txtPrice.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}

}

