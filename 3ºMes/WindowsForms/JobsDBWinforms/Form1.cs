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


        private void TryInsertJob(String jobName, float minSalary, float maxSalary)
        {
            try
            {
                string query = $"INSERT INTO JOBS (job_title, min_salary, max_salary) VALUES (" +
                   "'" + jobName + "'" + "," + minSalary + "," + maxSalary + ")";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                statusLabel.Text = "Job inserted";
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
                TryInsertJob(newJob.jobTitle, newJob.minSalary, newJob.maxSalary);
            }
            catch (Exception fail)
            {

                statusLabel.Text = "";
                MessageBox.Show("Some fields were wrong: " + fail.Message.ToString());
            }


        }

    }
}
