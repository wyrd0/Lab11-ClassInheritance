using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_PersonClass
{
    class Student:Person
    {
        private string program;
        private string year;
        private double fee;

        public string Program
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public string Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }

        public Student(string name, string address, string program, string year, double fee) :base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        public override string ToString()
        {
            return base.ToString() + program + " " + year + " " + fee + " ";
        }
    }
}
