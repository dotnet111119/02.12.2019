using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op_ov2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person danny = new Person(18, "Danny", 20);
            Person alex = new Person(18, "Alex", 20);
            Person suzi = new Person(18, "Suzi", 20);
            Person danny2 = new Person(18, "Danny", 20);
            Console.WriteLine(danny == danny2);
        }
    }
}
