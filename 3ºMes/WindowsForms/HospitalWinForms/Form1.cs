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

        private void UpdateMedics()
        {
            List<Medic> medicsList = new List<Medic>();
            medicsList = Program.selectedHospital.GetMedics();

            doctorListBox.Items.Clear();
            doctorListBox.Items.AddRange(medicsList.ToArray());
        }

        private void UpdateAppointments()
        {
            List<Appointment> appointmentsList = new List<Appointment>();

            if (patientRadioButton.Checked)
                appointmentsList = Program.selectedHospital.FindInAppointments(Program.selectedPerson as Medic);
            else
                appointmentsList = Program.selectedHospital.FindInAppointments(Program.selectedPerson as Patient);

            appointmentsListBox.Items.Clear();
            appointmentsListBox.Items.AddRange(appointmentsList.ToArray());
        }

        private void hospitalListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (hospitalListBox.SelectedItem == null)
                return;

            var hospital = hospitalListBox.SelectedItem as Hospital;
            Program.selectedHospital = hospital;
            UpdatePatients();
            UpdateMedics();
        }

        private void patientRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            patientListBox.Visible = true;
            doctorListBox.Visible = false;
            Program.selectedPerson = patientListBox.SelectedItem as Patient;
            doctorListBox.ClearSelected();
        }

        private void doctorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            patientListBox.Visible = false;
            doctorListBox.Visible = true;
            Program.selectedPerson = doctorListBox.SelectedItem as Person;
            patientListBox.ClearSelected();
        }

        private void patientListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (patientListBox.SelectedItem == null)
                return;

            var patient = patientListBox.SelectedItem as Patient;
            Program.selectedPerson = patient;

            UpdateAppointments();
        }

        private void doctorListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (doctorListBox.SelectedItem == null)
                return;

            var doctor = doctorListBox.SelectedItem as Medic;
            Program.selectedPerson = doctor;

            UpdateAppointments();
        }
    }
}
