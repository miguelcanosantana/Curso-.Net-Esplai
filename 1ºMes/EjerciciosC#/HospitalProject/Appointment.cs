using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    public class Appointment
    {
        string id;
        string summary;
        string date;
        Medic medic;
        Patient patient;

        public Appointment(string id, string summary, string date, Medic medic, Patient patient) { }
    }
}
