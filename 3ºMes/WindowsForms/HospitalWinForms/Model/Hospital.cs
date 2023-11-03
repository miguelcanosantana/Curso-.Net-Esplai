using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWinForms.Model
{
    public class Hospital
    {
        public string id;
        public string name;
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


        public override string ToString()
        {
            return name + " | " + location;
        }


        public void RemoveAppointment(Appointment appointment)
        {
            appointmentsList.Remove(appointment);
        }

        public string GetName() { return name; }

        public List<Medic> GetMedics() { return medicsList; }

        public List<Patient> GetPatients() { return patientsList; }

        public List<Appointment> FindInAppointments(Patient patient)
        {
            return this.appointmentsList.FindAll(appointment => appointment.GetPatient().Equals(patient));
        }

        public List<Appointment> FindInAppointments(Medic medic)
        {
            return this.appointmentsList.FindAll(appointment => appointment.GetMedic().Equals(medic));
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

        public Person SelectPerson()
        {
            Console.WriteLine("\n\n");

            Console.WriteLine("==== List of Medics ====");

            foreach (Medic medic in medicsList)
                Console.WriteLine(medic.GetInfo());

            Console.WriteLine("\n\n");

            Console.WriteLine("==== List of Patients ====");

            foreach (Patient patient in patientsList)
                Console.WriteLine(patient.GetInfo());

            Console.WriteLine("\n\n");

            Console.Write("Enter the id of the person: ");
            string personId = Console.ReadLine();

            Person selectedMedic = medicsList.Find(medic => medic.GetID().Equals(personId));

            if (selectedMedic != null)
                return selectedMedic;

            Person selectedPatient = patientsList.Find(patient => patient.GetID().Equals(personId));

            if (selectedPatient != null)
                return selectedPatient;

            return null;
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
        public Person CreatePerson(String id, String name, String surname, String type)
        {
            Person person = null;

            if (type.Equals("medic"))
            {
                Medic newMedic = new Medic(id, name, surname);
                medicsList.Add(newMedic);
                person = newMedic;
            }
            else if (type.Equals("patient"))
            {
                Patient newPatient = new Patient(id, name, surname);
                patientsList.Add(newPatient);
                person = newPatient;
            }

            return person;
        }

        public void CreateAppointment(String summary, String date, Medic medic, Patient patient)
        {
            string appointmentID = Guid.NewGuid().ToString();

            //Create and add it to the current hospital
            Appointment newAppoinment = new Appointment(appointmentID, summary, date, medic, patient);
            appointmentsList.Add(newAppoinment);
        }


        public void ModifyHospital()
        {
            Console.Clear();

            Console.Write("New name (previous was " + this.name + "): ");
            string name = Console.ReadLine();

            if (name == null || name == "")
            {
                Console.Clear();
                Console.WriteLine("Name was left empty!");
                return;
            }

            Console.Write("New location (previous was " + this.location + "): ");
            string location = Console.ReadLine();

            if (location == null || location == "")
            {
                Console.Clear();
                Console.WriteLine("Location was left empty!");
                return;
            }

            this.name = name;
            this.location = location;

            Console.Clear();
            Console.WriteLine("Hospital Modified!");
        }

        public void ModifyPerson()
        {
            Console.Clear();
            Person person = SelectPerson();

            if (person == null)
            {
                Console.Clear();
                Console.WriteLine("That person was not found!");
                return;
            }

            person.ModifyPerson();
        }

        public void RemovePerson()
        {
            Console.Clear();

            Person person = SelectPerson();

            if (person == null)
            {
                Console.Clear();
                Console.WriteLine("That person was not found!");
                return;
            }

            if (person.GetType() == typeof(Medic))
                medicsList.Remove((Medic)person);

            else if (person.GetType() == typeof(Patient))
                patientsList.Remove((Patient)person);

            Console.Clear();
            Console.WriteLine("That person was removed!");
        }
    }
}
