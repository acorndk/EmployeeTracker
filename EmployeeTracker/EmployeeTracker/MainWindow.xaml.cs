using EmployeeTracker.Database;
using EmployeeTracker.ViewModels;
using System.Windows;

namespace EmployeeTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (EmployeeTrackerContext db = new EmployeeTrackerContext())
            {

            }
        }

        private void btnDepartment_Click(object sender, RoutedEventArgs e)
        {
            lblWindowName.Content = "Department List";
            DataContext = new DepartmentViewModel();
        }
    }
}