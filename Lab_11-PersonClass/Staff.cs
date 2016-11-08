using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_PersonClass
{
    class Staff:Person
    {
        private string school;
        private double pay;

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public double Pay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }

        public Staff(string name, string address, string school, double pay):base(name, address)
        {
            School = school;
            Pay = pay;
        }
        public override string ToString()
        {
            return base.ToString( ) + " " + school + " " + pay;
        }

    }

}
