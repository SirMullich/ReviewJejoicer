using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewJuicer.RatingSystem
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            Name = "";
            Surname = "";
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
