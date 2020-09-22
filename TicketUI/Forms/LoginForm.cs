using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics.Tracing;
using System.Diagnostics;

namespace TicketUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to quit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginQuitButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Quit button clicked-");
            System.Windows.Forms.Application.Exit();
            Trace.WriteLine("Application Closed-");
        }
    }
}
