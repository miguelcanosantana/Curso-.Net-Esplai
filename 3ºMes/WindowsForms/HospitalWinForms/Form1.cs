using HospitalWinForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            patientRadioButton.Checked = true;
        }

        private void createHospitalMenuItem_Click(object sender, EventArgs e)
        {
            var newCreateHospital = new CreateHospitalForm();
            newCreateHospital.ShowDialog();
        }


        public void UpdateHospitals(List<Hospital> hospitalList)
        {
            hospitalListBox.Items.Clear();
            hospitalListBox.Items.AddRange(hospitalList.ToArray());
        }

        private void UpdatePatients()
        {
            List<Patient> patientsList = new List<Patient>();
            patientsList = Program.selectedHospital.GetPatients();

            patientListBox.Items.Clear();
            patientListBox.Items.AddRange(patientsList.ToArray());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void hospitalListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (hospitalListBox.SelectedItem == null)
                return;

            var hospital = hospitalListBox.SelectedItem as Hospital;
            Program.selectedHospital = hospital;
            UpdatePatients();
        }

        private void patientRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            patientListBox.Visible = true;
            doctorListBox.Visible = false;
        }

        private void doctorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            patientListBox.Visible = false;
            doctorListBox.Visible = true;
        }
    }
}
