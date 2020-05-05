using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Projects
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
        public int MonthlyServices { get; set; }
        public DateTime? DateRecieved { get; set; }
        public DateTime? ScopeComplete { get; set; }
        public DateTime? ScopeApproved { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountApproved { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EstimatedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int NotifiedAccounting { get; set; }
        public string Status { get; set; }
        public string TeamName1 { get; set; }
        public string TaskList1 { get; set; }
        public decimal? DevHours1 { get; set; }
        public decimal? DevMoney1 { get; set; }
        public string Pm1 { get; set; }
        public string PmtaskList1 { get; set; }
        public decimal? Pmhours1 { get; set; }
        public string TeamName2 { get; set; }
        public string TaskList2 { get; set; }
        public decimal? DevHours2 { get; set; }
        public decimal? DevMoney2 { get; set; }
        public string Pm2 { get; set; }
        public string PmtaskList2 { get; set; }
        public decimal? Pmhours2 { get; set; }
        public string TeamName3 { get; set; }
        public string TaskList3 { get; set; }
        public decimal? DevHours3 { get; set; }
        public decimal? DevMoney3 { get; set; }
        public string Pm3 { get; set; }
        public string PmtaskList3 { get; set; }
        public decimal? Pmhours3 { get; set; }
        public decimal? TotalDevHours { get; set; }
        public decimal? TotalPmhours { get; set; }
        public decimal? StatsStatedHours { get; set; }
        public decimal? StatsStatedFee { get; set; }
        public decimal? StatsPmfee { get; set; }
        public string DevHoursEstimate { get; set; }
        public string ActualDevHours { get; set; }
        public string HoursToClient { get; set; }
        public string FeeToClient { get; set; }
    }
}
