using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanInheritance
{
    class student : person
    {
        public student(string Name, int Age, string StudentId, string Email) : base(Name, Age)
        {
            studentId = StudentId;
            email = Email;
        }

        public string studentId { get; set; }
        public string email { get; set; }
    }
}
