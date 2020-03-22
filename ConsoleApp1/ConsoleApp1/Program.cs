using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person P1 = new Person("Bob","Kunga");

            
            Console.WriteLine(Person.GetLanzar());
            Console.WriteLine(P1.FirstName);
            Console.WriteLine(P1.LastName);

            Console.ReadLine();
        }
    }
}
