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
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Bank_Account = new HashSet<Bank_Account>();
            this.Customer_Loans = new HashSet<Customer_Loans>();
            this.Loan_Transaction = new HashSet<Loan_Transaction>();
        }
    
        public int Cust_ID { get; set; }
        public string Cust_FName { get; set; }
        public string Cust_MName { get; set; }
        public string Cust_LName { get; set; }
        public string Cust_DOB { get; set; }
        public string Cust_Postal { get; set; }
        public string Cust_Email { get; set; }
        public string Cust_Mobile { get; set; }
        public string Cust_Gender { get; set; }
        public string Cust_Residential { get; set; }
        public string Cust_FNPF { get; set; }
        public string Cust_Marital { get; set; }
        public string Cust_Occupation { get; set; }
        public string Cust_Photo { get; set; }
        public string Cust_TIN { get; set; }
        public Nullable<int> Passport_Num { get; set; }
        public string Residential_Type { get; set; }
        public int CustAcc_StatusID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bank_Account> Bank_Account { get; set; }
        public virtual Customer_Status Customer_Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Loans> Customer_Loans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan_Transaction> Loan_Transaction { get; set; }
        public virtual UserAccounts UserAccounts { get; set; }
    }
}
