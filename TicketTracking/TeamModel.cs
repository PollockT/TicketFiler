using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracking
{
    class TeamModel
    {
        public string Team_Name { get; set; }
        public List<EmployeeModel> Team_Member { get; set; }        
        public List<EmployeeModel> Team_Leader { get; set; }
    }
}
