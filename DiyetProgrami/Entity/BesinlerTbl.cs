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
    
    public partial class BesinlerTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BesinlerTbl()
        {
            this.OgunTbl = new HashSet<OgunTbl>();
        }
    
        public int BesinID { get; set; }
        public string BesinAdi { get; set; }
        public int BesinKalori { get; set; }
        public int BesinGramaj { get; set; }
        public int BesinTipID { get; set; }
        public bool besinDurum { get; set; }
    
        public virtual BesinTipTbl BesinTipTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgunTbl> OgunTbl { get; set; }
    }
}
