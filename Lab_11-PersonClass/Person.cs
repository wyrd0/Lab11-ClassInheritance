using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_PersonClass
{
    public class Person
    {
        private string name;
        private string address;

        public Person(string name, string address)
        {
            this.name = name;
            Address = address;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        public override string ToString()

        {

            return "Person Name: " + name + "\nAddress: " + address;
        }
    }

    //public string GetName()
    //{
    //    Console.Write("Please enter Name:   ");
    //    name = (Console.ReadLine());
    //    return name;
    //}
    //public string GetAddress()
    //{
    //    return address;
    //}
      
}