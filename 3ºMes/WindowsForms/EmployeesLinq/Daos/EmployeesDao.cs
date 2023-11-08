using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesLinq.Daos
{

    public static class EmployeesDao
    {

        static DataClasses1DataContext db = new DataClasses1DataContext();


        public static List<employees> GetAllEmployees()
        {
            List<employees> employeesList = new List<employees>();

            try
            {
                DataClasses1DataContext dC = new DataClasses1DataContext();
                var data = from emp in dC.employees
                           select emp;

                foreach (var emp in data)
                {
                    employeesList.Add(emp);
                }

                return employeesList;
            }
            catch (Exception fail)
            {
                MessageBox.Show("Error getting employees: " + fail.Message.ToString());
            }

            return employeesList;
        }


        public static List<employees> GetEmployeesFiltered(String name, String surname, String city)
        {
            List<employees> employeesList = new List<employees>();

            try
            {
                IQueryable<employees> data;
                DataClasses1DataContext dC = new DataClasses1DataContext();

                //Select employees from a city if the field is not null
                if (!string.IsNullOrWhiteSpace(city))
                {
                    data = from emp in dC.employees
                           join dep in dC.departments
                           on emp.department_id equals dep.department_id
                           join loc in dC.locations
                           on dep.location_id equals loc.location_id
                           where loc.city == city
                           select emp;
                }
                else
                {
                    data = from emp in dC.employees
                           select emp;
                }

                //Filter by the fields that are not null
                if (name != null)
                    data = data.Where(emp => emp.first_name.Contains(name));

                if (surname != null)
                    data = data.Where(emp => emp.last_name.Contains(surname));

                foreach (var emp in data)
                {
                    employeesList.Add(emp);
                }

                return employeesList;
            }
            catch (Exception fail)
            {
                MessageBox.Show("Error getting employees: " + fail.Message.ToString());
            }

            return employeesList;
        }


        public static bool TryInsertEmployee(
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
