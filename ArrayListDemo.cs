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
        List<string> cities = new List<string>();
        List<int> scores = new List<int>();
        internal void SetCity(string cityName) { 
            cities.Add(cityName);
            cities.Add("delhi");
            cities.Add("mumbai");
            cities.Add(null);
            scores.Add(100);

        }

       internal  void getCity() {
            Console.Write(cities);
        }

    }


}
