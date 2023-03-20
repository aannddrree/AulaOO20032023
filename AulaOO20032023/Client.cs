using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO20032023
{
    class Client : Person
    {
        public string MotherName { get; set; }

        public override string ToString()
        {
            return "Tipo:" + this.TypePerson.Description + "\n" 
                + base.ToString() + "\nNome da Mãe: " + MotherName;
        }
    }
}
