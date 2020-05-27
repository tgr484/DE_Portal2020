using System;
using System.Collections.Generic;
using System.Text;

namespace DE_Portal.DAL.Models
{
    public class TicketModel
    {
        public int Id;
        public string EmailFrom;
        public string Subject;
        public string Body;
        public int StatusId;
        public string Status;
        public DateTime? OpenDate;
        public string SessionId;
        public bool AllowChangeStatus;
        public string PortalPriority;
        public string PortalPriorityId;
        public string PortalUser;
        public string PortalUserId;
        public string OpenedBy;
        public bool AllowExternalLink;
    }
}
