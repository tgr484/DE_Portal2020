using DE_Portal.DAL.Models;
using DE_Portal.DAL.Models.KW4;
using DE_Portal2020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DE_Portal.DAL.Interfaces
{
    public interface IKW4
    {
        ChartsModel GetCharts(int userUid);
        AlertsModel GetAlerts(int userUid);
        IEnumerable<ProjectModel> GetProjects(int userUid);

        IEnumerable<TicketModel> GetTickets(int userUid, string userEmail, string userName, string ticketsOnlyAccess, bool isAdmin);
    }
}
