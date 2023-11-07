using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsDBWinforms.Model
{
    public class Employee
    {
        int Id { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
        String Email { get; set; }
        String PhoneNumber { get; set; }
        String HireDate { get; set; }
        int FKJobId { get; set; }
        float Salary { get; set; }
        int FKManagerId { get; set; }
        int FKDepartmentId { get; set; }
    }
}
