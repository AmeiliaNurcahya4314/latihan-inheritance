using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanInheritance
{
    class teacher : person
    {
        public teacher(string Name, int Age, string Id, string Subject) : base(Name, Age)
        {
            Id = Id;
            subject = Subject;
        }

        public string teacherId { get; set; }
        public string subject { get; set; }
    }
}
