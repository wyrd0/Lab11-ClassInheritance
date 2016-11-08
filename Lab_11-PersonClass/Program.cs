using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("mary", "anywhere");
            Console.WriteLine(p.ToString());

            Student s = new Student("mary", "anywhere", ".NET", "2016", 00);
            Console.WriteLine(s.ToString());

            Staff s2 = new Staff("ian", "anywhere", "GC", 00);
            Console.WriteLine(s2.ToString());
        }
    }
}
