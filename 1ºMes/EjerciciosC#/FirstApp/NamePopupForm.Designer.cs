namespace FirstApp
{
    partial class NamePopupForm
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
            this.finalNameTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finalNameTextLabel
            // 
            this.finalNameTextLabel.AutoSize = true;
            this.finalNameTextLabel.Location = new System.Drawing.Point(156, 158);
            this.finalNameTextLabel.Name = "finalNameTextLabel";
            this.finalNameTextLabel.Size = new System.Drawing.Size(102, 16);
            this.finalNameTextLabel.TabIndex = 0;
            this.finalNameTextLabel.Text = "Unknown Name";
            // 
            // NamePopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalNameTextLabel);
            this.Name = "NamePopupForm";
            this.Text = "NamePopupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label finalNameTextLabel;
    }
}