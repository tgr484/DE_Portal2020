using DE_Portal.DAL.Models.KW4;
using System;
using System.Collections.Generic;
using System.Text;

namespace DE_Portal.DAL.Extensions
{
    public static class TicketStatusExtension
    {
        public static string Status(this Ticket ticket)
        {
            string status = string.Empty;
            switch (ticket.StatusId)
            {
                case 8: status = "Pending"; break;
                case 9: status = "Close Pending"; break;
                case 1: status = "New"; break;
                case 2: status = "In Process"; break;
                case 3: status = "Closed"; break;
                case 4: status = "Rejected"; break;
            }
            return status;
        }
    }
}
