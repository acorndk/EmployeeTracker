using EmployeeTracker.Database;
using System.Windows.Controls;

namespace EmployeeTracker.Views
{
    /// <summary>
    /// Interaction logic for DepartmentList.xaml
    /// </summary>
    public partial class DepartmentList : UserControl
    {
        public DepartmentList()
        {
            InitializeComponent();

            using EmployeeTrackerContext db = new();
            var list = db.Departments.OrderBy(x => x.Name).ToList();
            gridDepartment.ItemsSource = list;
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DepartmentPage page = new DepartmentPage();
            page.ShowDialog();

            using EmployeeTrackerContext db = new();
            var list = db.Departments.OrderBy(x => x.Name).ToList();
            gridDepartment.ItemsSource = list;
        }
    }
}
