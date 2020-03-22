using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public static int GetLanzar()
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 3);
            return numero;

        }
        public Person(string aFirstName, string aLastName)
        {
            FirstName = aFirstName;
            LastName = aLastName;
        }
    }
}
