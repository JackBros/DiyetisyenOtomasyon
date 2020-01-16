using DiyetProgrami.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL
{
    public static class HelperDiyetisyen
    {
        public static DiyetisyenTbl GirisYap(string diyetisyenAdi, string sifre)//login metodu şifre değişikliğinde de kullanıldı.
        {
            using (DiyetDbEntities de=new DiyetDbEntities())
            {
                var diyetisyen = de.DiyetisyenTbl.Where(x => x.diyetisyenAdi == diyetisyenAdi && x.diyetisyenSifre == sifre).FirstOrDefault();
                return diyetisyen;
            }
        }
        public static bool DiyetisyenCUD(DiyetisyenTbl diyetisyen, EntityState state)//diyetisyen ekleme ve şifre değiştirme için kullanılacak metod.
        {
            using (DiyetDbEntities de=new DiyetDbEntities())
            {
                de.Entry(diyetisyen).State = state;
                if (de.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool DiyetisyenAdıKontrolEt(string diyetisyenAdi)
        {
            using (DiyetDbEntities de=new DiyetDbEntities())
            {
                var icerideVarMi = de.DiyetisyenTbl.Where(x => x.diyetisyenAdi == diyetisyenAdi).Any();
                if (icerideVarMi)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public static bool DiyetisyenIdPassUyuyorMu(string diyetisyenAdi, string sifre)
        {
            using (DiyetDbEntities de=new DiyetDbEntities())
            {
                var varMi = de.DiyetisyenTbl.Where(x => x.diyetisyenAdi == diyetisyenAdi && x.diyetisyenSifre == sifre).Any();
                if (varMi)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
