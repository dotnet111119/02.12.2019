using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0212
{
    public class Person : IComparable<Person>
    {
        public int Age { get; protected set; }
        public string Name { get; protected set; }
        public float Weight { get; protected set; }

        public int Salary { get; protected set; }

        public Person(int age, string name, float weight, int salary)
        {
            Age = age;            Name = name;            Weight = weight;            Salary = salary;
        }

        public override string ToString()
        {
            return $"AGE: {Age} NAME: {Name} WEIGHT: {Weight} SLARY: {Salary}";
        }

        public int CompareTo(Person other)
        {
            return this.Age - other.Age;
            /*
            if (this.Age == other.Age)
                return 0;

            if (this.Age > other.Age)
                return 1;

            return -1;
            */
        }

        /*
        // explain comparison logic
        public int CompareTo(object obj)
        {
            // return  0           -- we are the same
            // return  1 [positive]-- he is first (obj)
           // return -1 [negative]-- he is before me
            //Person other = (Person)obj;
            Person other = obj as Person;

            if (this.Age == other.Age)
                return 0;

            if (this.Age > other.Age)
                return 1;

            return -1;
        }
        */
    }
}
