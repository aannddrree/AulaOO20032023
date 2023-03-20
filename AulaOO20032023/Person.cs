﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO20032023
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public int Age { get; set; }

        public TypePerson TypePerson { get; set; }


        public int NumberOfCaractersName()
        {
            return Name.Length;
        }

        public int NumberOfWordsName() => Name.Split(' ').Length;


        public override string ToString()
        {
            return "Id: " + Id + 
                   "\nNome: " + Name + 
                   "\nTelefone: " + Telephone +
                   "\nIdade: " + Age;
        }
    }
}
