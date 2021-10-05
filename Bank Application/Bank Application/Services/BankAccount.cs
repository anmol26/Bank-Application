using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application
{
    public class BankAccount
    {
        public static string UserName;
        public double Money;


        public BankAccount(string userName, double money)
        {
            UserName = userName;
            Money = money;
        }
        public BankAccount()
        { 
        }
        public void Add(double Money)
        {
            this.Money += Money;
            Console.WriteLine("\n"+Money + " added to the account successfully!!!");
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
                Console.WriteLine("\n" + Money + " withdraw from the account successfully!!!");
            }
        }
        public void Balance()
        {
            Console.WriteLine("\n"+"Your current amount in the Account is: "+ this.Money); 
        }
        public void Transfer(double money)
        {
            Money -= money;
           
            Console.WriteLine("\nYour Money Transfer is successful!!!!\n");
        }
        

    }
}
            



 

