using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanInheritance
{
    class person
    {
        public person(string Name, int Age)
        {
            Name = Name;
            Age = Age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
        }
    }
}
