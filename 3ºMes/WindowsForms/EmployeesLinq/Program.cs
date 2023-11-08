using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesLinq
{
    internal static class Program
    {
        static DataClasses1DataContext db = new DataClasses1DataContext();
        static List<employees> employeesList = new List<employees>();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        private static bool TryInsertEmployee(
            String name, 
            String lastName, 
            String mail, 
            String phone,
            int jobId,
            decimal money,
            int? managerId,
            int? departmentId
            )
        {
            try
            {
                employees emp = new employees
                {
                   first_name = name,
                   last_name = lastName,
                   email = mail,
                   phone_number = phone,
                   hire_date = DateTime.Now,
                   job_id = jobId,
                   salary = money,
                   manager_id = managerId,
                   department_id = departmentId
                };

                db.GetTable<employees>().InsertOnSubmit(emp);
                db.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inserting Employee to DB: " + e.Message.ToString());
                return false;
            }
        }
    }
}
