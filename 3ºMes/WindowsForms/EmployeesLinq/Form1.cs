using EmployeesLinq.Daos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesLinq
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetAllEmployees();
        }




        //
        private void GetAllEmployees()
        {
            employeesListBox.Items.Clear();
            employeesListBox.Items.AddRange(EmployeesDao.GetAllEmployees().ToArray());
        }



        //Events
        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            int? departmentId = null;
            int? managerId = null;

            //Validate optional parameters
            if (!String.IsNullOrWhiteSpace(cDepartmentIdTextBox.Text))
                departmentId = Int32.Parse(cDepartmentIdTextBox.Text);

            if (!String.IsNullOrWhiteSpace(cManagerIdTextBox.Text))
                managerId = Int32.Parse(cManagerIdTextBox.Text);

            Daos.EmployeesDao.TryInsertEmployee(
                cNameTextBox.Text,
                cSurnamesTextBox.Text,
                cMailTextBox.Text,
                cPhoneTextBox.Text,
                Int32.Parse(cJobIdTextBox.Text),
                decimal.Parse(cSalaryTextBox.Text),
                departmentId,
                managerId);
        }


    }
}
