using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp
{
    internal interface IPayment {
        public void Pay(int amount,string customerId);
        public void CancelPayment();
        public void StopPayment();
        
    }

    internal class EcomApp : IPayment
    {
        //product
        //cart
        //customer - addresses
        //payment -id, amount, status, orderId,
        //order -- orderId, createdOn, createdBy, amount,deliveryAddress,
        List<SCustomer> customers=new List<SCustomer>();

        public void CancelPayment()
        {
           //TODO: How to cancel payment
        }

        public void Pay(int amount, string customerId)
        {
            //TODO: how to pay
        }

        public void StopPayment()
        {
            throw new NotImplementedException();
        }

        internal void AddCustomer(SCustomer customer)
        {
            customers.Add(customer);


            // Address address1 = new Address();
            // address1.line1 = "lin1";
            // address1.city = "Mumbai";
            // address1.line2 = "line2";
            // address1.country = "India";
            // address1.zipcode = "401107";
            //// customer1.addresses.Add(address1);

            customers.ForEach(customer =>
            {
                Console.WriteLine(customer.customerName);
            });
        }
    }

    internal struct Order
    {
        public int orderId;
        public DateTime createdOn;
        public string createdBy;
        public int orderAmount;
        public int addressId;
        public int customerId;
    }

    internal struct SCustomer
    {
        public string customerName;
        public string customerEmail;
        public string customerPhone;
        public List<Address> addresses;
    }

    internal struct Address { 
        public int id;
        public string name;
        public string line1;
        public string line2;
        public string city;
        public string country;
        public string zipcode;
    }
}
