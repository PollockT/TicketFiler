using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics.Tracing;
using System.Diagnostics;

namespace TicketUI
{
    public partial class CreateTicketForm : Form
    {
        public CreateTicketForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to cancel creating the ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ticketBuildCancelButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Ticket creation cancel button clicked-");
        }

        /// <summary>
        /// Button to add ticket to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ticketBuildAddButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Ticket creation button clicked to add to database-");
        }
    }
}
