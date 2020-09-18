using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracking
{
    class TicketModel
    {
        public string Ticket_ID { get; set; }
        public int Ticket_Priority { get; set; }
        public string Ticket_Category { get; set; }
        public string Ticket_Description { get; set; }
        public string Ticket_Status { get; set; }
        public FileStream Ticket_Attachment { get; set; }
    }
}
