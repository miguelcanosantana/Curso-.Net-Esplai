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
                        hospitalToSelect.CreatePerson();
                        break;

                    case 7:
                        hospitalToSelect.CreateAppointment();
                        break;

                    case 12:
                        hospitalToSelect.ShowAllPeople();
                        break;

                    case 13:
                        hospitalToSelect.ShowAllAppointments();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\n Your input was incorrect, try again...");
                        break;
                }

                Console.WriteLine("\n");

            } while (!result || selectOption != 0);
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
