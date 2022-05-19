//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UAT_CHR_Deals
    {
        public int DealId { get; set; }
        public string DealNumber { get; set; }
        public System.DateTime EstimatedMoveDate { get; set; }
        public System.DateTime EstimatedPayDate { get; set; }
        public double AllocationVolume { get; set; }
        public string Commodity { get; set; }
        public double NotionalAmount { get; set; }
        public Nullable<double> Collateral { get; set; }
        public double NetExposure { get; set; }
        public double Exposure { get; set; }
        public int CounterpartyId { get; set; }
        public string CounterpartyName { get; set; }
        public string AllocationNumber { get; set; }
        public System.DateTime ExpectedCreditRelease { get; set; }
        public string CreditComments { get; set; }
        public string CreditAnalyst { get; set; }
        public string Reason { get; set; }
        public string DealStatus { get; set; }
        public bool IsBuyDeal { get; set; }
        public int DealCreditHoldReleaseCommentId { get; set; }
        public int DealCreditHoldReleaseReasonId { get; set; }
        public int ResponsibleAnalystId { get; set; }
        public int DealCreditHoldReleaseStatusId { get; set; }
        public string BusinessUnit { get; set; }
        public string Scheduler { get; set; }
        public string Trader { get; set; }
        public string TransactionUnits { get; set; }
        public string ResponsibleAnalyst { get; set; }
        public string OrderNumber { get; set; }
        public string ItemNumber { get; set; }
        public System.DateTime CreditRevisionDate { get; set; }
        public string RevisedBy { get; set; }
        public System.DateTime ContractStartDate { get; set; }
        public System.DateTime ContractEndDate { get; set; }
        public string ParentName { get; set; }
        public string BookingCompany { get; set; }
    }
}
