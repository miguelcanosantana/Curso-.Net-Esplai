using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrmTestLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void GetEmployeeName()
        {
            DataClasses1DataContext dC = new DataClasses1DataContext();
            var data = from em in dC.employees
                       where em.employee_id == 103
                       select em.first_name;

            String name = data.FirstOrDefault();
        }


        private void GetAllEmployees()
        {
            DataClasses1DataContext dC = new DataClasses1DataContext();
            var data = from em in dC.employees
                       select em;

            foreach ( var employee in data)
            {

            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            GetEmployeeName();
        }
    }
}
