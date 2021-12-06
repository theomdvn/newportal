using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorsetPOO_studentportal.Academic;
using DorsetPOO_studentportal.requisitory;

namespace DorsetPOO_studentportal.models
{
    public class Faculty_Member : Student
    {
        public string tutorName { get; set; }
        public Courses courseManaged { get; set; }
        public Faculty_Member(string TutorName) : base(TutorName)
        {
            this.tutorName = TutorName;
        }     
        protected Exam CreateExam()
        {
            Console.WriteLine("Exam Topic : ");
            string topic = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Date of the exam :");
            DateTime date = Convert.ToDateTime(Console.ReadLine());       



            Exam controle = new Exam(topic, this.courseManaged, date);
            RequisitoryExam.Add(controle);
            return controle;

        }
        protected ResultsExams CreateResults(Exam exam, List<float> grades)
        {
            Console.WriteLine();

            return new ResultsExams(exam, this.courseManaged, exam.topic, grades);
        }

        protected void Attendance(Student student)
        {
            Console.WriteLine($"Is {student.name} present in {courseManaged} class?");
            Console.WriteLine("(1) present || (2) absent");
            int a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            {
                case 1:
                    Console.WriteLine($"{student.name} is present.");
                    break;
                case 2:
                    Console.WriteLine($"{student.name} is absent");
                    student.absence -= 1;
                    break;
            }
        }

        public void ShowExam()
        {
            foreach (Exam a in RequisitoryExam.AllExams().FindAll(x => x.course == courseManaged))
            {
                a.ShowExam();
            }
        }

        public void ShowGrades()
        {
            foreach(ResultsExams a in RequisitoryResultsExams.AllResults().FindAll(x => x.course == courseManaged))
            {
                a.ShowResults();
            }
        }
    }
}
