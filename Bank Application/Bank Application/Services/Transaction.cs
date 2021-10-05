using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application
{
    public class Transaction
    {
        
        public static List<string> Transactions = new List<string>();

        public static void ShowTransactions()
        {
            Console.WriteLine("\nTransaction History:--");
            Console.WriteLine("<--------*-----*------->\n");
            foreach (string transaction in Transaction.Transactions)
            {
                Console.WriteLine(transaction);

            }

        }

    }
    
}
