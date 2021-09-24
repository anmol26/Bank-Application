using System;
using System.Collections.Generic;

namespace Bank_Application
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank Application");
            Console.WriteLine("<-------*---------*------->\n");

            //created a Users dictionary
            Dictionary<string, string> Users = new Dictionary<string, string>();
            Users.Add("Anmol", "1234");                                              //registered users
            Users.Add("Balaji", "0000");                                             //registered users

            //created a transaction history array
            List<string> Transactions = new List<string>();

            Console.WriteLine("Enter 1, To Create a new account");
            Console.WriteLine("Enter any key, To login an existing account");

            // take user input to create account
            bool createAccount = (Console.ReadLine() == "1") ? true : false;
            // branch according to createAccount
            string userName = "";
            string password = "";
            string userName2 = "";
            if (createAccount)
            {
                // create a new account and add it to users
                Console.WriteLine("Enter the username:- ");
                userName = Console.ReadLine();
                // check if userName already exists in users dict if exists ask to pick another userName
                while (Users.ContainsKey(userName))
                {
                    Console.WriteLine(userName + " is already taken, Please pick another username");
                    userName = Console.ReadLine();
                }
                // set password 
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
                // add user to users dict
                Users.Add(userName, password);
                Console.WriteLine("\n!!!!!! Account Created Successfully !!!!!!\n");

              
            }
            Console.WriteLine("Enter Username");
            userName = Console.ReadLine();
            while (!Users.ContainsKey(userName))
            {
                    Console.WriteLine("Enter username");
                    userName = Console.ReadLine();
                    while (!Users.ContainsKey(userName))
                    {
                        Console.WriteLine("Username not found, Please try again");
                        userName = Console.ReadLine();
                    }
            }    
            
            Console.WriteLine();
            Console.WriteLine("Enter Password");
            password = Console.ReadLine();
            while (Users[userName] != password)
            {
                Console.WriteLine("Wrong password, Please try again");
                password = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine($"{userName}, You are successfully logged in!!!!! ");
            Console.WriteLine("Press 1, To deposit money");
            Console.WriteLine("Press 2, To withdraw money");
            Console.WriteLine("Press 3, To transfer money");
            Console.WriteLine("Press 4, To show transaction history");
            Console.WriteLine("Press 5, To see the balance");
            Console.WriteLine("Press 0, To log out");

            BankAccount bankAccount1 = new BankAccount(userName, 5000);
            BankAccount bankAccount2 = new BankAccount(userName2, 1000);

            string option = Console.ReadLine();
            while (option != "0")
            {
                if (option == "1")
                {
                    Console.WriteLine("Enter amount to deposit in account linked to username "+ userName);
                    string add = Console.ReadLine();
                    bankAccount1.Add(Convert.ToInt32(add));
                    Transactions.Add($"{add} deposited in account of "+ userName);
                }
                else if (option == "2")
                {
                    Console.WriteLine("Enter amount to withdraw from account linked to username " + userName);
                    string sub = Console.ReadLine();
                    bankAccount1.Withdraw(Convert.ToInt32(sub));
                    Transactions.Add($"{sub} withdrawn from account of " + userName);
                }
                else if (option == "3")
                {   //start
                    Console.WriteLine("Enter the Account's username to transfer money:- ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter amount to transfer in "+ username +"'s account:-");
                    string amount = Console.ReadLine();
                    bankAccount1.Withdraw(Convert.ToInt32(amount));
                    bankAccount2.Add(Convert.ToInt32(amount));
                    Transactions.Add($"{amount} has been transferred to account of {username}");
                }
                else if (option == "4")
                {
                    Console.WriteLine("\nTransaction History:--");
                    Console.WriteLine("<--------*-----*------->\n");
                    foreach (string transaction in Transactions)
                    {
                        Console.WriteLine(transaction);
                    }
                }
                else if (option == "5")
                {
                    bankAccount1.Balance();
                }
                else
                {
                    Console.WriteLine("Enter a valid option");
                }

                Console.WriteLine("\nPress 1, To deposit money");
                Console.WriteLine("Press 2, To withdraw money");
                Console.WriteLine("Press 3, To transfer money");
                Console.WriteLine("Press 4, To show transaction history");
                Console.WriteLine("Press 5, To see the balance");
                Console.WriteLine("Press 0, To log out");
                option = Console.ReadLine();
            }



                   // BankAccount bankAccount1 = new BankAccount(userName, 5000);

                   // bankAccount1.Balance();
                   // bankAccount2.Balance();

                   // Console.WriteLine("\nTransactions:--- \n");

                   // bankAccount1.Add(500);
                   // bankAccount2.Add(1000);

                   // bankAccount1.Withdraw(200);
                   // bankAccount2.Withdraw(550);

                   // bankAccount1.Transfer(330);

                   // Console.WriteLine("\nAfter Transactions:--- \n");
                   // bankAccount1.Balance();
                   // bankAccount2.Balance();
        }



            
    }
}

