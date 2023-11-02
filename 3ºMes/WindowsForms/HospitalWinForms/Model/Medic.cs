using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWinForms.Model
{
    public class Medic : Person
    {
        public Medic(string id, string name, string surname) : base(id, name, surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
    }
}
