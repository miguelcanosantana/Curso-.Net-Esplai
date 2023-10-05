using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public Medic GetMedic() { return medic; }

        public Patient GetPatient() { return patient; }

        public string GetInfo()
        {
            string info = "";

            info += "---------------------------------------------------------------------\n";
            info += id + " | ";
            info += date + "\n";
            info += "\n" + summary + "\n";
            info += medic.GetInfo() + "\n";
            info += patient.GetInfo() + "\n";

            return info;
        }

        public void ModifyAppointment()
        {
            Console.Clear();

            Console.Write("New summary (previous was " + this.summary + "): ");
            string summary = Console.ReadLine();

            if (summary == null || summary == "")
            {
                Console.Clear();
                Console.WriteLine("Summary was left empty!");
                return;
            }

            Console.Write("New date (previous was " + this.date + "): ");
            string date = Console.ReadLine();

            if (date == null || date == "")
            {
                Console.Clear();
                Console.WriteLine("Date was left empty!");
                return;
            }

            this.summary = summary;
            this.date = date;

            Console.Clear();
            Console.WriteLine("Appointment Modified!");
        }
    }
}
