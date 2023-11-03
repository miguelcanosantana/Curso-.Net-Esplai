using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsDBWinforms.Model
{
    public class Job
    {
        int? JobId { get; set; }
        String JobTitle { get; set; }
        float MinSalary { get; set; }
        float MaxSalary { get; set; }

        public Job(String jobTitle, float minSalary, float maxSalary) 
        {
            JobTitle = jobTitle;
            MinSalary = minSalary;
            MaxSalary = maxSalary;
        }
    }
}
