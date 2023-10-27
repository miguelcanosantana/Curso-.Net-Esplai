namespace TasksForm
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.emailSentTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextLabel.ForeColor = System.Drawing.Color.Green;
            this.resultTextLabel.Location = new System.Drawing.Point(12, 9);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(75, 31);
            this.resultTextLabel.TabIndex = 0;
            this.resultTextLabel.Text = "label1";
            // 
            // emailSentTextLabel
            // 
            this.emailSentTextLabel.AutoSize = true;
            this.emailSentTextLabel.Font = new System.Drawing.Font("Comic Sans MS", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSentTextLabel.ForeColor = System.Drawing.Color.Green;
            this.emailSentTextLabel.Location = new System.Drawing.Point(12, 394);
            this.emailSentTextLabel.Name = "emailSentTextLabel";
            this.emailSentTextLabel.Size = new System.Drawing.Size(264, 48);
            this.emailSentTextLabel.TabIndex = 1;
            this.emailSentTextLabel.Text = "Email was sent";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailSentTextLabel);
            this.Controls.Add(this.resultTextLabel);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultTextLabel;
        private System.Windows.Forms.Label emailSentTextLabel;
    }
}