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

        public Appointment SelectAppointment()
        {
            ShowAllAppointments();

            Console.Write("Enter the appointment id: ");
            string id = Console.ReadLine();

            Appointment selectedAppointment = appointmentsList.Find(appointment => appointment.GetId().Equals(id));

            if (selectedAppointment != null)
                return selectedAppointment;

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

        public void ShowAllAppointments()
        {
            Console.Clear();
            Console.WriteLine("\n\n");

            Console.WriteLine("==== " + name + " Appointments ====");

            foreach (Appointment appointment in appointmentsList)
                Console.WriteLine(appointment.GetInfo());
        }

        public void ShowPatientAppointments()
        {
            Console.Clear();
            Patient patient = SelectPatient();

            if (patient == null)
            {
                Console.Clear();
                Console.WriteLine("That patient was not found!");
                return;
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("==== " + patient.GetName() + " Appointments ====");

            foreach (Appointment appointment in FindInAppointments(patient))
                Console.WriteLine(appointment.GetInfo());
        }

        public void ShowMedicAppointments()
        {
            Console.Clear();
            Medic medic = SelectMedic();

            if (medic == null)
            {
                Console.Clear();
                Console.WriteLine("That medic was not found!");
                return;
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("==== " + medic.GetName() + " Appointments ====");

            foreach (Appointment appointment in FindInAppointments(medic))
                Console.WriteLine(appointment.GetInfo());
        }

        //Get a generic person's data, create a patient or a medic depending on the input
        public void CreatePerson()
        {
            Console.Clear();

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

        public void CreateAppointment()
        {
            Console.Clear();

            Medic medic = SelectMedic();

            if (medic == null)
            {
                Console.Clear();
                Console.WriteLine("Selected medic was wrong!");
                return;
            }

            Patient patient = SelectPatient();

            if (patient == null)
            {
                Console.Clear();
                Console.WriteLine("Selected patient was wrong!");
                return;
            }

            Console.Write("Enter the summary of the appointment: ");
            string summary = Console.ReadLine();

            if (summary == null || summary == "")
            {
                Console.Clear();
                Console.WriteLine("Summary was left empty!");
                return;
            }

            Console.Write("Enter the date of the appointment (dd-mm-yyyy): ");
            string date = Console.ReadLine();

            if (date == null || date == "")
            {
                Console.Clear();
                Console.WriteLine("Date was left empty!");
                return;
            }

            string appointmentID = Guid.NewGuid().ToString();

            //Create and add it to the current hospital
            Appointment newAppoinment = new Appointment(appointmentID, summary, date, medic, patient);
            appointmentsList.Add(newAppoinment);

            Console.Clear();
            Console.WriteLine("Appointment created!");
        }

        public void ModifyHospital()
        {
            Console.Clear();

            Console.Write("New name (previous was " + this.name +"): ");
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

        public void ModifyAppointment()
        {
            Console.Clear();
            Appointment appointment = SelectAppointment();

            if (appointment == null)
            {
                Console.Clear();
                Console.WriteLine("That appointment was not found!");
                return;
            }

            appointment.ModifyAppointment();
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
                medicsList.Remove((Medic) person);

            else if (person.GetType() == typeof(Patient))
                patientsList.Remove((Patient) person);

            Console.Clear();
            Console.WriteLine("That person was removed!");
        }

        public void RemoveAppointment()
        {
            Console.Clear();

            Appointment appointment = SelectAppointment();

            if (appointment == null)
            {
                Console.Clear();
                Console.WriteLine("That appointment was not found!");
                return;
            }

            Console.Clear();
            Console.WriteLine("That appointment was removed!");
        }
    }
}
