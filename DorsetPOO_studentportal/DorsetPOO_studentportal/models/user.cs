using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorsetPOO_studentportal.requisitory;


namespace DorsetPOO_studentportal.models
{
    public class user
    {
        string username;
        string password;

        public user(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        bool login(string username, string pw )
        {
            // Users().Any(user => username == "2" && pw == "true");
            bool a = true;
            return a;
        }
    }
}
