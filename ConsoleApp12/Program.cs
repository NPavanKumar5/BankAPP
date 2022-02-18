using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class LimitExceed : Exception
    {
        public LimitExceed(string message) : base(message)
        {
        }
    }
    class Savingsaccount
    {
        int amount;
        public void savingsamount()
        {
            amount = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (amount > 100000)
                {
                    throw (new LimitExceed("Your daily limit exceeded "));
                }
                else
                {
                    Console.WriteLine("Amount Deposited Successfully ");
                }
            }
            catch (LimitExceed e)
            {
                Console.WriteLine("User Defined Exception {0}", e.Message);
            }
        }
    }
    class Currentaccount : Savingsaccount
    {
        int amount;
        public void currentamount()
        {
            amount = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (amount > 200000)
                {
                    throw (new LimitExceed(" Your daily limit exceeded "));
                }
                else
                {
                    Console.WriteLine("Amount Deposited Successfully  ");
                }
            }
            catch (LimitExceed e)
            {
                Console.WriteLine("User Defined Exception {0}", e.Message);
            }
        }
    }
    class Childaccount : Currentaccount
    {
        int amount;
        public void childamount()
        {
            amount = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (amount > 50000)
                {
                    throw (new LimitExceed(" Your daily limit exceeded"));
                }
                else
                {
                    Console.WriteLine("Amount Deposited Successfully ");
                }
            }
            catch (LimitExceed e)
            {
                Console.WriteLine("User Defined Exception {0}", e.Message);
            }
        }
    }
    class Bank : Childaccount
    {
        string name, address;
        int age, accountno;
        public void customerdetails()
        {
            Console.WriteLine(" Please enter your details:");
            Console.WriteLine(" **************************************************** ");
            Console.WriteLine(" Enter your Name : ");
            name = Console.ReadLine();
            Console.WriteLine(" Enter your Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter your Address : ");
            address = Console.ReadLine();
            Console.WriteLine(" Enter your Account no: ");
            accountno = Convert.ToInt32(Console.ReadLine());
        }
        public void Deposit(int c)
        {
            
            Bank amount = new Bank();
            if (c == 1)
            {
                amount.savingsamount();
            }
            if (c == 2)
            {
                amount.currentamount();
            }
            if (c == 3)
            {
                amount.childamount();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Bank o = new Bank();
            Console.WriteLine(" Welcome to HDFC Bank :");
            Console.WriteLine(" *****************************************");
            Console.WriteLine(" To open : Savings Account -> Enter 1 / Current Account -> Enter 2 / Child Account -> Enter 3 ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        o.customerdetails();
                        o.Deposit(n);
                        break;
                    }
                case 2:
                    {


                        o.customerdetails();
                        o.Deposit(n);
                        break;
                    }
                case 3:
                    {
                        o.customerdetails();
                        o.Deposit(n);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please enter a valid option");
                        break;
                    }
            }




            Console.ReadKey();
        }
    }
}
    


