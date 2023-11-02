using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWinForms.Model
{
    public class Person
    {
        protected string id;
        protected string name;
        protected string surname;

        public Person(string id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }

        public string GetInfo()
        {
            string info = "";

            info += id + " | ";
            info += name + " | ";
            info += surname + "\n";

            return info;
        }

        public string GetID() { return id; }
        public string GetName() { return name; }
        public string GetSurname() { return surname; }


        public void ModifyPerson()
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

            Console.Write("New surname (previous was " + this.surname + "): ");
            string surname = Console.ReadLine();

            if (surname == null || surname == "")
            {
                Console.Clear();
                Console.WriteLine("Surnames were left empty!");
                return;
            }

            this.name = name;
            this.surname = surname;

            Console.Clear();
            Console.WriteLine("Person Modified!");
        }
    }
}
