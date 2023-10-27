using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksForm
{
    public partial class ResultForm : Form
    {
        public ResultForm(String message, bool isEmailSent)
        {
            InitializeComponent();
            resultTextLabel.Text = message;

            if (isEmailSent) emailSentTextLabel.Visible = true;
            else emailSentTextLabel.Visible = false;
        }
    }
}
