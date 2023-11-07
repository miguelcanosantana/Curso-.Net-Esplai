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

        SqlConnection connection;
        List<jobs> jobsList = new List<jobs>();

        public Form1()
        {
            InitializeComponent();
            UpdateButtons();
        }

        private void connectToDBButton_Click(object sender, EventArgs e)
        {
            TryConnectDB();
        }


        private void UpdateButtons()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                closeDBButton.Enabled = true;
                connectToDBButton.Enabled = false;
            }
            else
            {
                closeDBButton.Enabled = false;
                connectToDBButton.Enabled = true;
            }
        }


        private void TryConnectDB()
        {
            try
            {
                connection = new SqlConnection(
                    @"Data source = 79.143.90.12,54321;
                    Initial Catalog = MiguelCanoEmployees;
                    Persist Security Info = true;
                    User Id = sa;
                    Password = 123456789");

                connection.Open();
                statusLabel.Text = "Connected to DB";
            }
            catch (Exception e)
            {
                statusLabel.Text = "";
                MessageBox.Show("Error connecting to DB: " + e.Message.ToString());
            }

            UpdateButtons();
        }


        private void TryInsertJobb()
        {
            try
            {
                DataContext db = new DataContext(connection);

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



        //private void TryInsertJob(Job job)
        //{
        //    try
        //    {

        //        string query = $"INSERT INTO JOBS (job_title, min_salary, max_salary) VALUES (" +
        //           "@job_title, @min_salary, @max_salary);" + 
        //           "SELECT CAST(SCOPE_IDENTITY() as INT)";


        //        using (SqlCommand cmd = new SqlCommand(query, connection))
        //        {
        //            cmd.Parameters.AddWithValue("@job_title", job.jobTitle);
        //            cmd.Parameters.AddWithValue("@min_salary", job.minSalary);
        //            cmd.Parameters.AddWithValue("@max_salary", job.maxSalary);

        //            object id = cmd.ExecuteScalar();
        //            job.jobId = (int)id;
        //        }

        //        statusLabel.Text = "Job inserted, got the id: " + job.jobId;
        //    }
        //    catch (Exception e)
        //    {
        //        statusLabel.Text = "";
        //        MessageBox.Show("Error inserting Job to DB: " + e.Message.ToString());
        //    }
        //}


        private void closeDBButton_Click(object sender, EventArgs e)
        {
            connection.Close();
            statusLabel.Text = "";
            UpdateButtons();
        }

        private void uploadJobButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Job newJob = new Job(
            //        jobNameTextBox.Text,
            //        Int32.Parse(minSalaryTextBox.Text),
            //        Int32.Parse(maxSalaryTextBox.Text));
            //    TryInsertJob(newJob);
            //}
            //catch (Exception fail)
            //{
            //    statusLabel.Text = "";
            //    MessageBox.Show("Some fields were wrong: " + fail.Message.ToString());
            //}


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
