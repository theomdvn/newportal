using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorsetPOO_studentportal.models;

namespace DorsetPOO_studentportal.requisitory
{
    public class RequisitoryUser
    {
        public static List<user> Users()
        {
            return new List<user>();       
        }
        public void addUser(user newUser)
        {
            Users().Add(newUser);
        }
    }
}
