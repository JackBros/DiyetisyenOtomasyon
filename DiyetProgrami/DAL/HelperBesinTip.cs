using DiyetProgrami.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL
{
    public static class HelperBesinTip
    {
        public static List<BesinTipTbl> BesinTipleri()
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                var besinTipleri = de.BesinTipTbl.Where(x => x.besinTipDurum == true).ToList();
                return besinTipleri;
            }
        }

        public static bool BesinTipCUD(BesinTipTbl besinTip, EntityState state)//besintip ekleme ve düzenleme ve silme için kullanılacak metod.
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                de.Entry(besinTip).State = state;
                if (de.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static BesinTipTbl BesinTipIdyeGoreBesinTipGetir(int besinTipId)
        {
            using (DiyetDbEntities de=new DiyetDbEntities())
            {
                var besin=de.BesinTipTbl.Where(x => x.BesinTipID == besinTipId).FirstOrDefault();
                return besin;
            }
        }
    }

}
