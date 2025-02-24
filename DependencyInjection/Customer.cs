using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{


    public class Customer
    {

      
    }


    public class SqlServer : ICustomer
    {

        public void Add()
        {

            Console.WriteLine("Data Was Added from Sql server");
        }


    }

    public class OracleServe : ICustomer
    {
        public void Add()
        {

            Console.WriteLine("Data Was Added from Oracle server");
        }
    }

}
