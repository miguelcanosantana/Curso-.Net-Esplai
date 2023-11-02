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

            //hospitalsList[0].CreatePerson();

            UpdateFormsData();
        }

    }
}
