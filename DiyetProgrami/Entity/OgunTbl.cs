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
    
    public partial class OgunTbl
    {
        public int OgunID { get; set; }
        public int KisiID { get; set; }
        public int BesinID { get; set; }
        public int BesinAdet { get; set; }
        public System.DateTime diyetProgramiTarihi { get; set; }
        public bool ogunDurum { get; set; }
    
        public virtual BesinlerTbl BesinlerTbl { get; set; }
        public virtual KisiTbl KisiTbl { get; set; }
    }
}
