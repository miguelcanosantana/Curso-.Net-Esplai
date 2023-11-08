namespace EmployeesLinq
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
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cJobIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.cDepartmentIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cManagerIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cMailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cSurnamesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.fCityTextBox = new System.Windows.Forms.TextBox();
            this.fCityCheck = new System.Windows.Forms.CheckBox();
            this.fSurnameText = new System.Windows.Forms.TextBox();
            this.fSurnameCheck = new System.Windows.Forms.CheckBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameCheck = new System.Windows.Forms.CheckBox();
            this.fSqlRadio = new System.Windows.Forms.RadioButton();
            this.fLinQRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 16;
            this.employeesListBox.Location = new System.Drawing.Point(12, 12);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(620, 404);
            this.employeesListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cJobIdTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.createEmployeeButton);
            this.groupBox1.Controls.Add(this.cDepartmentIdTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cManagerIdTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cSalaryTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cPhoneTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cMailTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cSurnamesTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 230);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Employee";
            // 
            // cJobIdTextBox
            // 
            this.cJobIdTextBox.Location = new System.Drawing.Point(225, 115);
            this.cJobIdTextBox.Name = "cJobIdTextBox";
            this.cJobIdTextBox.Size = new System.Drawing.Size(179, 22);
            this.cJobIdTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Job Id";
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.Location = new System.Drawing.Point(427, 162);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(179, 41);
            this.createEmployeeButton.TabIndex = 14;
            this.createEmployeeButton.Text = "Submit";
            this.createEmployeeButton.UseVisualStyleBackColor = true;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // cDepartmentIdTextBox
            // 
            this.cDepartmentIdTextBox.Location = new System.Drawing.Point(427, 52);
            this.cDepartmentIdTextBox.Name = "cDepartmentIdTextBox";
            this.cDepartmentIdTextBox.Size = new System.Drawing.Size(179, 22);
            this.cDepartmentIdTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Department Id (Optional)";
            // 
            // cManagerIdTextBox
            // 
            this.cManagerIdTextBox.Location = new System.Drawing.Point(427, 115);
            this.cManagerIdTextBox.Name = "cManagerIdTextBox";
            this.cManagerIdTextBox.Size = new System.Drawing.Size(179, 22);
            this.cManagerIdTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Manager Id (Optional)";
            // 
            // cSalaryTextBox
            // 
            this.cSalaryTextBox.Location = new System.Drawing.Point(225, 181);
            this.cSalaryTextBox.Name = "cSalaryTextBox";
            this.cSalaryTextBox.Size = new System.Drawing.Size(179, 22);
            this.cSalaryTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salary";
            // 
            // cPhoneTextBox
            // 
            this.cPhoneTextBox.Location = new System.Drawing.Point(225, 52);
            this.cPhoneTextBox.Name = "cPhoneTextBox";
            this.cPhoneTextBox.Size = new System.Drawing.Size(179, 22);
            this.cPhoneTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // cMailTextBox
            // 
            this.cMailTextBox.Location = new System.Drawing.Point(25, 181);
            this.cMailTextBox.Name = "cMailTextBox";
            this.cMailTextBox.Size = new System.Drawing.Size(179, 22);
            this.cMailTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail";
            // 
            // cSurnamesTextBox
            // 
            this.cSurnamesTextBox.Location = new System.Drawing.Point(25, 115);
            this.cSurnamesTextBox.Name = "cSurnamesTextBox";
            this.cSurnamesTextBox.Size = new System.Drawing.Size(179, 22);
            this.cSurnamesTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surnames";
            // 
            // cNameTextBox
            // 
            this.cNameTextBox.Location = new System.Drawing.Point(25, 52);
            this.cNameTextBox.Name = "cNameTextBox";
            this.cNameTextBox.Size = new System.Drawing.Size(179, 22);
            this.cNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fLinQRadio);
            this.groupBox2.Controls.Add(this.fSqlRadio);
            this.groupBox2.Controls.Add(this.filterButton);
            this.groupBox2.Controls.Add(this.fCityTextBox);
            this.groupBox2.Controls.Add(this.fCityCheck);
            this.groupBox2.Controls.Add(this.fSurnameText);
            this.groupBox2.Controls.Add(this.fSurnameCheck);
            this.groupBox2.Controls.Add(this.fNameTextBox);
            this.groupBox2.Controls.Add(this.fNameCheck);
            this.groupBox2.Location = new System.Drawing.Point(639, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 651);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter By";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(7, 231);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(215, 41);
            this.filterButton.TabIndex = 17;
            this.filterButton.Text = "Get filtered";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // fCityTextBox
            // 
            this.fCityTextBox.Location = new System.Drawing.Point(7, 188);
            this.fCityTextBox.Name = "fCityTextBox";
            this.fCityTextBox.Size = new System.Drawing.Size(215, 22);
            this.fCityTextBox.TabIndex = 5;
            // 
            // fCityCheck
            // 
            this.fCityCheck.AutoSize = true;
            this.fCityCheck.Location = new System.Drawing.Point(7, 162);
            this.fCityCheck.Name = "fCityCheck";
            this.fCityCheck.Size = new System.Drawing.Size(51, 20);
            this.fCityCheck.TabIndex = 4;
            this.fCityCheck.Text = "City";
            this.fCityCheck.UseVisualStyleBackColor = true;
            // 
            // fSurnameText
            // 
            this.fSurnameText.Location = new System.Drawing.Point(7, 121);
            this.fSurnameText.Name = "fSurnameText";
            this.fSurnameText.Size = new System.Drawing.Size(215, 22);
            this.fSurnameText.TabIndex = 3;
            // 
            // fSurnameCheck
            // 
            this.fSurnameCheck.AutoSize = true;
            this.fSurnameCheck.Location = new System.Drawing.Point(7, 95);
            this.fSurnameCheck.Name = "fSurnameCheck";
            this.fSurnameCheck.Size = new System.Drawing.Size(90, 20);
            this.fSurnameCheck.TabIndex = 2;
            this.fSurnameCheck.Text = "Surnames";
            this.fSurnameCheck.UseVisualStyleBackColor = true;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(7, 54);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(215, 22);
            this.fNameTextBox.TabIndex = 1;
            // 
            // fNameCheck
            // 
            this.fNameCheck.AutoSize = true;
            this.fNameCheck.Location = new System.Drawing.Point(7, 28);
            this.fNameCheck.Name = "fNameCheck";
            this.fNameCheck.Size = new System.Drawing.Size(66, 20);
            this.fNameCheck.TabIndex = 0;
            this.fNameCheck.Text = "Name";
            this.fNameCheck.UseVisualStyleBackColor = true;
            // 
            // fSqlRadio
            // 
            this.fSqlRadio.AutoSize = true;
            this.fSqlRadio.Location = new System.Drawing.Point(67, 304);
            this.fSqlRadio.Name = "fSqlRadio";
            this.fSqlRadio.Size = new System.Drawing.Size(82, 20);
            this.fSqlRadio.TabIndex = 18;
            this.fSqlRadio.TabStop = true;
            this.fSqlRadio.Text = "Use SQL";
            this.fSqlRadio.UseVisualStyleBackColor = true;
            this.fSqlRadio.CheckedChanged += new System.EventHandler(this.fSqlRadio_CheckedChanged);
            // 
            // fLinQRadio
            // 
            this.fLinQRadio.AutoSize = true;
            this.fLinQRadio.Location = new System.Drawing.Point(66, 278);
            this.fLinQRadio.Name = "fLinQRadio";
            this.fLinQRadio.Size = new System.Drawing.Size(83, 20);
            this.fLinQRadio.TabIndex = 19;
            this.fLinQRadio.TabStop = true;
            this.fLinQRadio.Text = "Use LinQ";
            this.fLinQRadio.UseVisualStyleBackColor = true;
            this.fLinQRadio.CheckedChanged += new System.EventHandler(this.fLinQRadio_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeesListBox);
            this.Name = "MainForm";
            this.Text = "Employees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox employeesListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cSurnamesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cMailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cPhoneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cSalaryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cManagerIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cDepartmentIdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createEmployeeButton;
        private System.Windows.Forms.TextBox cJobIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.CheckBox fNameCheck;
        private System.Windows.Forms.TextBox fSurnameText;
        private System.Windows.Forms.CheckBox fSurnameCheck;
        private System.Windows.Forms.TextBox fCityTextBox;
        private System.Windows.Forms.CheckBox fCityCheck;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.RadioButton fLinQRadio;
        private System.Windows.Forms.RadioButton fSqlRadio;
    }
}

