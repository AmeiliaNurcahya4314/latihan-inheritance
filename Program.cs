using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            person person = new person("Mike", 20);
            //person.Name = "Mike";
            //person.Age = 20;
            person.GetNameAndAge();

            teacher teacher = new teacher("Thomas", 35, "178657", "Math");
            //teacher.Name = "Thomas";
            //teacher.Age = 35;
            //teacher.teacherId = "1863617";
            //teacher.subject = "Math";
            teacher.GetNameAndAge();

            student student = new student("sara", 19 "75798", "sara123@amikom.ac.id");
            //student.Name = "Sara";
            //student.Age = 19;
            //student.studentId = "17686";
            //student.email = "sara123@amikom.ac.id";
            student.GetNameAndAge();

            Console.ReadKey();
       
        }
    }
}
