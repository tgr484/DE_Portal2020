using Dapper;
using DE_Portal.DAL.Extensions;
using DE_Portal.DAL.Interfaces;
using DE_Portal.DAL.Models;
using DE_Portal.DAL.Models.KW4;
using DE_Portal.DAL.RawSqlHelpers;
using DE_Portal2020.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DE_Portal.DAL.Repositories
{
    public class KW4Repository : IKW4
    {
        string connectionString = null;
        public KW4Repository(string conn)
        {
            connectionString = conn;
        }

        public ChartsModel GetCharts(int userUid)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var uidAndDateParam = new { ClientID = userUid, NowDate = DateTime.Now.ToString() };
                var uidParam = new { ClientID = userUid };

                var closedTickets = db.QueryFirst<ClosedTickets>(ChartsSqlHelper.ClosedTicketsQuery(), uidAndDateParam);
                var openTickets = db.QueryFirst<OpenTickets>(ChartsSqlHelper.OpenTicketsQuery(), uidParam);
                var alerts = db.QueryFirst<Alerts>(ChartsSqlHelper.AlertsQuery(), uidParam);
                var alertsSummary = db.Query<AlertsSummary>(ChartsSqlHelper.AlertsSumaryQuery(), uidAndDateParam);
                var hardwareFailureSummary = db.QueryFirst<HardwareFailureSummary>(ChartsSqlHelper.HardwareFailuresSummary(), uidParam);
                var hardwareFailureDetails = db.Query<HardwareFailureDetails>(ChartsSqlHelper.HardwareFailuresDetails(), uidParam);
                return new ChartsModel(closedTickets, openTickets, alerts, alertsSummary, hardwareFailureSummary, hardwareFailureDetails);
            }
        }

        public AlertsModel GetAlerts(int userUid)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var uidParam = new { ClientID = userUid };
                var alerts = db.Query<SdsAlert>(AlertsSqlHelper.SdsAlerts(), uidParam);
                var deletedAlerts = db.Query<SdsAlert>(AlertsSqlHelper.Sds_DeletedAlerts(), uidParam);
                return new AlertsModel(alerts, deletedAlerts);
            }
        }

        public IEnumerable<TicketModel> GetTickets(int userUid, string userEmail, string userName, string ticketsOnlyAccess, bool isAdmin)
        {
            string DENetworkMatch = "192.168.11.";
            string DENetworkMatch2 = "95.140.194.";
            string DENetworkMatch3 = "212.42.212.";
            var ticketsLimit = isAdmin ? 5000 : 20;
            Dictionary<int, string> PortalPriorities = new Dictionary<int, string>
                                                       {
                                                           {1, "Low" }, {2, "Medium" }, {3, "High" }
                                                       };
            Dictionary<string, string> allowClientChangeTicketStatus = new Dictionary<string, string>
                                                       {
                                                           { "rumc", "rumc_contact" },
                                                           { "dedemo", "kmozg" },
                                                           { "detest", "detest" }
                                                       };
            string DENetworkPattern = String.Format("({0})|({1})|({2})", DENetworkMatch, DENetworkMatch2, DENetworkMatch3).Replace(".", "\\.");

            var deNetworkRegexp = new System.Text.RegularExpressions.Regex(DENetworkPattern);

            string[] TicketsOnlyAccess = ticketsOnlyAccess.Split(',')
            .Where(i => !String.IsNullOrEmpty(i))
            .Select(i => i.Trim())
            .ToArray();
            bool allowExternalLink = !(TicketsOnlyAccess.Any(i => i.ToLower() == userEmail));
            bool allowReport = false;
            string allowClientChangeTicketStatusOwnerUID = string.Empty;
            if (allowClientChangeTicketStatus.ContainsKey(userName.ToLower()))
            {
                allowClientChangeTicketStatusOwnerUID = allowClientChangeTicketStatus[userName.ToLower()];
                allowReport = true;
            }
            using (var ctx = new KW4_Context())
            {
                var tickets = ctx.Set<Ticket>().Where(t =>
                t.ClientId == userUid                
                )
                .OrderByDescending(t => t.OpenDate)
                .Take(ticketsLimit)
                .Select(t => new TicketModel
                {
                    Id = t.Id,
                    EmailFrom = t.CreatorName(),
                    Subject = t.Subject,
                    Body = t.Body.Replace("<", "&lt;").Replace(">", "&gt;"),
                    StatusId = t.StatusId,
                    Status = t.Status(),
                    OpenDate = t.OpenDate,
                    SessionId = t.TicketId.ToString("n"),
                    AllowChangeStatus = t.Owner != null && !String.IsNullOrEmpty(allowClientChangeTicketStatusOwnerUID) && allowClientChangeTicketStatusOwnerUID == t.Owner.Uid,
                    PortalPriority = t.PortalPriority.HasValue ? PortalPriorities.ContainsKey(t.PortalPriority.Value) ? PortalPriorities[t.PortalPriority.Value] : "" : "",
                    PortalUser = t.PortalUser != null ? t.PortalUser.Name : "",
                    OpenedBy = (allowReport && t.AdminNotes != null) ? (deNetworkRegexp.IsMatch(t.AdminNotes) ? "Opened By DE" : "Non-DE") : "",
                    AllowExternalLink = allowExternalLink
                }).ToList();
                return tickets;
            }
        }

        public IEnumerable<ProjectModel> GetProjects(int userUid)
        {
            using (var ctx = new KW4_Context())
            {
                var projects = ctx.Set<ProjectTrackingProject>().Where(p => p.ClientId == userUid);
                var result = projects.Select(p => new ProjectModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    ClientName = p.Client.ClientName,
                    StartDate = p.StartDate,
                    DeliveryDate = p.DeliveryDate,
                    Description = p.Description,
                    Tl = p.Tl != null ? p.Tl.Name : "",
                    Am = p.Am != null ? p.Am.Name : "",
                    Os = p.Os != null ? p.Os.Name : "",
                    IsActive = !p.Done
                }).ToList();
                return result;
            }
        }
    }
}
