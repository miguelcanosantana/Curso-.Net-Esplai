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
    public partial class MainForm : Form
    {
        public Hospital selectedHospital;


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
            hospitalListBox.DisplayMember = "name";
            hospitalListBox.ValueMember = "id";
            hospitalListBox.Items.AddRange(hospitalList.ToArray());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void hospitalListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedHospital = hospitalListBox.SelectedItem as Hospital;
        }
    }
}
