//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace k3k.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asthenis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asthenis()
        {
            this.Financial = new HashSet<Financial>();
            this.Parapemptiko = new HashSet<Parapemptiko>();
            this.Sinedries = new HashSet<Sinedries>();
        }
    
        public int AsthenisId { get; set; }
        public string Eponimo { get; set; }
        public string Onoma { get; set; }
        public string Patronimo { get; set; }
        public Nullable<int> FiloId { get; set; }
        public string Diefthinsi { get; set; }
        public string Stathero { get; set; }
        public string Kinito { get; set; }
        public Nullable<System.DateTime> DateGenisis { get; set; }
        public string Epaggelma { get; set; }
        public string email { get; set; }
        public Nullable<decimal> amka { get; set; }
    
        public virtual Filo Filo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Financial> Financial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parapemptiko> Parapemptiko { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinedries> Sinedries { get; set; }
    }
}
