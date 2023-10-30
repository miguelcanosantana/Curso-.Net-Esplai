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
        public ControllersForm()
        {
            InitializeComponent();
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
            dateValidLabel.Text = "Date is a valid value";
        }
    }
}
