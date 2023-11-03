using System.Windows.Forms;

namespace JobsDBWinforms
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
            this.connectToDBButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.closeDBButton = new System.Windows.Forms.Button();
            this.jobNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uploadJobButton = new System.Windows.Forms.Button();
            this.maxSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jobsListBox = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectToDBButton
            // 
            this.connectToDBButton.Location = new System.Drawing.Point(762, 339);
            this.connectToDBButton.Name = "connectToDBButton";
            this.connectToDBButton.Size = new System.Drawing.Size(140, 25);
            this.connectToDBButton.TabIndex = 0;
            this.connectToDBButton.Text = "Connect To DB";
            this.connectToDBButton.UseVisualStyleBackColor = true;
            this.connectToDBButton.Click += new System.EventHandler(this.connectToDBButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(9, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(91, 16);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "                            ";
            // 
            // closeDBButton
            // 
            this.closeDBButton.Location = new System.Drawing.Point(615, 339);
            this.closeDBButton.Name = "closeDBButton";
            this.closeDBButton.Size = new System.Drawing.Size(140, 25);
            this.closeDBButton.TabIndex = 2;
            this.closeDBButton.Text = "Close Connection";
            this.closeDBButton.UseVisualStyleBackColor = true;
            this.closeDBButton.Click += new System.EventHandler(this.closeDBButton_Click);
            // 
            // jobNameTextBox
            // 
            this.jobNameTextBox.Location = new System.Drawing.Point(6, 19);
            this.jobNameTextBox.Name = "jobNameTextBox";
            this.jobNameTextBox.Size = new System.Drawing.Size(284, 22);
            this.jobNameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Job Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uploadJobButton);
            this.panel1.Controls.Add(this.maxSalaryTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.minSalaryTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.jobNameTextBox);
            this.panel1.Location = new System.Drawing.Point(609, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 197);
            this.panel1.TabIndex = 5;
            // 
            // uploadJobButton
            // 
            this.uploadJobButton.Location = new System.Drawing.Point(198, 166);
            this.uploadJobButton.Name = "uploadJobButton";
            this.uploadJobButton.Size = new System.Drawing.Size(92, 30);
            this.uploadJobButton.TabIndex = 9;
            this.uploadJobButton.Text = "Upload Job";
            this.uploadJobButton.UseVisualStyleBackColor = true;
            this.uploadJobButton.Click += new System.EventHandler(this.uploadJobButton_Click);
            // 
            // maxSalaryTextBox
            // 
            this.maxSalaryTextBox.Location = new System.Drawing.Point(6, 128);
            this.maxSalaryTextBox.Name = "maxSalaryTextBox";
            this.maxSalaryTextBox.Size = new System.Drawing.Size(284, 22);
            this.maxSalaryTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Salary";
            // 
            // minSalaryTextBox
            // 
            this.minSalaryTextBox.Location = new System.Drawing.Point(6, 74);
            this.minSalaryTextBox.Name = "minSalaryTextBox";
            this.minSalaryTextBox.Size = new System.Drawing.Size(284, 22);
            this.minSalaryTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min Salary";
            // 
            // jobsListBox
            // 
            this.jobsListBox.FormattingEnabled = true;
            this.jobsListBox.ItemHeight = 16;
            this.jobsListBox.Location = new System.Drawing.Point(12, 8);
            this.jobsListBox.Name = "jobsListBox";
            this.jobsListBox.Size = new System.Drawing.Size(594, 356);
            this.jobsListBox.TabIndex = 6;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(612, 211);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(41, 45);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "🔁";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 376);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.jobsListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeDBButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.connectToDBButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectToDBButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button closeDBButton;
        private TextBox jobNameTextBox;
        private Label label1;
        private Panel panel1;
        private Button uploadJobButton;
        private TextBox maxSalaryTextBox;
        private Label label3;
        private TextBox minSalaryTextBox;
        private Label label2;
        private ListBox jobsListBox;
        private Button refreshButton;
    }
}

