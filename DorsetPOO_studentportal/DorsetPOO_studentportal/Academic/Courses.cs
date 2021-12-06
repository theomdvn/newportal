using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorsetPOO_studentportal.models;

namespace DorsetPOO_studentportal.Academic
{
    public class Courses
    {
        public string CourseName { get; set; }
        public Faculty_Member Tutor { get; set; }
        public Courses(string CourseName, Faculty_Member Tutor)
        {
            this.CourseName = CourseName;
            this.Tutor = Tutor;
        }
    }
}
