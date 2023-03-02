using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Human_resources
{
    public partial class AddEditEmployee : Form
    {
        private int _employeeID;
        private Employee _employee;
        private List<Group> _groups;

        private FileHelper<List<Employee>> _file = new FileHelper<List<Employee>>(Program.FilePath);

        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            _employeeID = id;

            _groups = HiredHelper.IsEmployeeWorking("Brak");


        }

        private void GetEmployeeData()
        {
            if (_employeeID != 0 )
            {

            }
        }

        private void FillTextBoxes()
        {
            tbID.Text = _employee.ID.ToString();
            tbFirstName.Text = _employee.FirstName.ToString();
            tbLastName.Text = _employee.LastName.ToString();
            tbDepartment.Text = _employee.Department.ToString();
            tbTitle.Text = _employee.Title.ToString();
            

        }

        private void AddNewUserToList(List<Employee> students)
        {
            var employee = new Employee
            {
                ID = _employeeID,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Department = tbDepartment.Text,
                Title = tbTitle.Text,
                DateStart = dtpStart.Bottom,
                //Hired = (cmbHired.SelectedIndex as Group).IdGroup,
                DateEnd = dtpFinish.Bottom
            };
            students.Add(employee);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AssignIdToNewEmployee(List<Employee> employees)
        {
            var studentWithHighestId = employees.OrderByDescending(x => x.ID).FirstOrDefault();

            _employeeID = studentWithHighestId == null ? 1 : studentWithHighestId.ID + 1;
        }

        private void bntConfirm_Click(object sender, EventArgs e)
        {
            var employees = _file.DeserialazeFromFile();

            if (_employeeID != 0)
            {
                employees.RemoveAll(x => x.ID == _employeeID);
            }
            else
            {
                AssignIdToNewEmployee(employees);
            }

            AddNewUserToList(employees);
            _file.SerializeToFile(employees);

            Close();

        }
    }
}
