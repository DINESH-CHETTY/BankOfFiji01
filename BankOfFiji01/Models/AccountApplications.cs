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
    
    public partial class AccountApplications
    {
        public int accountApplicationNo { get; set; }
        public int userId { get; set; }
        public int accountTypeId { get; set; }
        public decimal openingBalance { get; set; }
        public string verifiedAndOpenedBy { get; set; }
        public string authorizedBy { get; set; }
        public Nullable<System.DateTime> approvedDate { get; set; }
        public int applicationStatusId { get; set; }
    
        public virtual AccountType AccountType { get; set; }
        public virtual ApplicationStatus ApplicationStatus { get; set; }
        public virtual Users Users { get; set; }
    }
}