using JobsDBWinforms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsDBWinforms
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        List<jobs> jobsList = new List<jobs>();

        public Form1()
        {
            InitializeComponent();
        }


        private void TryInsertJob()
        {
            try
            {
                jobs job = new jobs
                {
                    job_title = jobNameTextBox.Text,
                    min_salary = Int32.Parse(minSalaryTextBox.Text),
                    max_salary = Int32.Parse(maxSalaryTextBox.Text)
                };

                db.GetTable<jobs>().InsertOnSubmit(job);
                db.SubmitChanges();

                statusLabel.Text = "Job inserted, got the id: ";// + job.jobId;
            }
            catch (Exception e)
            {
                statusLabel.Text = "";
                MessageBox.Show("Error inserting Job to DB: " + e.Message.ToString());
            }
        }

        private void uploadJobButton_Click(object sender, EventArgs e)
        {
            TryInsertJob();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            jobsList = GetJobs();
            jobsListBox.Items.Clear();
            jobsListBox.Items.AddRange(jobsList.ToArray());
        }

        private List<jobs> GetJobs()
        {
            List<jobs> jobsList = new List<jobs>();

            try
            {
                DataClasses1DataContext dC = new DataClasses1DataContext();
                var data = from job in dC.jobs
                           select job;

                foreach (var job in data)
                {
                    jobsList.Add(job);
                }

                return jobsList;
            }
            catch (Exception fail)
            {
                statusLabel.Text = "";
                MessageBox.Show("Error getting jobs: " + fail.Message.ToString());
            }

            return jobsList;
        }
    }
}
