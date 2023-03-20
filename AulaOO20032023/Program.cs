using System;

namespace AulaOO20032023
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client()
            {
                Age = 20,
                Id = 1,
                MotherName = "Ana Silva",
                Name = "José Silva",
                Telephone = "16 9 9999 8888",
                TypePerson = new TypePerson() { Id = 1, Description = "Cliente" }
       
            };

            Manager manager = new Manager()
            {
                Name = "João Oliveira",
                Age = 40,
                Id = 2,
                Salary = 20000,
                Telephone = "16 98787 3234",
                TypePerson = new TypePerson() { Id = 2, Description = "Manager" }
            };


            Console.WriteLine(manager);
            Console.WriteLine("***************");
            Console.WriteLine(client);
           



        }
    }
}
