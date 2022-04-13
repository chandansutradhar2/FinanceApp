using System;

namespace FinanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EcomApp app = new EcomApp();
            SCustomer customer1 = new SCustomer();
            customer1.customerName = "ABC";
            customer1.customerEmail = "abc@gmail.com";
            customer1.customerPhone = "+9173737333";
            app.AddCustomer(customer1);

            //Caller i=new Caller();
            //ArrayListDemo o=new ArrayListDemo();
            //o.SetCity("Mumbai");
            //o.AddNewCustomer(new Customer("Chandan","Mira Road, Thane","8080811145"));
            //o.AddNewCustomer(new Customer("Samaya", "Mira Road", "9878765432"));
            //o.AddNewCustomer(new Customer("Harsha","Mumbai","8767949122"));
            //o.PrintAllCustomer();
            //o.getCity();

        }
    }
}
