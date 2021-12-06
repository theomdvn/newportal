using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorsetPOO_studentportal.Academic;

namespace DorsetPOO_studentportal.models
{
    public class Administrator : Faculty_Member
    {
        public string AdministratorName;

        public Administrator(string name ) : base(name)
        {

        }
        private Faculty_Member CreateTutor()
        {
            Console.WriteLine("New Tutor name : ");
            string tutorname = Convert.ToString(Console.ReadLine());


            return new Faculty_Member(tutorname);
        }
        private Courses CreateCourse(Faculty_Member tutor)
        {
            Console.WriteLine("New Course Name :");
            string CourseName = Convert.ToString(Console.ReadLine());
    
            return new Courses(CourseName, tutor);
        }
        
        private void AssignCourseToTutor(Courses course,Faculty_Member tutor)
        {
            tutor.courseManaged = course;
        }

    }
}
