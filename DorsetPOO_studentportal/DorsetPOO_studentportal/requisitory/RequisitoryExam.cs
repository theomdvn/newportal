using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorsetPOO_studentportal.Academic;
using DorsetPOO_studentportal.models;


namespace DorsetPOO_studentportal.requisitory
{
    public class RequisitoryExam
    {
        public static List<Exam> AllExams()
        {
            return new List<Exam>();
            
        }

        public static void Add(Exam exam)
        {
           AllExams().Add(exam);
        }

    }

}
