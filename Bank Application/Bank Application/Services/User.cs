using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application
{
    public class User
    {

        public static string userName;

        public string accountNum;
        
        public static Dictionary<string, string> Users = new Dictionary<string, string>
        {
                { "Anmol", "1234" },                                              //registered users
                { "Balaji", "0000" }                                             //registered users
        };

    }

}
