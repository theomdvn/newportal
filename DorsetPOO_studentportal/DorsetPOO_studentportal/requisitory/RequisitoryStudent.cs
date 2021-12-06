using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorsetPOO_studentportal.models;

namespace DorsetPOO_studentportal.requisitory
{

   public class RequisitoryStudent
    {
        public static List<Student> listStudents()
        {
            return new List<Student>();
        }

        public static void Add(Student newStudent)
        {
            listStudents().Add(newStudent);
        }



    }
}
