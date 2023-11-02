namespace HospitalWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.hospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createDropDownButton
            // 
            this.createDropDownButton.AccessibleName = "";
            this.createDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospitalToolStripMenuItem,
            this.personToolStripMenuItem,
            this.appointmentToolStripMenuItem});
            this.createDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("createDropDownButton.Image")));
            this.createDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createDropDownButton.Name = "createDropDownButton";
            this.createDropDownButton.Size = new System.Drawing.Size(66, 24);
            this.createDropDownButton.Text = "Create";
            // 
            // hospitalToolStripMenuItem
            // 
            this.hospitalToolStripMenuItem.Name = "hospitalToolStripMenuItem";
            this.hospitalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hospitalToolStripMenuItem.Text = "Hospital";
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personToolStripMenuItem.Text = "Person";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton createDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem hospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
    }
}

