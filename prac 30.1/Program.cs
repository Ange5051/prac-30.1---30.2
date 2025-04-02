using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<Person> people = new List<Person>();
                people.Add(new Russian("Александр"));
                people.Add(new American("Alex"));
                people.Add(new Ukraine("Олександр"));
                foreach (Person person in people)
                {
                    person.SayHello();
                }
                Console.ReadKey();
            }
        }
    }
}

