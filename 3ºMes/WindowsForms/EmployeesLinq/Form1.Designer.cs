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
            this.getAllButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cSurnamesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cMailTextBox = new System.Windows.Forms.TextBox();
            this.cPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cManagerIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cDepartmentIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.cJobIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            // getAllButton
            // 
            this.getAllButton.Location = new System.Drawing.Point(638, 12);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(126, 23);
            this.getAllButton.TabIndex = 1;
            this.getAllButton.Text = "Get all employees";
            this.getAllButton.UseVisualStyleBackColor = true;
            this.getAllButton.Click += new System.EventHandler(this.getAllButton_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // cNameTextBox
            // 
            this.cNameTextBox.Location = new System.Drawing.Point(25, 52);
            this.cNameTextBox.Name = "cNameTextBox";
            this.cNameTextBox.Size = new System.Drawing.Size(179, 22);
            this.cNameTextBox.TabIndex = 1;
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
            // cSurnamesTextBox
            // 
            this.cSurnamesTextBox.Location = new System.Drawing.Point(25, 115);
            this.cSurnamesTextBox.Name = "cSurnamesTextBox";
            this.cSurnamesTextBox.Size = new System.Drawing.Size(179, 22);
            this.cSurnamesTextBox.TabIndex = 3;
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
            // cMailTextBox
            // 
            this.cMailTextBox.Location = new System.Drawing.Point(25, 181);
            this.cMailTextBox.Name = "cMailTextBox";
            this.cMailTextBox.Size = new System.Drawing.Size(179, 22);
            this.cMailTextBox.TabIndex = 5;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getAllButton);
            this.Controls.Add(this.employeesListBox);
            this.Name = "MainForm";
            this.Text = "Employees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox employeesListBox;
        private System.Windows.Forms.Button getAllButton;
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
    }
}

