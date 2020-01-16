using DiyetProgrami.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL
{
    public static class HelperKisi
    {
        public static List<KisiTbl> KisiListele(int diyetisyenID)
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                var kisiListesi = de.KisiTbl.Where(x => x.diyetisyenID == diyetisyenID && x.kisiAktif == true).ToList();
                return kisiListesi;
            }
        }

        public static bool KisiCUD(KisiTbl kisi, EntityState state)//kisi silme ve düzenleme için kullanılacak metod.
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                de.Entry(kisi).State = state;
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

        public static KisiTbl IdyeGoreKisiGetir(int kisiID)
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                var f = de.KisiTbl.Where(x => x.KisiID == kisiID).FirstOrDefault();
                return f;
            }
        }
    }
}
