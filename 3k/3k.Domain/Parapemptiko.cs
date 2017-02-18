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
    
    public partial class Parapemptiko
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parapemptiko()
        {
            this.Financial = new HashSet<Financial>();
            this.Sinedries = new HashSet<Sinedries>();
        }
    
        public int ParapemptikoId { get; set; }
        public string ParapemptikoCode { get; set; }
        public Nullable<int> GiatrosId { get; set; }
        public Nullable<int> AsthenisId { get; set; }
        public Nullable<System.DateTime> DateEnarxis { get; set; }
        public Nullable<System.DateTime> DateLixis { get; set; }
        public Nullable<decimal> Poso { get; set; }
    
        public virtual Asthenis Asthenis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Financial> Financial { get; set; }
        public virtual Giatros Giatros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinedries> Sinedries { get; set; }
    }
}
