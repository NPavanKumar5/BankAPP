using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApplication
{
    public class LimmitExceedExcep : Exception
    {
        public LimmitExceedExcep(string message) : base(message)
        {

        }

    }

    public class user
    {
        public string name
        {
            get;
            set;
        }
        public string gender
        {
            get;
            set;
        }
        public int age
        {
            get; set;
        }
        public string address
        {
            get;
            set;
        }
        public string contact
        {
            get;
            set;
        }
        public int balance
        {
            get;
            set;
        }

        public user Createuser(user s1)
        {
            Console.Write("\nEnter Name: ");
            s1.name = Console.ReadLine();
            Console.Write("Enter Gender: ");
            s1.gender = Console.ReadLine();
            Console.Write("Enter Age: ");
            s1.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Address: ");
            s1.address = Console.ReadLine();
            Console.Write("Enter Contact: ");
            s1.contact = Console.ReadLine();
            return s1;
        }
        public void displaydetails(List<user> lstAllusers)
        {
            Console.WriteLine("\n****************************************");
            Console.WriteLine("user Details are :");
            Console.WriteLine("*******************************************************");
            foreach (user s in lstAllusers)
            {
                Console.WriteLine("Name = {0}\t,Age = {1}\t,Gender = {2}\t,Address = {3}\t,Contact = {4}\tBalance = {5}", s.name, s.age, s.gender, s.address, s.contact, s.balance);
            }
        }
    }

    class Savingsaccount
    {
        int amount, balance = 0;
        static List<user> l = new List<user>();
        public void display()
        {
            user s1 = new user()
            {
                name = "pavan",
                age = 21,
                gender = "male",
                address = "puttur",
                contact = "92738971883782"

            };
            user s2 = new user()
            {
                name = "anurag",
                age = 23,
                gender = "male",
                address = "hyderabad",
                contact = "364281583674789"

            };
            user s3 = new user()
            {
                name = "lakshmi",
                age = 22,
                gender = "female",
                address = "kakinada",
                contact = "6769872615783882"

            };

            l.Add(s1);
            l.Add(s2);
            l.Add(s3);

        }
        public void Deposit(user s1)
        {
            Console.WriteLine("Enter the amount to deposit");
            amount = Convert.ToInt32(Console.ReadLine());
            //if (l.Count > 0)
            //{
            //    l[0].balance = balance;
            //}
            s1.balance = s1.balance + amount;
            Console.WriteLine("Total Balance : {0}", s1.balance);
        }
        public void Withdraw(user s1)
        {
            Console.WriteLine("Enter the amount to withdraw");
            amount = Convert.ToInt32(Console.ReadLine());
            //if (l.Count > 0)
            //{
            //    l[0].balance = balance;
            //}
            s1.balance = s1.balance - amount;
            Console.WriteLine("Total Balance : {0}", s1.balance);
        }
        public void Deduct(user s1)
        {
            Console.WriteLine("\nSince you exceeded the daily transaction limit\nYou will be deducted Rs.500 from your account");
            s1.balance = s1.balance - 500;
            Console.WriteLine("Total Balance : {0}", s1.balance);
            Console.WriteLine();
            //if (l.Count > 0)
            //{
            //    l[0].balance = balance;
            //}
        }

    }

    class Currentaccount
    {
        int amount, balance = 10000;
        public void Deposit(user s1)
        {
            Console.WriteLine("Enter the amount to deposit");
            amount = Convert.ToInt32(Console.ReadLine());
            s1.balance = s1.balance + amount;
            Console.WriteLine("Total Balance : {0}", s1.balance);
        }
        public void Withdraw(user s1)
        {
            Console.WriteLine("Enter the amount to withdraw");
            amount = Convert.ToInt32(Console.ReadLine());
            s1.balance = s1.balance - amount;
            Console.WriteLine("Total Balance : {0}", s1.balance);
        }
        public void Deduct(user s1)
        {
            Console.WriteLine("Since you exceeded the daily transaction limit\n You will be deducted Rs.500 from your account");
            s1.balance = s1.balance - 500;
            Console.WriteLine("Total Balance : {0}", s1.balance);
        }

    }

    class Childaccount
    {
        int amount, balance = 10000;

        public void Deposit(user s1)
        {
            Console.WriteLine("Enter the amount to deposit");
            amount = Convert.ToInt32(Console.ReadLine());
            s1.balance = s1.balance + amount;
            Console.WriteLine("Total Balance : {0}", s1.balance);
        }
        public void Withdraw(user s1)
        {
            Console.WriteLine("Enter the amount to withdraw");
            amount = Convert.ToInt32(Console.ReadLine());
            s1.balance = s1.balance - amount;
            Console.WriteLine("Total Balance : {0}", s1.balance);
        }
        public void Deduct(user s1)
        {
            Console.WriteLine("Since you exceeded the daily transaction limit\n You will be deducted Rs.500 from your account");
            s1.balance = s1.balance - 500;
            Console.WriteLine("Total Balance : {0}", s1.balance);
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            int choice = 0, n, count = 0;
            int usChoice = 0;
            Savingsaccount ss = new Savingsaccount();
            ss.display();
            Currentaccount c = new Currentaccount();
            Childaccount ch = new Childaccount();
            user s1 = null;
            List<user> lstusers = new List<user>();
            Console.WriteLine(" Welcome to sbi Bank :");
            

            try
            {
                for (; usChoice == 0;)
                {
                    count = 0;
                    if (usChoice == 0)
                    {
                        Console.WriteLine(" To open : \n Savings Account - 1 \n Current Account -2 \n Child Account - 3 ");
                        choice = Convert.ToInt32(Console.ReadLine());
                    }

                    switch (choice)
                    {
                        case 1:
                            {
                                
                                Console.WriteLine(" You have Choosed Savings Account :");

                                if (usChoice == 0)
                                {
                                    s1 = new user();
                                    s1 = s1.Createuser(s1);
                                    lstusers.Add(s1);
                                }

                                
                                Console.WriteLine("Your Savings Account Created Successfully....!");
                                Console.WriteLine("*******************************************");

                            SavingsTransaction:

                                Console.WriteLine("Below are the options to do the transaction...");
                                Console.WriteLine("Deposit - 1 \nWithdraw - 2 ");
                                n = Convert.ToInt32(Console.ReadLine());

                                if (n == 1)
                                {
                                    if (count < 3)
                                    {
                                        ss.Deposit(s1);
                                        count++;
                                    }
                                    else
                                    {
                                        ss.Deduct(s1);
                                        throw (new LimmitExceedExcep("Note : Your daily limit exceeded !"));

                                    }
                                }

                                if (n == 2)
                                {
                                    if (count < 3)
                                    {
                                        ss.Withdraw(s1);
                                        count++;
                                    }
                                    else
                                    {
                                        ss.Deduct(s1);
                                        throw (new LimmitExceedExcep("Note : Your daily limit exceeded !"));

                                    }
                                }

                                if (n == 1 || n == 2)
                                {
                                    Console.WriteLine("Do you want do another transaction...?\nYes --> 1\n No --> 2");
                                    int intcontinue = Convert.ToInt32(Console.ReadLine());
                                    if (intcontinue == 1)
                                        goto SavingsTransaction;
                                }

                                break;
                            }
                        case 2:
                            {
                                
                                Console.WriteLine(" You have Choosen Current Account :");

                                if (usChoice == 0)
                                {
                                    s1 = new user();
                                    s1 = s1.Createuser(s1);
                                    lstusers.Add(s1);
                                }

                                
                                Console.WriteLine("Your Current Account Created Successfully....!");
                               

                            CurrentTransaction:

                                Console.WriteLine("Below are the options to do the transaction...");
                                Console.WriteLine("Deposit -> 1 \nWithdraw -> 2 ");
                                n = Convert.ToInt32(Console.ReadLine());


                                if (n == 1)
                                {
                                    if (count < 3)
                                    {
                                        c.Deposit(s1);
                                        count++;
                                    }
                                    else
                                    {
                                        c.Deduct(s1);
                                        throw (new LimmitExceedExcep("Note : Your daily limit exceeded !!"));
                                    }
                                }
                                if (n == 2)
                                {
                                    if (count < 3)
                                    {
                                        c.Withdraw(s1);
                                        count++;
                                    }
                                    else
                                    {
                                        c.Deduct(s1);
                                        throw (new LimmitExceedExcep("Note : Your daily limit exceeded !"));
                                    }
                                }

                                if (n == 1 || n == 2)
                                {
                                    Console.WriteLine("Do you want do another transaction...?\nYes --> 1\n No --> 2");
                                    int intcontinue = Convert.ToInt32(Console.ReadLine());
                                    if (intcontinue == 1)
                                        goto CurrentTransaction;
                                }

                                break;
                            }
                        case 3:
                            {
                                
                                Console.WriteLine(" You have Choosen Child Account :");

                                if (usChoice == 0)
                                {
                                    s1 = new user();
                                    s1 = s1.Createuser(s1);
                                    lstusers.Add(s1);
                                }

                                
                                Console.WriteLine("Your Child Account Created Successfully....!");
                                

                            ChildTransaction:

                                Console.WriteLine("Below are the options to do the transaction...");
                                Console.WriteLine("Deposit -> 1 \nWithdraw -> 2 ");
                                n = Convert.ToInt32(Console.ReadLine());

                                if (n == 1)
                                {
                                    if (count < 3)
                                    {
                                        ch.Deposit(s1);
                                        count++;
                                    }
                                    else
                                    {
                                        ch.Deduct(s1);
                                        throw (new LimmitExceedExcep("Note : Your daily limit exceeded !!"));
                                    }
                                }
                                if (n == 2)
                                {
                                    if (count < 3)
                                    {
                                        ch.Withdraw(s1);
                                        count++;
                                    }
                                    else
                                    {
                                        ch.Deduct(s1);
                                        throw (new LimmitExceedExcep("Note : Your daily limit exceeded !!"));
                                    }
                                }

                                if (n == 1 || n == 2)
                                {
                                    Console.WriteLine("Do you want do another transaction...?\nYes --> 1\n No --> 2");
                                    int intcontinue = Convert.ToInt32(Console.ReadLine());
                                    if (intcontinue == 1)
                                        goto ChildTransaction;
                                }

                                break;
                            }
                        default:
                            {
                                Console.WriteLine(" Please enter a valid option");
                                break;
                            }
                    }

                    Console.WriteLine("Do you want to create another account...?\nYes --> Enter 0\nNo --> Enter 1");
                    usChoice = Convert.ToInt32(Console.ReadLine());

                }
            }
            catch (LimmitExceedExcep e)
            {
                
                Console.WriteLine("User Defined Exception {0}", e.Message);
            }
            s1.displaydetails(lstusers);

            Console.ReadKey();

        }

    }
}


