using DiyetProgrami.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.Model
{
    public class ModelBesinlerTbl
    {
        public int BesinID { get; set; }
        public string BesinAdi { get; set; }
        public int BesinKalori { get; set; }
        public int BesinGramaj { get; set; }
        public int BesinTipID { get; set; }

        public BesinTipTbl BesinTipTbl = new BesinTipTbl();
    }
}
