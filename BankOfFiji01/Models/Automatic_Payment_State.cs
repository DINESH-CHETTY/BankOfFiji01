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
    
    public partial class Automatic_Payment_State
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Automatic_Payment_State()
        {
            this.AutoPayments = new HashSet<AutoPayments>();
        }
    
        public int State_ID { get; set; }
        public string State_descript { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoPayments> AutoPayments { get; set; }
    }
}
