using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace WPFQ017
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Employee employee1 = new Employee { Name = "员工1" };
            Employee employee2 = new Employee { Name = "员工2" };
            Employee employee3 = new Employee { Name = "员工3" };
            Employee employee4 = new Employee { Name = "员工4" };
            Employee employee5 = new Employee { Name = "员工5" };
            Employee employee6 = new Employee { Name = "员工6" };
            Employee employee7 = new Employee { Name = "员工7" };

            Department department1 = new Department();
            department1.Name = "部门1";
            department1.Employees = new List<Employee>();
            department1.Employees.Add(employee1);
            department1.Employees.Add(employee2);
            department1.Employees.Add(employee3);
           

            Department department2 = new Department();
            department2.Name = "部门1";
            department2.Employees = new List<Employee>();
            department2.Employees.Add(employee4);
            department2.Employees.Add(employee4);
            department2.Employees.Add(employee6);
            department2.Employees.Add(employee7);

            Company company = new Company();
            company.Name = "公司1";
            company.Departments = new List<Department>();
            company.Departments.Add(department1);

            List<Company> companies = new List<Company>();
            companies.Add(company);
            companies.Add(company);
            companies.Add(company);

            tree1.ItemsSource = companies;

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Company>));
            //FileStream fs = new FileStream("Company.xml",FileMode.Create);
            //xmlSerializer.Serialize(fs, companies);
        }
    }
}
