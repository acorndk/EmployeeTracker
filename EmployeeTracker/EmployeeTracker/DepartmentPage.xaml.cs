using EmployeeTracker.Database;
using System.Windows;

namespace EmployeeTracker
{
    /// <summary>
    /// Interaction logic for DepartmentPage.xaml
    /// </summary>
    public partial class DepartmentPage : Window
    {
        public Department department;

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

                if (department != null && department.Id != 0)
                {
                    Department update = new Department();
                    update.Name = txtDepartmentName.Text;
                    update.Id = department.Id;
                    db.Departments.Update(update);
                    db.SaveChanges();
                    MessageBox.Show("Department was updated successfully");
                }
                else
                {
                    Department department = new Department();
                    department.Name = txtDepartmentName.Text;
                    db.Departments.Add(department);
                    db.SaveChanges();
                    txtDepartmentName.Clear();
                    MessageBox.Show("Department was added successfully");
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (department != null && department.Id != 0)
            {
                txtDepartmentName.Text = department.Name;
            }
        }
    }
}
