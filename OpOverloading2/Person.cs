using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op_ov2
{
    public class Person 
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public Person(int age, string name, int id)
        {
            Age = age;
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return $"ID: {Id} AGE: {Age} NAME: {Name}";
        }

        public override bool Equals(object obj)
        {
            var person = obj as Person;
            return this == person;
        }

        public static bool operator == (Person p1, Person p2)
        {
            if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
                return true;

            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;

            return p1.Id == p2.Id; // sometimes also compare age + name ...
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Person p1, Person p2)
        {
            if (p1 == p2)
                return false;

            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;

            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            if (p1 == p2)
                return false;

            return !(p1 > p2);
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
    }
}
