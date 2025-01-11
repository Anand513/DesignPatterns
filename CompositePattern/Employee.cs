using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class Employee
    {
        protected string _name;
        protected string _position;

        public Employee(string name, string position) {
        _name = name;
        _position = position;
        }

        public abstract void showdetails(int indent);


    }
}
