//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaberPortal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_PortalHaber_Tip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PortalHaber_Tip()
        {
            this.tbl_PortalHaber_Menu_Tip_Relation = new HashSet<tbl_PortalHaber_Menu_Tip_Relation>();
            this.tbl_PortalHaber_Yazar = new HashSet<tbl_PortalHaber_Yazar>();
        }
    
        public int Tip_Id { get; set; }
        public string Tip_Adi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PortalHaber_Menu_Tip_Relation> tbl_PortalHaber_Menu_Tip_Relation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PortalHaber_Yazar> tbl_PortalHaber_Yazar { get; set; }
    }
}