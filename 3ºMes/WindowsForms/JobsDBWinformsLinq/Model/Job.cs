using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsDBWinforms.Model
{
    public class Job
    {
        public int? jobId;
        public String jobTitle;
        public float? minSalary;
        public float? maxSalary;

        public Job(String jobTitle, float? minSalary, float? maxSalary) 
        {
            this.jobTitle = jobTitle;
            this.minSalary = minSalary;
            this.maxSalary = maxSalary;
        }

        public Job(int jobId, String jobTitle, float? minSalary, float? maxSalary)
        {
            this.jobId = jobId;
            this.jobTitle = jobTitle;
            this.minSalary = minSalary;
            this.maxSalary = maxSalary;
        }

        public override string ToString()
        {
            return jobId + " | " + jobTitle + " | Min: " + minSalary + " | Max: " + minSalary;
        }
    }
}
