using DiyetProgrami.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.Model
{
    public class ModelOgun
    {
        public int OgunID { get; set; }
        public int KisiID { get; set; }
        public int BesinID { get; set; }
        public int BesinAdet { get; set; }
        public int ToplamKalori { get; set; }
        public System.DateTime diyetProgramiTarihi { get; set; }

        public  BesinlerTbl BesinlerTbl = new BesinlerTbl();
        public  KisiTbl KisiTbl = new KisiTbl();
    }
}
