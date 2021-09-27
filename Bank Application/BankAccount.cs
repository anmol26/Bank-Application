using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application
{
    class BankAccount
    {
        public string UserName;
        public double Money;

        public BankAccount(string userName, double money)
        {
            UserName = userName;
            Money = money;
        }
        public void Add(double Money)
        {
            this.Money += Money;
            Console.WriteLine("\n"+Money + " added to the " + UserName + "'s account successfully!!!");
        }
        public void Withdraw(double Money)
        {
            if (this.Money < Money)
            {
                Console.WriteLine("Insufficient Balance, Transaction failed!!!");
            }
            else 
            {
                this.Money -= Money;
                Console.WriteLine("\n" + Money + " withdraw from the " + UserName + "'s account successfully!!!");
            }
        }
        public void Balance()
        {
            Console.WriteLine("\n"+"Your current amount in the Account with username "+ UserName + " is: "+ this.Money); 
        }
        

    }
}
            



 

