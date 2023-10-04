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
        List<Medic> medicsList = new List<Medic>();
        List<Patient> patientsList = new List<Patient>();

        public Hospital(string id, string name, string location) 
        {
            this.id = id;
            this.name = name;
            this.location = location;
        }


        public string GetName() { return name; }


        public void AddAppointment(Appointment appointment)
        {
            appointmentsList.Add(appointment);
        }

        public void AddMedic(Medic medic)
        {
            medicsList.Add(medic);
        }

        public void AddPatient(Patient patient)
        {
            patientsList.Add(patient);
        }

        public List<Appointment> FindInAppointments(Patient patient)
        {
            return this.appointmentsList.FindAll(appointment => appointment.GetPatient().Equals(patient));
        }

        public List<Appointment> FindInAppointments(Medic medic)
        {
            return this.appointmentsList.FindAll(appointment => appointment.GetPatient().Equals(medic));
        }

        public void CreateAppointment(string id, string summary, string date, Medic medic, Patient patient)
        {
            Appointment newAppointment = new Appointment(id, summary, date, medic, patient);
        }
    }
}
