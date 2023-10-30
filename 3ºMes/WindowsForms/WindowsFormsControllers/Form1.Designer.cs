namespace WindowsFormsControllers
{
    partial class ControllersForm
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
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.sexGroupBox = new System.Windows.Forms.GroupBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.sexGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 16;
            this.countriesListBox.Items.AddRange(new object[] {
            "España",
            "Francia",
            "Italia",
            "Reino Unido",
            "Irlanda",
            "Alemania",
            "Grecia"});
            this.countriesListBox.Location = new System.Drawing.Point(12, 12);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(233, 148);
            this.countriesListBox.TabIndex = 0;
            this.countriesListBox.SelectedValueChanged += new System.EventHandler(this.countriesListBox_SelectedValueChanged);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(12, 166);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(233, 22);
            this.countryTextBox.TabIndex = 1;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(6, 21);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(58, 20);
            this.maleRadioButton.TabIndex = 2;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // sexGroupBox
            // 
            this.sexGroupBox.Controls.Add(this.sexLabel);
            this.sexGroupBox.Controls.Add(this.femaleRadioButton);
            this.sexGroupBox.Controls.Add(this.maleRadioButton);
            this.sexGroupBox.Location = new System.Drawing.Point(251, 12);
            this.sexGroupBox.Name = "sexGroupBox";
            this.sexGroupBox.Size = new System.Drawing.Size(200, 102);
            this.sexGroupBox.TabIndex = 3;
            this.sexGroupBox.TabStop = false;
            this.sexGroupBox.Text = "Sex";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(7, 80);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(104, 16);
            this.sexLabel.TabIndex = 4;
            this.sexLabel.Text = "No choosen sex";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(6, 47);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(74, 20);
            this.femaleRadioButton.TabIndex = 3;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleRadioButton_CheckedChanged);
            // 
            // ControllersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sexGroupBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.countriesListBox);
            this.Name = "ControllersForm";
            this.Text = "Controllers Form";
            this.sexGroupBox.ResumeLayout(false);
            this.sexGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.GroupBox sexGroupBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.RadioButton femaleRadioButton;
    }
}

