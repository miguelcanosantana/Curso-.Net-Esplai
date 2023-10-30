using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControllers
{
    public partial class ControllersForm : Form
    {
        private bool isDateSet = false;

        public ControllersForm()
        {
            InitializeComponent();

            //Hide the initial date
            dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = " ";
        }

        private void countriesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var text = countriesListBox.GetItemText(countriesListBox.SelectedItem);
            countryTextBox.Text = text;
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sexLabel.Text = "Male";
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sexLabel.Text = "Female";
        }

        private void checkDateButton_Click(object sender, EventArgs e)
        {
            if (isDateSet)
                dateValidLabel.Text = "Date is a valid value";
            else dateValidLabel.Text = "Date is NOT valid!";
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            isDateSet = true;

            //Show again the date
            dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
        }
    }
}
