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
    public partial class NamePopupForm : Form
    {
        public NamePopupForm(String name)
        {
            InitializeComponent();

            finalNameTextLabel.Text = name;
        }
    }
}
