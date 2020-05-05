using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Threat
    {
        public Threat()
        {
            ThreatChangeLog = new HashSet<ThreatChangeLog>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public int ThreatAssetTypeId { get; set; }
        public string Title { get; set; }
        public int ThreatTypeId { get; set; }
        public int ThreatVulnerabilityTypeId { get; set; }
        public int OwnerUserId { get; set; }
        public int ThreatResponseTypeId { get; set; }
        public int ThreatActionPlanTypeId { get; set; }
        public string ActionPlanDetails { get; set; }
        public int? OrderIndex { get; set; }
        public int IsActive { get; set; }
        public int? ThreatContext { get; set; }
        public string Location { get; set; }
        public string ThreatEvent { get; set; }
        public int? RiskLikelihood { get; set; }
        public string RiskImpact { get; set; }
        public int? RiskRating { get; set; }
        public string CurrentControl { get; set; }
        public int? ControlEffectiveness { get; set; }
        public int? ControlOwner { get; set; }
        public DateTime? ControlLastTested { get; set; }
        public int? ControlTestResults { get; set; }
        public string ResidualRiskLikelihood { get; set; }
        public string ResidualRiskImpact { get; set; }
        public string Reference { get; set; }
        public string Notes { get; set; }

        public virtual ThreatControlEffectivenessType ControlEffectivenessNavigation { get; set; }
        public virtual Users ControlOwnerNavigation { get; set; }
        public virtual ThreatControlTestResultType ControlTestResultsNavigation { get; set; }
        public virtual Users CreatedUser { get; set; }
        public virtual Users OwnerUser { get; set; }
        public virtual ThreatRiskLikelihoodType RiskLikelihoodNavigation { get; set; }
        public virtual ThreatRiskRatingType RiskRatingNavigation { get; set; }
        public virtual ThreatActionPlanType ThreatActionPlanType { get; set; }
        public virtual ThreatAssetType ThreatAssetType { get; set; }
        public virtual ThreatContextType ThreatContextNavigation { get; set; }
        public virtual ThreatResponseType ThreatResponseType { get; set; }
        public virtual ThreatType ThreatType { get; set; }
        public virtual ThreatVulnerabilityType ThreatVulnerabilityType { get; set; }
        public virtual ICollection<ThreatChangeLog> ThreatChangeLog { get; set; }
    }
}
