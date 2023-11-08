using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesLinq.Daos
{

    public static class EmployeesDao
    {

        static DataClasses1DataContext db = new DataClasses1DataContext();
        static SqlConnection connection = new SqlConnection(
            @"Data source = 79.143.90.12,54321;
            Initial Catalog = MiguelCanoEmployees;
            Persist Security Info = true;
            User Id = sa;
            Password = 123456789");


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

                // Add Filter by the fields that are not null
                if (name != null)
                    data = data.Where(emp => emp.first_name.Contains(name));

                if (surname != null)
                    data = data.Where(emp => emp.last_name.Contains(surname));

                //Read the list
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


        public static List<employees> GetEmployeesFilteredSQL(String name, String surname, String city)
        {
            List<employees> employeesList = new List<employees>();

            try
            {
                connection.Open();

                string query = "SELECT * FROM employees";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader recordsReader = cmd.ExecuteReader();

                while (recordsReader.Read())
                {
                    //Non nullable parameters
                    int employeeId = recordsReader.GetInt32(recordsReader.GetOrdinal("employee_id"));
                    String firstName = recordsReader.GetString(recordsReader.GetOrdinal("first_name"));
                    String lastName = recordsReader.GetString(recordsReader.GetOrdinal("last_name"));
                    String mail = recordsReader.GetString(recordsReader.GetOrdinal("email"));
                    DateTime hireDate = recordsReader.GetDateTime(recordsReader.GetOrdinal("hire_date"));
                    int jobId = recordsReader.GetInt32(recordsReader.GetOrdinal("job_id"));
                    decimal money = recordsReader.GetDecimal(recordsReader.GetOrdinal("salary"));

                    //Nullable parameters checks
                    String phoneNumber = null;
                    int? managerId = null;
                    int? departmentId = null;

                    if (!recordsReader.IsDBNull(recordsReader.GetOrdinal("phone_number")))
                        phoneNumber = recordsReader.GetString(recordsReader.GetOrdinal("phone_number"));

                    if (!recordsReader.IsDBNull(recordsReader.GetOrdinal("manager_id")))
                        managerId = recordsReader.GetInt32(recordsReader.GetOrdinal("manager_id"));

                    if (!recordsReader.IsDBNull(recordsReader.GetOrdinal("department_id")))
                        departmentId = recordsReader.GetInt32(recordsReader.GetOrdinal("department_id"));

                    employees emp = new employees
                    {
                        first_name = firstName,
                        last_name = lastName,
                        email = mail,
                        phone_number = phoneNumber,
                        hire_date = hireDate,
                        job_id = jobId,
                        salary = money,
                        manager_id = managerId,
                        department_id = departmentId
                    };

                    employeesList.Add(emp);
                }

                recordsReader.Close();
                connection.Close();

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
