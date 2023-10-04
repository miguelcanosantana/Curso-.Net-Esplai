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

        public Appointment(string id, string summary, string date, Medic medic, Patient patient) 
        {
            this.id = id;
            this.summary = summary;
            this.date = date;
            this.medic = medic;
            this.patient = patient;
        }

        public string GetId() { return id; }
        public string GetSummary() { return summary; }
        public string GetDate() { return date; }
        public Medic GetMedic() {  return medic; }
        public Patient GetPatient() {  return patient; }
    }
}
