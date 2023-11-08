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

        //Update forms
        private void GetAllEmployees()
        {
            employeesListBox.Items.Clear();
            employeesListBox.Items.AddRange(EmployeesDao.GetAllEmployees().ToArray());
        }

        private void GetFilteredEmployees()
        {
            employeesListBox.Items.Clear();

            //Validate data
            String name = null;
            String surname = null;
            String city = null;

            if (fNameCheck.Checked && !String.IsNullOrWhiteSpace(fNameTextBox.Text)) 
                name = fNameTextBox.Text;

            if (fSurnameCheck.Checked && !String.IsNullOrWhiteSpace(fSurnameText.Text))
                surname = fSurnameText.Text;

            if (fCityCheck.Checked && !String.IsNullOrWhiteSpace(fCityTextBox.Text))
                city = fCityTextBox.Text;

            employeesListBox.Items.AddRange(
                EmployeesDao.GetEmployeesFiltered(name, surname, city).ToArray()
                );
        }



        //Events
        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            int? departmentId = null;
            int? managerId = null;

            var isInputCorrect = true;

            //Validate parameters
            if (String.IsNullOrWhiteSpace(cNameTextBox.Text))
                isInputCorrect = false;

            if (String.IsNullOrWhiteSpace(cSurnamesTextBox.Text))
                isInputCorrect = false;

            if (String.IsNullOrWhiteSpace(cMailTextBox.Text))
                isInputCorrect = false;

            if (String.IsNullOrWhiteSpace(cMailTextBox.Text))
                isInputCorrect = false;

            if (String.IsNullOrWhiteSpace(cPhoneTextBox.Text))
                isInputCorrect = false;

            if (String.IsNullOrWhiteSpace(cJobIdTextBox.Text))
                isInputCorrect = false;

            if (String.IsNullOrWhiteSpace(cSalaryTextBox.Text))
                isInputCorrect = false;

            //Return if no correct
            if (!isInputCorrect)
            {
                MessageBox.Show("Some of the inputs where not correct.");
                return;
            }

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

        private void getAllButton_Click(object sender, EventArgs e)
        {
            GetAllEmployees();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            GetFilteredEmployees();
        }
    }
}
