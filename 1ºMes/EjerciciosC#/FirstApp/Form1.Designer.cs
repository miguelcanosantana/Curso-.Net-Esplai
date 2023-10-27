namespace FirstApp
{
    partial class FirstAppForm1
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
            this.changeNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeNameButton
            // 
            this.changeNameButton.Location = new System.Drawing.Point(301, 200);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(112, 23);
            this.changeNameButton.TabIndex = 0;
            this.changeNameButton.Text = "Change Name";
            this.changeNameButton.UseVisualStyleBackColor = true;
            this.changeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // FirstAppForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeNameButton);
            this.Name = "FirstAppForm1";
            this.Text = "FirstApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeNameButton;
    }
}

