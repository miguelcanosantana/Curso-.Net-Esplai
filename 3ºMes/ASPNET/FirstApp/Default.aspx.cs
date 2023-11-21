﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TestButton_Click(object sender, EventArgs e)
        {
            TestButton.Text = "OK";
        }

        protected void WeekDayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            WeekDayLabel.Text = WeekDayListBox.SelectedItem.ToString();
        }
    }
}