using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Student
    {
        public string Name { get; set; }
        public double Not { get; set; }
        public Student(string _name, double not)
        {
            this.Name = _name;
            this.Not = not;

        }
    }
}
