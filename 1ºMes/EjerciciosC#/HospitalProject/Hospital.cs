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
        public List<Medic> GetMedics() { return medicsList; }
        public List<Patient> GetPatients() { return patientsList; }


        public void AddAppointment(Appointment appointment)
        {
            appointmentsList.Add(appointment);
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

        public Medic SelectMedic()
        {
            Console.WriteLine("\n\n");

            Console.WriteLine("==== List of Medics ====");

            foreach (Medic medic in medicsList)
                Console.WriteLine(medic.GetInfo());

            Console.WriteLine("\n\n");

            Console.Write("Enter the id of the medic: ");
            string medicId = Console.ReadLine();

            Medic selectedMedic = medicsList.Find(medic => medic.GetID().Equals(medicId));
            return selectedMedic;
        }

        public Patient SelectPatient()
        {
            Console.WriteLine("\n\n");

            Console.WriteLine("==== List of Patients ====");

            foreach (Patient patient in patientsList)
                Console.WriteLine(patient.GetInfo());

            Console.WriteLine("\n\n");

            Console.Write("Enter the id of the patient: ");
            string patientId = Console.ReadLine();

            Patient selectedPatient = patientsList.Find(patient => patient.GetID().Equals(patientId));
            return selectedPatient;
        }

        public void ShowAllPeople()
        {
            Console.Clear();
            Console.WriteLine("\n\n");

            Console.WriteLine("==== " + name + " Medics ====");

            foreach (Medic medic in medicsList)
                Console.WriteLine(medic.GetInfo());

            Console.WriteLine("==== " + name + " Patients ====");

            foreach (Patient patient in patientsList)
                Console.WriteLine(patient.GetInfo());
        }

        //Get a generic person's data, create a patient or a medic depending on the input
        public void CreatePerson()
        {
            Console.Write("Enter the ID: ");
            string id = Console.ReadLine();

            if (id == null || id == "")
            {
                Console.Clear();
                Console.WriteLine("ID was left empty!");
                return;
            }

            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            if (name == null || name == "")
            {
                Console.Clear();
                Console.WriteLine("Name was left empty!");
                return;
            }

            Console.Write("Enter the surnames: ");
            string surname = Console.ReadLine();

            if (surname == null || surname == "")
            {
                Console.Clear();
                Console.WriteLine("Surnames were left empty!");
                return;
            }

            Console.Write("Enter person type (medic/patient): ");
            string type = Console.ReadLine();

            if (type.Equals("medic"))
            {
                Medic newMedic = new Medic(id, name, surname);
                medicsList.Add(newMedic);
                Console.Clear();
                Console.WriteLine("Medic Created!");
            }
            else if (type.Equals("patient"))
            {
                Patient newPatient = new Patient(id, name, surname);
                patientsList.Add(newPatient);
                Console.Clear();
                Console.WriteLine("Patient Created!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Type (medic/patient) was left empty!");
            }
        }
    }
}
