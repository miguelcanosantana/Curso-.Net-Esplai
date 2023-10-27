using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksForm
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String message;

            if (titleTextBox.Text.Equals("") || locationComboBox.Text.Equals("")
                || typeComboBox.Text.Equals("") || criticityComboBox.Text.Equals("")
                || descriptionTextBox.Text.Equals("") || dateTimePicker1.Text.Equals("")
                || durationNumericUpDown.Value < 0) 
            {
                message = "Error, some values where incorrect...";
            }
            else
            {
                message =
                    "Task: " + titleTextBox.Text +
                    " located in " + locationComboBox.Text +
                    " of the type " + typeComboBox.Text +
                    " is a critical as " + criticityComboBox.Text +
                    ".\n\n" +
                    "Description would be the following:\n" + descriptionTextBox.Text +
                    "\n\n" +
                    "The task started in " + dateTimePicker1.Text +
                    " with a duration of " + durationNumericUpDown.Value.ToString() +
                    ".\n\n" +
                    "The current status is " + statusComboBox.Text +
                    " and " + percentCompleteComboBox.Text + " complete.";
            }

            ResultForm resultF = new ResultForm(message, mailCheckBox.Checked);
            resultF.ShowDialog();
        }
    }
}
