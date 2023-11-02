using HospitalWinForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWinForms
{
    internal static class Program
    {

        public static List<Hospital> hospitalsList = new List<Hospital>();
        public static Hospital selectedHospital;
        public static Person selectedPerson;
        public static Appointment selectedAppointment;
        public static MainForm hospitalMainForm;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            hospitalMainForm = new MainForm();
            GenerateInitialData();
            Application.Run(hospitalMainForm);

        }


        public static void UpdateFormsData()
        {
            hospitalMainForm.UpdateHospitals(hospitalsList);
        }


        private static void GenerateInitialData()
        {
            hospitalsList = new List<Hospital>()
            {
                new Hospital(Guid.NewGuid().ToString(),"Central Hospital","Madrid"),
                new Hospital(Guid.NewGuid().ToString(),"Coast Hospital","Barcelona"),
            };

            var patientA = hospitalsList[0].CreatePerson("90261925M", "Pepe", "Navarro", "patient");
            var patientB = hospitalsList[0].CreatePerson("00261925R", "Pepa", "Navarro", "patient");
            var medicA = hospitalsList[0].CreatePerson("10256123A", "Lola", "Flores", "medic");

            hospitalsList[0].CreateAppointment(
                "Test Appointment 1",
                "10-24-2000", medicA as Medic, patientB as Patient
                );

            hospitalsList[0].CreateAppointment(
                "Test Appointment 2",
                "11-25-2001", medicA as Medic, patientA as Patient
                );

            UpdateFormsData();
        }

    }
}
