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

        string name;
        string userName = new string("chandan");

        List<string> cities = new List<string>();
        List<int> scores = new List<int>();
        List<Customer> customers = new List<Customer>();

        internal void AddNewCustomer(Customer customer)
        {
            customers.Add(customer);

        }

        internal void PrintAllCustomer()
        {

            //foreach (var customer in customers) { 
            //Console.WriteLine($"Customer Name : {customer.name} , Address : {customer.address} , MobileNo : {customer.phoneNumber}");
            //}

            customers.ForEach(customer =>
            {
                Console.WriteLine($"Customer Name : {customer.name} , Address : {customer.address} , MobileNo : {customer.phoneNumber}");
            });

            customers.Clear();
            

            name=GetName();
            Console.WriteLine(name);
        }
        internal void SetCity(string cityName)
        {
            cities.Add(cityName);
            cities.Add("delhi");
            cities.Add("mumbai");
            cities.Add(null);
            scores.Add(100);


        }
        internal string GetName()
        {
            return "some Name";
        }

        
       
        internal void getCity()
        {
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


        }
    
    }

    internal class Customer { 
    
        public string name { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }

        public Customer(string name,string address, string phoneNumber) {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

    }

}
