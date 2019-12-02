using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0212
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 7, 4, -1, 10 };
            //string[] arr = { "CD", "ZZ", "AB"  };

            Person moshe = new Person(28, "Moshe", 110, 50_000);
            Person dana = new Person(20, "Dana", 80, 52_385);
            Person suzi = new Person(25, "Suzi", 60, 32_453);

            Person[] group = { moshe, dana, suzi };

            Console.WriteLine("before sort:");
            PrintArray(group);

            //Array.Sort(group); -- default is sort by Age
            Array.Sort(group, new PersonCompareBySalary());

            Console.WriteLine("after sort:");
            PrintArray(group);

        }

        static void PrintArray(Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
