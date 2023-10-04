using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    public class Hospital
    {
        string id;
        string name;
        string location;
        List<Appointment> appointmentsList = new List<Appointment>();

        public Hospital() { }
    }
}
