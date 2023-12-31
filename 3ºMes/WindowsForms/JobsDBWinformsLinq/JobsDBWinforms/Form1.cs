﻿using JobsDBWinforms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        List<Job> jobsList = new List<Job>();

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


        private void TryInsertJob(Job job)
        {
            try
            {

                string query = $"INSERT INTO JOBS (job_title, min_salary, max_salary) VALUES (" +
                   "@job_title, @min_salary, @max_salary);" + 
                   "SELECT CAST(SCOPE_IDENTITY() as INT)";


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@job_title", job.jobTitle);
                    cmd.Parameters.AddWithValue("@min_salary", job.minSalary);
                    cmd.Parameters.AddWithValue("@max_salary", job.maxSalary);

                    object id = cmd.ExecuteScalar();
                    job.jobId = (int)id;
                }

                statusLabel.Text = "Job inserted, got the id: " + job.jobId;
            }
            catch (Exception e)
            {
                statusLabel.Text = "";
                MessageBox.Show("Error inserting Job to DB: " + e.Message.ToString());
            }
        }


        private void closeDBButton_Click(object sender, EventArgs e)
        {
            connection.Close();
            statusLabel.Text = "";
            UpdateButtons();
        }

        private void uploadJobButton_Click(object sender, EventArgs e)
        {
            try
            {
                Job newJob = new Job(
                    jobNameTextBox.Text,
                    Int32.Parse(minSalaryTextBox.Text),
                    Int32.Parse(maxSalaryTextBox.Text));
                TryInsertJob(newJob);
            }
            catch (Exception fail)
            {

                statusLabel.Text = "";
                MessageBox.Show("Some fields were wrong: " + fail.Message.ToString());
            }


        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            jobsList = GetJobs();
            jobsListBox.Items.AddRange(jobsList.ToArray());
        }

        private List<Job> GetJobs()
        {
            List<Job> jobs = new List<Job>();

            try
            {
                string query = "SELECT * FROM Jobs";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader recordsReader = cmd.ExecuteReader();

                while (recordsReader.Read())
                {
                    int jobId = recordsReader.GetInt32(recordsReader.GetOrdinal("job_id"));
                    String jobName = recordsReader.GetString(recordsReader.GetOrdinal("job_title"));

                    float? minSalary = null;
                    float? maxSalary = null;

                    if (!recordsReader.IsDBNull(recordsReader.GetOrdinal("min_salary")))
                        minSalary = (float)recordsReader.GetDecimal(recordsReader.GetOrdinal("min_salary"));

                    if (!recordsReader.IsDBNull(recordsReader.GetOrdinal("max_salary")))
                        maxSalary = (float)recordsReader.GetDecimal(recordsReader.GetOrdinal("max_salary"));

                    Job newJob = new Job(jobId, jobName, (float)minSalary, (float)maxSalary);
                    jobs.Add(newJob);
                }

                recordsReader.Close();

            }
            catch (Exception fail)
            {

                statusLabel.Text = "";
                MessageBox.Show("Some fields were wrong: " + fail.Message.ToString());
            }

            return jobs;
        }
    }
}
