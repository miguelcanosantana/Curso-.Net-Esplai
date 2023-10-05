using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalProject
{
    internal class Program
    {
        static public List<Hospital> hospitalsList = new List<Hospital>();


        static void Main(string[] args)
        {
            HospitalLoop();
            Console.ReadKey();
        }

        static public void HospitalLoop()
        {
            int selectOption;
            bool result;

            do
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1.Create Hospital");
                Console.WriteLine("2.Modify Hospital");
                Console.WriteLine("3.Remove Hospital");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("4.Create Medic / Patient");
                Console.WriteLine("5.Modify Medic / Patient");
                Console.WriteLine("6.Remove Medic / Patient");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("7.Create Appointment");
                Console.WriteLine("8.Modify Appointment");
                Console.WriteLine("9.Remove Appointment");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("10.Show a patient's appointments");
                Console.WriteLine("11.Show a medic's appointments");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("12.Show an hospital medics and patients");
                Console.WriteLine("13.Show all hospital's appointments");
                Console.WriteLine("--------------------------------");
                Console.Write("Input: ");

                result = int.TryParse(Console.ReadLine(), out selectOption);
                Hospital hospitalToSelect = null;

                //Pre-select hospital for the options that need it
                if (result && selectOption > 2 && selectOption < 14)
                {
                    hospitalToSelect = SelectHospital();

                    if (hospitalToSelect == null)
                    {
                        selectOption = -1;
                        Console.Clear();
                        Console.WriteLine("Selected Hospital was wrong!");
                    }
                }

                switch (selectOption)
                {
                    //In case a wrong hospital is selected DO NOTHING!
                    case -1:
                        break;

                    case 1:
                        CreateHospital();
                        break;

                    case 3: 
                        RemoveHospital(hospitalToSelect); 
                        break;

                    case 4:
                        CreatePerson(hospitalToSelect);
                        break;

                    case 7:
                        CreateAppointment(hospitalToSelect);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\n Your input was incorrect, try again...");
                        break;
                }

                Console.WriteLine("\n");

            } while (!result || selectOption != 0);
        }


        static public void ShowAllAppointments()
        {

        }


        static public void CreateAppointment(Hospital hospital)
        {
            Medic medic = hospital.SelectMedic();

            if (medic == null)
            {
                Console.Clear();
                Console.WriteLine("Selected medic was wrong!");
                return;
            }

            Patient patient = hospital.SelectPatient();

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
            hospital.AddAppointment(newAppoinment);
        }


        static public void CreateHospital()
        {
            string id = Guid.NewGuid().ToString();
            string name;
            string location;

            do
            {
                Console.Clear();

                Console.Write("Enter the name: ");
                name = Console.ReadLine();

                Console.Write("Enter the location: ");
                location = Console.ReadLine();

            } while (name == null || location == null);

            Hospital newHospital = new Hospital(id, name, location);
            hospitalsList.Add(newHospital);
            Console.Clear();
            Console.WriteLine("Hospital Created!");
        }


        static public void RemoveHospital(Hospital hospital)
        {
            hospitalsList.Remove(hospital);

            Console.Clear();
            Console.WriteLine("Hospital deleted!");
        }


        //Get a generic person's data, create a patient or a medic depending on the input
        static public void CreatePerson(Hospital hospital)
        {
            string id;
            string name;
            string surname;
            string type;
            bool correctType;
            Hospital assignedHospital;

            do
            {
                correctType = false;

                Console.Clear();

                Console.Write("Enter the ID: ");
                id = Console.ReadLine();

                Console.Write("Enter the name: ");
                name = Console.ReadLine();

                Console.Write("Enter the surnames: ");
                surname = Console.ReadLine();

                Console.Write("Enter person type (medic/patient): ");
                type = Console.ReadLine().ToLower();

                if (type.Equals("medic") || type.Equals("patient"))
                    correctType = true;

            } while (id == null || name == null || surname == null || type == null || 
                !correctType);

            if (type.Equals("medic"))
            {
                Medic newMedic = new Medic(id, name, surname);
                hospital.AddMedic(newMedic);
                Console.Clear();
                Console.WriteLine("Medic Created!");
            }
            else
            {
                Patient newPatient = new Patient(id, name, surname);
                hospital.AddPatient(newPatient);
                Console.Clear();
                Console.WriteLine("Patient Created!");
            }
        }


        static public void ShowHospitalPeople()
        {
            Hospital hospital = SelectHospital(" to look at");
            hospital.ShowAllPeople();
        }


        static public Hospital SelectHospital()
        {
            Console.WriteLine("\n\n");

            Console.WriteLine("==== List of Hospitals ====");

            foreach (Hospital hospital in hospitalsList)
                Console.WriteLine(hospital.GetName());

            Console.WriteLine("\n\n");

            Console.Write("Enter the name of the Hospital: ");
            string hospitalName = Console.ReadLine();

            Hospital assignedHospital = hospitalsList.Find(hospital => hospital.GetName().Equals(hospitalName));
            return assignedHospital;
        }


    }
}
