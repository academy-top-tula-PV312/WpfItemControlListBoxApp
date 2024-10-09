using System.Text;
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

namespace WpfItemControlListBoxApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employee> employees;
        public MainWindow()
        {
            InitializeComponent();

            //list = new ListBox();
            //list.FontSize = 30;
            //list.Items.Add("Tommy");

            //ListBoxItem item = new ListBoxItem();
            //item.Content = "Bobby";
            //list.Items.Add(item);

            //list.Items.Insert(0, "Jimmy");

            //list.SelectionChanged += List_SelectionChanged;

            //grid.Children.Add(list);

            //employees.Items.Add(new Employee() { Name = "Denny", Age = 25 });

            //employees = new List<Employee>()
            //{
            //    new(){ Name = "Jimmy", Age = 45 },
            //    new(){ Name = "Lenny", Age = 27 },
            //    new(){ Name = "Sonny", Age = 32 },
            //};

            //listEmployees.ItemsSource = employees;
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //list.Items.Remove(list.SelectedItem);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee employeeNew = new() { Name = txtName.Text, Age = Int32.Parse(txtAge.Text) };
            employees.Add(employeeNew);

            txtName.Text = "";
            txtAge.Text = "";

            //string message = "";
            //foreach(var empl in employees)
            //    message += empl.ToString() + "\n";
            //MessageBox.Show(message);

            listEmployees.Items.Refresh();
        }
    }
}