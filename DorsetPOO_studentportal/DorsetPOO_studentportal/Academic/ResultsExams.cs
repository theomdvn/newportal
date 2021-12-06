using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorsetPOO_studentportal.Academic
{
    public class ResultsExams
    {
        public List<float> results;

        public string topic;

        public Courses course;

        public Exam exam;

        public ResultsExams(Exam Exam, Courses Course, string Topic, List<float> Results)
        {
            this.exam = Exam;
            this.course = Course;
            this.topic = Topic;
            this.results = Results;
        }

        public void ShowResults()
        {
            Console.WriteLine($"Results for :");
            Console.WriteLine(this.exam.ToString());

            foreach (float grade in this.results)
            {
                Console.WriteLine(grade);
            }
        }
        protected void ModifyResults()
        {

        }
    }
}
