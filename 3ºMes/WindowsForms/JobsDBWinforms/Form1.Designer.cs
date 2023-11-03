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
            this.SuspendLayout();
            // 
            // connectToDBButton
            // 
            this.connectToDBButton.Location = new System.Drawing.Point(648, 397);
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
            this.closeDBButton.Location = new System.Drawing.Point(12, 397);
            this.closeDBButton.Name = "closeDBButton";
            this.closeDBButton.Size = new System.Drawing.Size(140, 25);
            this.closeDBButton.TabIndex = 2;
            this.closeDBButton.Text = "Close Connection";
            this.closeDBButton.UseVisualStyleBackColor = true;
            this.closeDBButton.Click += new System.EventHandler(this.closeDBButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeDBButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.connectToDBButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectToDBButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button closeDBButton;
    }
}

