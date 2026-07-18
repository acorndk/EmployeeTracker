using EmployeeTracker.Database;
using System.Windows;

namespace EmployeeTracker
{
    /// <summary>
    /// Interaction logic for DepartmentPage.xaml
    /// </summary>
    public partial class DepartmentPage : Window
    {
        public DepartmentPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtDepartmentName.Text.Trim() == "")
                MessageBox.Show("Please fill the Department Name field");
            else
            {
                using EmployeeTrackerContext db = new();
                Department department = new Department();
                department.Name = txtDepartmentName.Text;
                db.Departments.Add(department);
                db.SaveChanges();
                txtDepartmentName.Clear();
                MessageBox.Show("Department was added successfully");
            }
        }
    }
}
