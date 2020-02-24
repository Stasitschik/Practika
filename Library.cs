using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    class Library
    {
        private string name = new string(' ', 20);
        private string address = new string(' ', 20);
        private int year;
        public Library()
        {
            this.name = "Название";
            this.address = "Адресс";
            this.year = 2020;
        }
        public Library(string _name, string _address, int _year)
        {
            this.name = _name;
            this.address = _address;
            this.year = _year;

        }
        public string Name
        {
            set
            {
                name = value;
            }
        }
        public string Address
        {
            set
            {
                address = value;
            }
        }
        public int Year
        {
            set
            {
                year = Convert.ToInt32(value);
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("Название -  {0}; адресс - {1}; год открытия - {2}.", name, address, year);
        }
    }
}
