using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWinForms.Model
{
    public class Patient : Person
    {
        public Patient(string id, string name, string surname) : base(id, name, surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
    }
}
