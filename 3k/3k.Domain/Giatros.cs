//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3k.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Giatros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Giatros()
        {
            this.Parapemptiko = new HashSet<Parapemptiko>();
        }
    
        public int GiatrosId { get; set; }
        public string Eponimo { get; set; }
        public string Onoma { get; set; }
        public string Diefthinsi { get; set; }
        public string Stathero { get; set; }
        public string Kinito { get; set; }
        public string Fax { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parapemptiko> Parapemptiko { get; set; }
    }
}
