using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections;
namespace FinanceApp
{
    internal class FinanceApp
    {
        public User user;
        public FinanceApp(User _user)
        {
            user = _user;
        }

        public User GetCurrentUser()
        {
            return user;
        }

        public int GetTotalExpense() {

            return 1000;
                
        }
        public void AddExpense(int expAmount)
        {
            user.expenses.Add(expAmount);
        }
    }
    class Expense
    {
        public DateTime createdOn;
        public DateTime expenseDate;
        public string expenseTitle;
        public int amount;
    }

    class User
    {

        public int userId { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber;

      //  public int[] expenses = new int[40]; //8 byte 8*40=320 byte
      
       public ArrayList expenses = new ArrayList();

        public User(int _userId, string _password, string _fName, string _lName, string _email, string _mobile)
        {
            this.userId = _userId;
            this.password = _password;
            this.emailAddress = _email;
            this.firstName = _fName;
            this.lastName = _lName;
            this.phoneNumber = _mobile;
        }
    }


    internal class Caller
    {

        public Caller()
        {
            FinanceApp app = new FinanceApp(new User(01, "secret3", "Chandan", "Naresh", "chandan@gmail.com", "8080808333"));
            FinanceApp app2 = new FinanceApp(new User(01, "secret3", "Ranjan", "Sutradhar", "ranjan@gmail.com", "8966565543"));
            app.AddExpense(40000);
            app2.AddExpense(500);
            app.AddExpense(1500);
            app.AddExpense(1250);
            //string userString = JsonSerializer.Serialize(app.GetCurrentUser());

            Console.WriteLine($"FirstName: {app.GetCurrentUser().firstName}, LastName: {app.GetCurrentUser().lastName} , PhoneNumber:{app.GetCurrentUser().phoneNumber}");
            //Array.ForEach(app.GetCurrentUser().expenses., exp =>
            //{
            //    Console.WriteLine(exp);
            //});
            //Console.WriteLine(userString);

        }
    }
}
