using BankApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankApp
{
    public delegate void adddelegate();
    class Saving
    {

        public void deposit(int amt)
        {
            try
            {
                if (amt > 100000)
                {
                    throw new Exception();
                }

                Console.WriteLine("You have  deposited " + amt + "in your savings acc ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Max accounrt limit is 100000" + e);
            }
        }
    }
    class WriteData
    {
        public void data()
        {
            string filepath = "C:\\userdel.txt";
            try
            {

                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.Write(Environment.NewLine + "Appending this new line");
                    sw.Close();
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine(File.ReadAllText(filepath));
            }
        }
    }




    class current
    {

        public void deposit(int curramt)
        {
            try
            {
                if (curramt > 200000)
                {
                    throw new Exception();
                }

                Console.WriteLine("You have deposited" + curramt + "in your current acc");
            }
            catch (Exception e)
            {
                Console.WriteLine("Max account limit is 200000" + e);
            }
        }
    }
    class child
    {

        public void deposit(int childamt)
        {
            try
            {
                if (childamt > 50000)
                {
                    throw new Exception();
                }
                Console.WriteLine("You have deposited" + childamt + "in your childcare acc");
            }
            catch (Exception e)
            {
                Console.WriteLine("Max account limit is 50000" + e);
            }
        }
    }
    class CustomerDetails
    {
        String name;
        int accno;
        string address;
        public void CustomerInput()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("enter your accno");
            accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your address");
            address = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------");
        }
        public void info()
        {
            Console.WriteLine("Your Deatils is " + name + " " + accno + " " + address);
            Console.WriteLine("Thank you for entering your details");
            Console.WriteLine("-------------------------------------------------------------------------");
        }
        public void atm()
        {

            Console.WriteLine("Enter the money to credit in atm");
            int avlbalance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Credited amount in your acc is " + avlbalance);
            Console.WriteLine("Thank you, your money has been credited successfully");
            Console.WriteLine("Do you have any other choice!!");
            for (int i = 1; i <= 3; i++)
            {

                Console.WriteLine("   1.Withdrawl");

                Console.WriteLine("   2.CheckBal ");
                Console.WriteLine("   3.Exit");
                int Choice = Convert.ToInt32(Console.ReadLine());


                if (Choice == 1)
                {
                    Console.WriteLine("Enter the amt to withdraw");
                    int withdrawlamt = Convert.ToInt32(Console.ReadLine());

                    if (avlbalance > withdrawlamt)
                    {
                        Console.WriteLine("Amt has been withdrawn successfully");

                        avlbalance = avlbalance - withdrawlamt;
                        Console.WriteLine("Remaianing bal in your account is" + avlbalance);
                    }

                    else
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    if (i >= 3)
                    {
                        Console.WriteLine("Day Limit Exceeds so the amount is detecting upto 500 from account");
                        avlbalance = avlbalance - withdrawlamt;
                        Console.WriteLine("Remianing balance before detecting is :" + avlbalance);
                        avlbalance = avlbalance - 500;
                        Console.WriteLine("Remianing balance after detecting is :" + avlbalance);
                    }
                }
                if (Choice == 2)
                {

                    Console.WriteLine("Your available bal is " + avlbalance);
                }
                if (Choice == 3)
                {
                    Console.WriteLine("Thank for visiting our branch");
                    Environment.Exit(0);
                    Console.ReadKey();
                }
            }
        }
    }
    class List
    {
        public class customerdel
        {
            public string name
            {
                get; set;
            }

            public int age
            {
                get;
                set;
            }
            public int accno
            {
                get;
                set;
            }
            public string ifsccode
            {
                get;
                set;
            }
            public int totalamt
            {
                get;
                set;
            }
        };


        class Bank
        {
            public void bankInput()
            {
                Console.WriteLine(" 1 - Savings Account");
                Console.WriteLine(" 2- Current Account");
                Console.WriteLine(" 3-ChildCare Account");
                Console.WriteLine("---------------------------------------------------------------");

                Console.WriteLine("Enter your option");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Thank you for choosing saving account");
                        Console.WriteLine("Your account limit is 100000");
                        Console.WriteLine("Please enter your details");
                        CustomerDetails cd1 = new CustomerDetails();
                        cd1.CustomerInput();
                        cd1.info();
                        Saving s = new Saving();
                        Console.WriteLine("Enter amount to be deposited in savings acc");
                        int amt = Convert.ToInt32(Console.ReadLine());
                        s.deposit(amt);
                        cd1.atm();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Thank you for choosing current account");
                        Console.WriteLine("Your account limit is 200000");
                        Console.WriteLine("Please enter your details");
                        CustomerDetails cd2 = new CustomerDetails();
                        cd2.CustomerInput();
                        cd2.info();
                        current c = new current();
                        Console.WriteLine("Enter amount to be deposited in currentacc");
                        int curramt = Convert.ToInt32(Console.ReadLine());
                        c.deposit(curramt);
                        cd2.atm();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Thank you for choosing ChildCare account");
                        Console.WriteLine("Your account limit is 50000");
                        Console.WriteLine("Please enter your details");
                        CustomerDetails cd3 = new CustomerDetails();
                        cd3.CustomerInput();
                        cd3.info();
                        child ch = new child();
                        Console.WriteLine("Enter amount to be deposit in childcare acc");
                        int childamt = Convert.ToInt32(Console.ReadLine());
                        ch.deposit(childamt);
                        cd3.atm();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Sorry,You have choosen an invalid account");
                        Console.ReadKey();
                        break;




                }


            }

            class Program
            {
                static void Main(string[] args)
                {
                    Bank b = new Bank();
                    b.bankInput();
                    WriteData w = new WriteData();
                    w.data();



                    customerdel cd1 = new customerdel()
                    {
                        name = "siva",
                        age = 32,
                        accno = 34567347,
                        ifsccode = "ifsc1",
                        totalamt = 45000

                    };
                    customerdel cd2 = new customerdel()
                    {
                        name = "sai",
                        age = 23,
                        accno = 3412347,
                        ifsccode = "ifsc12",
                        totalamt = 6000

                    };
                    customerdel cd3 = new customerdel()
                    {
                        name = "venkat",
                        age = 35,
                        accno = 1267697,
                        ifsccode = "ifsc3",
                        totalamt = 53400

                    };
                    customerdel cd4 = new customerdel()
                    {
                        name = "rama",
                        age = 27,
                        accno = 34567697,
                        ifsccode = "ifsc5",
                        totalamt = 4000

                    };
                    customerdel cd5 = new customerdel()
                    {
                        name = "anitha",
                        age = 19,
                        accno = 34567697,
                        ifsccode = "ifsc4",
                        totalamt = 12300



                    };
                    List<customerdel> cu = new List<customerdel>();

                    cu.Add(cd1);
                    cu.Add(cd2);
                    cu.Add(cd3);
                    cu.Add(cd4);
                    cu.Add(cd5);

                    Console.WriteLine("customer data ");
                    Console.WriteLine("Name ||  Age  ||  Accno  || Ifsccode  ||totalamt");
                    foreach (customerdel c in cu)
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine(c.name + "  ||   " + c.age + "    ||   " + c.accno + "  ||    " + c.ifsccode + "  || " + c.totalamt);

                    }

                    Console.ReadKey();

                }


            }
        }
    }
}




