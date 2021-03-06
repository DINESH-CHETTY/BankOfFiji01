//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankOfFiji01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoanApplications
    {
        public int loanApplicationNo { get; set; }
        public int accountNo { get; set; }
        public int assetTypeId { get; set; }
        public decimal monthlyRent_MortageAmt { get; set; }
        public decimal desiredLoanAmt { get; set; }
        public int loanTypeId { get; set; }
        public string approver { get; set; }
        public Nullable<System.DateTime> approvedDate { get; set; }
        public int applicationStatusId { get; set; }
    
        public virtual ApplicationStatus ApplicationStatus { get; set; }
        public virtual AssetType AssetType { get; set; }
        public virtual BankAccount BankAccount { get; set; }
        public virtual LoanType LoanType { get; set; }
        public virtual LoanRecords LoanRecords { get; set; }
    }
}
