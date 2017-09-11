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
    
    public partial class Bank_Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bank_Account()
        {
            this.Transactions = new HashSet<Transactions>();
        }
    
        public int Acc_ID { get; set; }
        public int Cust_ID { get; set; }
        public int Acc_Type_ID { get; set; }
        public System.DateTime Acc_StartDate { get; set; }
        public int Acc_StatusID { get; set; }
        public Nullable<System.DateTime> Acc_EndDate { get; set; }
        public decimal Acc_total_interest { get; set; }
        public decimal Acc_Amount { get; set; }
        public decimal Acc_TotalAmount { get; set; }
        public Nullable<decimal> Acc_NonResTax { get; set; }
    
        public virtual Account_Type Account_Type { get; set; }
        public virtual Bank_AccountStatus Bank_AccountStatus { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
