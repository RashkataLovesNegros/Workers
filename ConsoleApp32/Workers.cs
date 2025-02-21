using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public class Workers
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Workers(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }
    }
}
