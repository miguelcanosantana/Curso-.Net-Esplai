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
        }

        private void createHospitalMenuItem_Click(object sender, EventArgs e)
        {
            var newCreateHospital = new CreateHospitalForm();
            newCreateHospital.ShowDialog();
        }


        public void UpdateHospitals(List<Hospital> hospitalList)
        {
            hospitalListBox.Items.Clear();
            //hospitalListBox.DisplayMember = "name";
            //hospitalListBox.ValueMember = "id";
            hospitalListBox.Items.AddRange(hospitalList.ToArray());
        }

        private void UpdatePatients()
        {
            List<Patient> patientsList = new List<Patient>();
            patientsList = Program.selectedHospital.GetPatients();

            patientListBox.Items.Clear();
            patientListBox.DisplayMember = "name";
            patientListBox.ValueMember = "id";
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

        private void patientListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            // Assuming your class called Scores
            String id = ((Patient)e.ListItem).GetID();
            String name = ((Patient) e.ListItem).GetName();
            String surname = ((Patient) e.ListItem).GetSurname();

            e.Value = id + " | " + name + " " + surname;
        }
    }
}
