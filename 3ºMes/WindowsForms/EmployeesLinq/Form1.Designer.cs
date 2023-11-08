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
            this.SuspendLayout();
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 16;
            this.employeesListBox.Location = new System.Drawing.Point(12, 22);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(385, 404);
            this.employeesListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeesListBox);
            this.Name = "MainForm";
            this.Text = "Employees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox employeesListBox;
    }
}

