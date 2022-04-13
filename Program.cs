using System;

namespace FinanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FileHandlingDemo demo = new FileHandlingDemo();
            demo.GetFileInfo("c:/chandan/e-learning/florence/MyFirstApp.java");
           // demo.CreateLog("FinanceApp2.log", "c:/chandan/e-learning/florence");
            demo.Log("c:/chandan/e-learning/florence/FinanceApp.log", "Another Line", "SUCCESS");
            //ExceptionHandlingDemo obj=new ExceptionHandlingDemo();
            //try
            //{
            //    obj.Login("", "secretsanta123");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("oops..unable to login now");
            //}
            


            //EcomApp app = new EcomApp();
            //SCustomer customer1 = new SCustomer();
            //customer1.customerName = "ABC";
            //customer1.customerEmail = "abc@gmail.com";
            //customer1.customerPhone = "+9173737333";
            //app.AddCustomer(customer1);

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
