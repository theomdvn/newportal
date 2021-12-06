using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorsetPOO_studentportal.Academic
{
    public class Exam
    {
        public string topic { get; set; }

        public Courses course;

        public DateTime date;    

        public Exam(string Topic,Courses Course, DateTime Date)
        {
            this.course = Course;
            this.topic = Topic;
            this.date = Date;
        }

        public void ShowExam()
        {
            Console.WriteLine($"{course}'s exam is about {topic}, it will take place on {date}");
        }

        public void ChangeTopic()
        {
            Console.WriteLine($"Old topic : {topic}");
            Console.WriteLine("New Topic :");
            string newtopic = Convert.ToString(Console.ReadLine());
            this.topic = newtopic;
        }
        public void ChangeDate()
        {
            Console.WriteLine($"Old date : {date}");
            Console.WriteLine("New date :");
            DateTime newdate = Convert.ToDateTime(Console.ReadLine());
            this.date = newdate;
        }

    }
}
