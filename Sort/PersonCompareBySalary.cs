using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0212
{
    public class PersonCompareBySalary : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Salary - y.Salary;

            /*
            if (x.Salary == y.Salary)
                return x.Age - y.Age;

            if (x.Salary > y.Salary)
                return 1;

            return -1;
            */
        }
    }
}
