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
    public partial class ViewTicketForm : Form
    {
        public ViewTicketForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to update ticket on database SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ticketUpdateButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Update button clicked-");

            Trace.WriteLine("Information updated at database-");
        }

        /// <summary>
        /// Button to close form and all changes to ticket will be trashed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ticketCancelButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Cancel Button clicked-");
            this.Close();//form close
            Trace.WriteLine("Ticket Form closed, application should stay open-");
        }

        /// <summary>
        /// Button to mark the ticket as closed on database SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ticketCloseButton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Ticket close button clicked-");

            Trace.WriteLine("Ticket marked as closed in database");
        }
    }
}
