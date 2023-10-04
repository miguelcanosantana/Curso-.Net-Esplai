﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    public class Patient : Person
    {
        public Patient(string id, string name, string surname, Hospital hospital) : base (id, name, surname, hospital)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.hospital = hospital;
        }
    }
}
