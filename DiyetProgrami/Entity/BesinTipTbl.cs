//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiyetProgrami.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class BesinTipTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BesinTipTbl()
        {
            this.BesinlerTbl = new HashSet<BesinlerTbl>();
        }
    
        public int BesinTipID { get; set; }
        public string BesinTipi { get; set; }
        public bool besinTipDurum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BesinlerTbl> BesinlerTbl { get; set; }
    }
}
