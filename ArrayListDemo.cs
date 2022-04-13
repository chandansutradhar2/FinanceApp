using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FinanceApp
{
    internal class ArrayListDemo
    {
        ArrayList cities = new ArrayList();

        internal void SetCity(string cityName) { 
            cities.Add(cityName);
            cities.Add(500);
            cities.Add(true);
            cities.Add(null);
        }

       internal  void getCity() {
            Console.Write(cities);
        }

    }


}
