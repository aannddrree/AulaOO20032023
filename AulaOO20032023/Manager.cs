﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO20032023
{
    class Manager : Employee
    {
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return "Tipo:" + this.TypePerson.Description 
                + "\n" + base.ToString() + "\nSalário: " + Salary;
        }
    }
}
