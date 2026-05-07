using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace huhuhu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Employees = new ObservableCollection<Employee>();

            DataContext = this;
        }

        public class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Title { get; set; }

            public decimal Salary { get; set; }

            public string Department { get; set; }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtDepartment.Text) ||
                    string.IsNullOrWhiteSpace(txtSalary.Text))
                {
                    MessageBox.Show("Please fill up all fields.");

                    return;
                }

         
                int id;

                if (!int.TryParse(txtID.Text, out id))
                {
                    MessageBox.Show("ID should only contain whole numbers.");

                    txtID.Focus();

                    return;
                }

              
                decimal salary;

                if (!decimal.TryParse(txtSalary.Text, out salary))
                {
                    MessageBox.Show("Salary should only contain decimal numbers.");

                    txtSalary.Focus();

                    return;
                }

               
                Employees.Add(new Employee()
                {
                    Id = id,
                    Name = txtName.Text,
                    Title = txtTitle.Text,
                    Department = txtDepartment.Text,
                    Salary = salary
                });

                MessageBox.Show("Employee added successfully!");

            
                txtID.Clear();
                txtName.Clear();
                txtTitle.Clear();
                txtDepartment.Clear();
                txtSalary.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}