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
        protected Hospital hospital;

        public Person(string id, string name, string surname, Hospital hospital) 
        { 
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.hospital = hospital;
        }
    }
}
