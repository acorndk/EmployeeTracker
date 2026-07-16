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
            var list = db.Departments.ToList();
            gridDepartment.ItemsSource = list;
        }
    }
}
