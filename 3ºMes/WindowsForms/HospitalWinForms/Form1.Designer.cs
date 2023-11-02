namespace HospitalWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.createHospitalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPersonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAppointmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.modifyHospitalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPersonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAppointmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.removeHospitalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePersonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAppointmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.findPatientAppointmentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDoctorAppointmentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAllAppointmentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.patientListBox = new System.Windows.Forms.ListBox();
            this.doctorListBox = new System.Windows.Forms.ListBox();
            this.patientRadioButton = new System.Windows.Forms.RadioButton();
            this.doctorRadioButton = new System.Windows.Forms.RadioButton();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDropDownButton,
            this.modifyDropDownButton,
            this.removeDropDownButton,
            this.findDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1053, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createDropDownButton
            // 
            this.createDropDownButton.AccessibleName = "";
            this.createDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createHospitalMenuItem,
            this.createPersonMenuItem,
            this.createAppointmentMenuItem});
            this.createDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("createDropDownButton.Image")));
            this.createDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createDropDownButton.Name = "createDropDownButton";
            this.createDropDownButton.Size = new System.Drawing.Size(66, 28);
            this.createDropDownButton.Text = "Create";
            // 
            // createHospitalMenuItem
            // 
            this.createHospitalMenuItem.Name = "createHospitalMenuItem";
            this.createHospitalMenuItem.Size = new System.Drawing.Size(180, 26);
            this.createHospitalMenuItem.Text = "Hospital";
            this.createHospitalMenuItem.Click += new System.EventHandler(this.createHospitalMenuItem_Click);
            // 
            // createPersonMenuItem
            // 
            this.createPersonMenuItem.Name = "createPersonMenuItem";
            this.createPersonMenuItem.Size = new System.Drawing.Size(180, 26);
            this.createPersonMenuItem.Text = "Person";
            // 
            // createAppointmentMenuItem
            // 
            this.createAppointmentMenuItem.Name = "createAppointmentMenuItem";
            this.createAppointmentMenuItem.Size = new System.Drawing.Size(180, 26);
            this.createAppointmentMenuItem.Text = "Appointment";
            // 
            // modifyDropDownButton
            // 
            this.modifyDropDownButton.AccessibleName = "";
            this.modifyDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modifyDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyHospitalMenuItem,
            this.modifyPersonMenuItem,
            this.modifyAppointmentMenuItem});
            this.modifyDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("modifyDropDownButton.Image")));
            this.modifyDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modifyDropDownButton.Name = "modifyDropDownButton";
            this.modifyDropDownButton.Size = new System.Drawing.Size(70, 28);
            this.modifyDropDownButton.Text = "Modify";
            // 
            // modifyHospitalMenuItem
            // 
            this.modifyHospitalMenuItem.Name = "modifyHospitalMenuItem";
            this.modifyHospitalMenuItem.Size = new System.Drawing.Size(180, 26);
            this.modifyHospitalMenuItem.Text = "Hospital";
            // 
            // modifyPersonMenuItem
            // 
            this.modifyPersonMenuItem.Name = "modifyPersonMenuItem";
            this.modifyPersonMenuItem.Size = new System.Drawing.Size(180, 26);
            this.modifyPersonMenuItem.Text = "Person";
            // 
            // modifyAppointmentMenuItem
            // 
            this.modifyAppointmentMenuItem.Name = "modifyAppointmentMenuItem";
            this.modifyAppointmentMenuItem.Size = new System.Drawing.Size(180, 26);
            this.modifyAppointmentMenuItem.Text = "Appointment";
            // 
            // removeDropDownButton
            // 
            this.removeDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeHospitalMenuItem,
            this.removePersonMenuItem,
            this.removeAppointmentMenuItem});
            this.removeDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("removeDropDownButton.Image")));
            this.removeDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeDropDownButton.Name = "removeDropDownButton";
            this.removeDropDownButton.Size = new System.Drawing.Size(77, 28);
            this.removeDropDownButton.Text = "Remove";
            // 
            // removeHospitalMenuItem
            // 
            this.removeHospitalMenuItem.Name = "removeHospitalMenuItem";
            this.removeHospitalMenuItem.Size = new System.Drawing.Size(180, 26);
            this.removeHospitalMenuItem.Text = "Hospital";
            // 
            // removePersonMenuItem
            // 
            this.removePersonMenuItem.Name = "removePersonMenuItem";
            this.removePersonMenuItem.Size = new System.Drawing.Size(180, 26);
            this.removePersonMenuItem.Text = "Person";
            // 
            // removeAppointmentMenuItem
            // 
            this.removeAppointmentMenuItem.Name = "removeAppointmentMenuItem";
            this.removeAppointmentMenuItem.Size = new System.Drawing.Size(180, 26);
            this.removeAppointmentMenuItem.Text = "Appointment";
            // 
            // findDropDownButton
            // 
            this.findDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findPatientAppointmentsMenuItem,
            this.findDoctorAppointmentsMenuItem,
            this.findAllAppointmentsMenuItem});
            this.findDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("findDropDownButton.Image")));
            this.findDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findDropDownButton.Name = "findDropDownButton";
            this.findDropDownButton.Size = new System.Drawing.Size(51, 28);
            this.findDropDownButton.Text = "Find";
            // 
            // findPatientAppointmentsMenuItem
            // 
            this.findPatientAppointmentsMenuItem.Name = "findPatientAppointmentsMenuItem";
            this.findPatientAppointmentsMenuItem.Size = new System.Drawing.Size(236, 26);
            this.findPatientAppointmentsMenuItem.Text = "Patient Appointments";
            // 
            // findDoctorAppointmentsMenuItem
            // 
            this.findDoctorAppointmentsMenuItem.Name = "findDoctorAppointmentsMenuItem";
            this.findDoctorAppointmentsMenuItem.Size = new System.Drawing.Size(236, 26);
            this.findDoctorAppointmentsMenuItem.Text = "Doctor Appointments";
            // 
            // findAllAppointmentsMenuItem
            // 
            this.findAllAppointmentsMenuItem.Name = "findAllAppointmentsMenuItem";
            this.findAllAppointmentsMenuItem.Size = new System.Drawing.Size(236, 26);
            this.findAllAppointmentsMenuItem.Text = "All Appointments";
            // 
            // hospitalListBox
            // 
            this.hospitalListBox.FormattingEnabled = true;
            this.hospitalListBox.ItemHeight = 16;
            this.hospitalListBox.Location = new System.Drawing.Point(12, 58);
            this.hospitalListBox.Name = "hospitalListBox";
            this.hospitalListBox.Size = new System.Drawing.Size(236, 532);
            this.hospitalListBox.TabIndex = 1;
            this.hospitalListBox.SelectedValueChanged += new System.EventHandler(this.hospitalListBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hospitals";
            // 
            // appointmentsListBox
            // 
            this.appointmentsListBox.FormattingEnabled = true;
            this.appointmentsListBox.ItemHeight = 16;
            this.appointmentsListBox.Location = new System.Drawing.Point(805, 58);
            this.appointmentsListBox.Name = "appointmentsListBox";
            this.appointmentsListBox.Size = new System.Drawing.Size(236, 532);
            this.appointmentsListBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(802, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Appointments Filter";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.patientListBox);
            this.flowLayoutPanel1.Controls.Add(this.doctorListBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(254, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(485, 522);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // patientListBox
            // 
            this.patientListBox.FormattingEnabled = true;
            this.patientListBox.ItemHeight = 16;
            this.patientListBox.Location = new System.Drawing.Point(3, 3);
            this.patientListBox.Name = "patientListBox";
            this.patientListBox.Size = new System.Drawing.Size(236, 516);
            this.patientListBox.TabIndex = 11;
            // 
            // doctorListBox
            // 
            this.doctorListBox.FormattingEnabled = true;
            this.doctorListBox.ItemHeight = 16;
            this.doctorListBox.Location = new System.Drawing.Point(245, 3);
            this.doctorListBox.Name = "doctorListBox";
            this.doctorListBox.Size = new System.Drawing.Size(236, 516);
            this.doctorListBox.TabIndex = 12;
            // 
            // patientRadioButton
            // 
            this.patientRadioButton.AutoSize = true;
            this.patientRadioButton.Location = new System.Drawing.Point(254, 42);
            this.patientRadioButton.Name = "patientRadioButton";
            this.patientRadioButton.Size = new System.Drawing.Size(76, 20);
            this.patientRadioButton.TabIndex = 10;
            this.patientRadioButton.TabStop = true;
            this.patientRadioButton.Text = "Patients";
            this.patientRadioButton.UseVisualStyleBackColor = true;
            this.patientRadioButton.CheckedChanged += new System.EventHandler(this.patientRadioButton_CheckedChanged);
            // 
            // doctorRadioButton
            // 
            this.doctorRadioButton.AutoSize = true;
            this.doctorRadioButton.Location = new System.Drawing.Point(336, 42);
            this.doctorRadioButton.Name = "doctorRadioButton";
            this.doctorRadioButton.Size = new System.Drawing.Size(75, 20);
            this.doctorRadioButton.TabIndex = 11;
            this.doctorRadioButton.TabStop = true;
            this.doctorRadioButton.Text = "Doctors";
            this.doctorRadioButton.UseVisualStyleBackColor = true;
            this.doctorRadioButton.CheckedChanged += new System.EventHandler(this.doctorRadioButton_CheckedChanged);
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(HospitalWinForms.MainForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 608);
            this.Controls.Add(this.doctorRadioButton);
            this.Controls.Add(this.patientRadioButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appointmentsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hospitalListBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Hospitals Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton createDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem createHospitalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPersonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAppointmentMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton modifyDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem modifyHospitalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPersonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAppointmentMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton removeDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem removeHospitalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePersonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAppointmentMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton findDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem findPatientAppointmentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDoctorAppointmentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAllAppointmentsMenuItem;
        private System.Windows.Forms.ListBox hospitalListBox;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox appointmentsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton patientRadioButton;
        private System.Windows.Forms.ListBox patientListBox;
        private System.Windows.Forms.ListBox doctorListBox;
        private System.Windows.Forms.RadioButton doctorRadioButton;
    }
}

