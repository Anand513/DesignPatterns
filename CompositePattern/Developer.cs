using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Developer : Employee
    {

        public Developer(string name): base(name,"Developer") { }
        public override void showdetails(int indent)
        {
           Console.WriteLine(new string('-', indent)+ $"{_position}:{_name}");
        }
    }

    public class Designer : Employee
    {
        public Designer(string name) : base(name, "Designer") { }
        public override void showdetails(int indent)
        {
            Console.WriteLine(new string('-', indent) + $"{_position}:{_name}");
        }
    }

    public class Manager : Employee
    {
        public Manager(string name) : base(name, "Manager") { }

        private readonly List<Employee> employees = new List<Employee>();

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public void remove(Employee employee)
        {
            employees.Remove(employee);
        }
        public override void showdetails(int indent)
        {
            Console.WriteLine(new string('-', indent) + $"{_position}:{_name}");

            foreach (Employee employee in employees)
            {
                employee.showdetails(indent+2);
            }
        }
    }
}
