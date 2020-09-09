using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracking
{
    class AccountInfoModel
    {
        public string Employee_ID { get; set; }
        public string Account_Name { get; set; }
        public string Account_Password { get; set; }
        public string Account_Email { get; set; }
        public string Secret_Answer { get; set; }
        public string Secret_Password { get; set; }
    }
}
