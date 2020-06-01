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
using System.Globalization;
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

        public IEnumerable<ScheduledEventModel> GetEvents(int userId, DateTime start, DateTime end)
        {
            using (var ctx = new KW4_Context())
            {
                int[] allowTickedStatuses = new int[] { 8, 2 };

                var tickets = ctx.Set<Ticket>()
                        .Where(t => t.ClientId == userId
                            && allowTickedStatuses.Contains(t.StatusId)
                            && t.OpenDate >= start
                            && t.OpenDate < end
                            )
                        .ToList().OrderByDescending(t => t.OpenDate);
                var result = tickets.Select(t => new ScheduledEventModel() { /*id = t.Id.ToString(),*/ title = t.Subject, start = t.OpenDate, url = "../Tickets/Ticket.aspx?TicketId=" + t.Id + "&SessionId=" + t.TicketId, className = "bg-info" }).ToList();

                var checkpoints = ctx.Set<RecuringTicket>().
                           Where(cp => cp.Active && cp.Client == userId
                               && cp.StartDate < end
                               && (cp.EndDate == null || cp.EndDate >= start)
                           );
                List<ScheduledEventModel> checkpointEvents = new List<ScheduledEventModel>();
                foreach (var checkpoint in checkpoints)
                {
                    string schedule = checkpoint.Schedule;
                    switch (schedule[0])
                    {
                        case 'D':
                            {
                                while (checkpoint.StartDate < end)
                                {
                                    if (checkpoint.StartDate >= start)
                                    {
                                        checkpointEvents.Add(new ScheduledEventModel() { title = checkpoint.Subject, start = GetDate(checkpoint.GenerateTime, checkpoint.StartDate) });
                                    }

                                    var period = Convert.ToInt32(schedule.Substring(1));
                                    checkpoint.StartDate = checkpoint.StartDate.AddDays(period);
                                }
                                break;
                            }
                        case 'W':
                            {
                                var ws = schedule.Substring(1).Split(':');
                                var weekDays = ws[1].Split(',').Select(w => int.Parse(w)).Cast<DayOfWeek>().ToList();

                                var realStartDate = checkpoint.StartDate;
                                var startDate = checkpoint.StartDate.AddDays(-1 * (int)checkpoint.StartDate.DayOfWeek);

                                while (startDate < end)
                                {
                                    foreach (var dayIndex in weekDays)
                                    {
                                        var tempDate = startDate.AddDays((int)dayIndex);
                                        if (tempDate >= start && tempDate >= realStartDate)
                                        {
                                            checkpointEvents.Add(new ScheduledEventModel() { title = checkpoint.Subject, start = GetDate(checkpoint.GenerateTime, tempDate) });
                                        }
                                    }

                                    var period = Convert.ToInt32(ws[0]);
                                    startDate = startDate.AddDays(7 * period);
                                }
                                break;
                            }
                        case 'M':
                            {
                                var ms = schedule.Substring(2).Split(':').ToArray();
                                var realStartDate = checkpoint.StartDate;
                                DateTime ticketDate;
                                if (schedule[1] == 'D')
                                {
                                    ticketDate = new DateTime(realStartDate.Year, realStartDate.Month, Convert.ToInt32(ms[0]));
                                    while (ticketDate < end)
                                    {
                                        if (ticketDate >= start && ticketDate >= realStartDate)
                                        {
                                            checkpointEvents.Add(new ScheduledEventModel() { title = checkpoint.Subject, start = GetDate(checkpoint.GenerateTime, ticketDate) });
                                        }
                                        var period = Convert.ToInt32(ms[1]);
                                        ticketDate = ticketDate.AddMonths(period);
                                    }
                                }
                                else
                                {
                                    if (ms[2] == "0")
                                        continue;

                                    ticketDate = new DateTime(realStartDate.Year, realStartDate.Month, 1);
                                    int dayOfWeek = Convert.ToInt32(ms[1]);

                                    while (ticketDate < end)
                                    {
                                        List<DateTime> daysInMonth = new List<DateTime>();
                                        for (int i = 1; i <= System.DateTime.DaysInMonth(ticketDate.Year, ticketDate.Month); i++)
                                        {
                                            DateTime newDate = new DateTime(ticketDate.Year, ticketDate.Month, i);
                                            if (dayOfWeek == Convert.ToInt32(newDate.DayOfWeek))
                                            {
                                                daysInMonth.Add(newDate);
                                            }
                                        }

                                        switch (ms[0])
                                        {
                                            case "-1":
                                                ticketDate = daysInMonth.Last();
                                                break;
                                            default:
                                                ticketDate = daysInMonth[Convert.ToInt32(ms[0]) - 1];
                                                break;
                                        }

                                        if (ticketDate >= start && ticketDate >= realStartDate)
                                        {
                                            checkpointEvents.Add(new ScheduledEventModel() { title = checkpoint.Subject, start = GetDate(checkpoint.GenerateTime, ticketDate) });
                                        }

                                        var period = Convert.ToInt32(ms[2]);
                                        ticketDate = ticketDate.AddMonths(period);
                                    }
                                }
                                break;
                            }
                    }
                }
                return result.Concat(checkpointEvents);
            }
        }

        private DateTime  GetDate(int time, DateTime date)
        {
            DateTime eventTime = new DateTime(TimeSpan.FromSeconds(time).Ticks);
            DateTime eventDate = new DateTime(date.Year, date.Month, date.Day, eventTime.Hour, eventTime.Minute, 0);

            return eventDate;
        }
    }
}
