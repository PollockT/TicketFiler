using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracking
{
    class TicketViewerModel
    {
        public List<TicketModel> Ticket_List { get; set; }
        public EmployeeModel Ticket_Creator { get; set; }
        public Boolean Ticket_Attachment { get; set; }
    }
}
