using DiyetProgrami.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL
{
    public static class HelperKisiDetay
    {

        public static bool HastaDetayVarMi(int kisiID)
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                var varMi = de.KisiDetay.Where(x => x.KisiID == kisiID).Any();
                return varMi;
            }
        }


        public static bool KisiDetayCUD(KisiDetay kisiDetay, EntityState state)//kisidetay ekleme ve güncelleme adı altında ikinci üçüncü.. ekleme için kullanılacak metod.
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                de.Entry(kisiDetay).State = state;
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

        public static KisiDetay KisiIdyeGoreSonKisiDetayGetir(int kisiID)
        {
            using (DiyetDbEntities de=new DiyetDbEntities())
            {
                var kisiDetay = de.KisiDetay.Where(x => x.KisiID == kisiID).ToList().LastOrDefault();
                return kisiDetay;
            }
        }


    }
}
