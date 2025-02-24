using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Countries
    {
        public string countrues { get; set; }

        public void CountryName()
        {
             Console.WriteLine("INDIA");
        }
    }
    public class Singleton
    {
        private static Singleton _instance;

        private static readonly object _instanceLock = new object();

        private Singleton() { }

        private List<Countries> _countries;

        public Countries _countryobj;

        public static Singleton getinstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        _instance = new Singleton();
                    }

                }
                return _instance;

            }
        }

        public List<Countries> getcountries()
        {
            if (_countries == null)
            {
                lock (_instanceLock)
                {
                    _countries = new List<Countries>();

                }
            }
            return _countries;
        }

        public Countries countriesobj()
        {
            if (_countryobj == null)
            {
                lock (_instanceLock)
                {

                    _countryobj = new Countries();
                }

            }
            return _countryobj;



        }
    }
}
