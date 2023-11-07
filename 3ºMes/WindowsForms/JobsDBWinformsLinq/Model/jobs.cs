using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsDBWinforms
{
    public partial class jobs
    {
        public override string ToString()
        {
            return job_id + " " + job_title; 
        }
    }
}
