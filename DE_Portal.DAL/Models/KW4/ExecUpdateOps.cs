using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ExecUpdateOps
    {
        public int Id { get; set; }
        public DateTime Ts { get; set; }
        public string TimeFrame { get; set; }
        public decimal? NumberofOpenedPositions { get; set; }
        public decimal? NumberofInterviews { get; set; }
        public decimal? NumberofOffers { get; set; }
        public decimal? NumberofOperationalMistakesUs { get; set; }
        public decimal? NumberofOperationalMistakesRem { get; set; }
        public decimal? RemoteOfficeCannotOperateNoInfo { get; set; }
        public decimal? NoInfoResolved { get; set; }
        public decimal? RemoteOfficeCannotOperateNoExp { get; set; }
        public decimal? NoExperienceResolved { get; set; }
        public decimal? UsteamLoad { get; set; }
        public decimal? RemoteTeamLoad { get; set; }
        public decimal? UsopsRating { get; set; }
        public decimal? RemoteOpsRating { get; set; }
        public decimal? OverallDepartmentRatingbyManager { get; set; }
        public decimal? DepartmentChange { get; set; }
        public decimal? DepartmentRating { get; set; }
        public decimal? DisclosureofClientsData { get; set; }
        public decimal? DisclosureOfDedata { get; set; }
        public decimal? UnAuthAccessToClients { get; set; }
        public decimal? UnAuthAccessToDe { get; set; }
        public decimal? ServiceInterruptionOfClients { get; set; }
        public decimal? ServiceInterruptionOfDe { get; set; }
        public decimal? Globalfailures72 { get; set; }
        public decimal? Partialfailures73 { get; set; }
        public decimal? Failuresofclientfacingissueshandling74 { get; set; }
    }
}
