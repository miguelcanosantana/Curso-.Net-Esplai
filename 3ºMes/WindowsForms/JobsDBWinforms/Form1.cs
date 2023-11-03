using JobsDBWinforms.Model;
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
                   "'" + job.jobTitle + "'" + "," + job.minSalary + "," + job.maxSalary + ");" + 
                   "SELECT CAST(SCOPE_IDENTITY() as INT)";

                SqlCommand command = new SqlCommand(query, connection);
                object id = command.ExecuteScalar();
                job.jobId = (int)id;
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

    }
}
