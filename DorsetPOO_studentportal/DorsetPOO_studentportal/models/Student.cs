using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorsetPOO_studentportal.Academic;


namespace DorsetPOO_studentportal.models
{
    public class Student
    {
        public string name;
        protected string Contact;
        private float Fees = 50000;
        public int absence = 0;
        public Student(string name)
        {
            this.name = name;
        }

        private void FeesPayment(float paid)
        {
            this.Fees -= paid;
        }
        
        protected void ShowPayments()
        {
            Console.WriteLine(this.Fees);
        }

        protected void ShowContact()
        {
            Console.WriteLine(this.Contact);
        }

        private void ModifyContact(string newContact)
        {
            this.Contact = newContact;
        }


    }
}
