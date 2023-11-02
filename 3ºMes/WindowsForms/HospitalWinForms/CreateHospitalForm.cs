using HospitalWinForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWinForms
{
    public partial class CreateHospitalForm : Form
    {
        public CreateHospitalForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || locationTextBox.Text == "")
            {
                informLabel.Text = "ERROR: Some fields were left empty";
                return;
            }

            var newHospital = new Hospital(
                Guid.NewGuid().ToString(), 
                nameTextBox.Text,
                locationTextBox.Text
                );

            Program.hospitalsList.Add( newHospital );
            Program.UpdateFormsData();
            informLabel.Text = "Hospital Created!";
        }
    }
}
