﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class FirstAppForm1 : Form
    {
        public FirstAppForm1()
        {
            InitializeComponent();
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var namePopupForm = new NamePopupForm(name);
            namePopupForm.Show();
        }
    }
}
