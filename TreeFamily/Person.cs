using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFamily
{
    internal class Person
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string PassportData { get; set; }
        public Person Parent { get; set; }
        public List<Person> Children { get; set; } = new List<Person>();

        public override string ToString()
        {
            return $"{FullName} ({PassportData})";
        }
    }
}
