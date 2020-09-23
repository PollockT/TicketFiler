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

        /// <summary>
        /// Label that lets the user connect with administrator via default email application on computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginContactLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Trace.WriteLine("Link label clicked to open email application");
            //TODO: open default email client and fill out to sender with admin information
        }
    }
}
