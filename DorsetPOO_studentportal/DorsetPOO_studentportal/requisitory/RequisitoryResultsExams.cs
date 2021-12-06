using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorsetPOO_studentportal.Academic;

namespace DorsetPOO_studentportal.requisitory
{
    public class RequisitoryResultsExams
    {
        public static List<ResultsExams> AllResults()
            {
                return new List<ResultsExams>();
            }

        public void Add(ResultsExams a)
        {
            AllResults().Add(a);
        }
    }
}
