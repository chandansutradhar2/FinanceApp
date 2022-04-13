using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
namespace FinanceApp
{
    internal class ExceptionHandlingDemo
    {
        bool showSpinner=false;
        public void Login(string email,string password) {

            if (email.Length <= 0 || password.Length <= 0) {
                throw new ArgumentNullException();
                
            }
            showSpinner = true;
            Console.WriteLine("Connecting to DB....");

            DBConnection dBConnection = new DBConnection();

            try
            {
                dBConnection.Connect("localhost", 4732, "sa", "admin", "testdb");
                int result = dBConnection.SendQuery($"select * from users where uid={email} and password={password}");
                if (result >= 1)
                {
                    Console.WriteLine("login success");
                }
                else
                {
                    Console.WriteLine("invalid credentials");
                }
            }
            catch (DbException ex)
            {
                Console.WriteLine("Please check your database connection string");
            }
            catch (AccessViolationException ace) {
                Console.WriteLine("You don't have permission to access the db");
            }
            catch (Exception e)
            {
                Console.WriteLine("Facing some technical issue at the moment...please try again in some time");
                //TODO : generate Alarm

            }
            finally
            {
                Console.WriteLine("Cleaning all dependencies....");
                showSpinner = false;
            }


        }    
    }

    internal class DBConnection {

        public void Connect(string host,int port, string userId,string password,string dbName) {
            throw new AccessViolationException();
        }

        public int SendQuery(string query) {
            return 1;
        }
    }

}
