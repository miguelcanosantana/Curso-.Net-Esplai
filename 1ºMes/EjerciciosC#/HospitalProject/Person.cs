using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
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

            info += id +"\n";
            info += name + "\n";
            info += surname + "\n";

            return info;
        }

        public string GetID() { return id; }
    }
}
