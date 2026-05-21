using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFamily
{
    internal class FamilyTree
    {
        public List<Person> People { get; set; } = new List<Person>();

        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        public void AddChild(Person parent, Person child)
        {
            child.Parent = parent;
            parent.Children.Add(child);
        }

        public List<Person> GetAncestors(Person person)
        {
            var ancestors = new List<Person>();
            var current = person.Parent;

            while (current != null)
            {
                ancestors.Add(current);
                current = current.Parent;
            }

            return ancestors;
        }

        public List<Person> GetDescendants(Person person)
        {
            var descendants = new List<Person>();

            foreach (var child in person.Children)
            {
                descendants.Add(child);
                descendants.AddRange(GetDescendants(child));
            }

            return descendants;
        }
    }
}
