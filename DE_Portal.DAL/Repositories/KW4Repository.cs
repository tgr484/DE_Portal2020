using Dapper;
using DE_Portal.DAL.Interfaces;
using DE_Portal.DAL.RawSqlHelpers;
using DE_Portal2020.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
