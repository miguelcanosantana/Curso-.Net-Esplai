namespace OrmTestLinq
{
    partial class Form1
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
            this.getAllEmployeesButton = new System.Windows.Forms.Button();
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // getAllEmployeesButton
            // 
            this.getAllEmployeesButton.Location = new System.Drawing.Point(12, 415);
            this.getAllEmployeesButton.Name = "getAllEmployeesButton";
            this.getAllEmployeesButton.Size = new System.Drawing.Size(133, 23);
            this.getAllEmployeesButton.TabIndex = 0;
            this.getAllEmployeesButton.Text = "Get All Employees";
            this.getAllEmployeesButton.UseVisualStyleBackColor = true;
            this.getAllEmployeesButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 16;
            this.employeesListBox.Location = new System.Drawing.Point(3, 12);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(794, 388);
            this.employeesListBox.TabIndex = 1;
            this.employeesListBox.SelectedIndexChanged += new System.EventHandler(this.employeesListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeesListBox);
            this.Controls.Add(this.getAllEmployeesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getAllEmployeesButton;
        private System.Windows.Forms.ListBox employeesListBox;
    }
}

