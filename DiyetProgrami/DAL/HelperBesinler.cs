using DiyetProgrami.Entity;
using DiyetProgrami.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL
{
    public static class HelperBesinler
    {
        public static List<ModelBesinlerTbl> BesinListele()
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                List<ModelBesinlerTbl> bml = new List<ModelBesinlerTbl>();
                var besinListesi = de.BesinlerTbl.Where(x => x.besinDurum == true).ToList();
                foreach (var item in besinListesi)
                {
                    ModelBesinlerTbl bm = new ModelBesinlerTbl();
                    bm.BesinAdi = item.BesinAdi;
                    bm.BesinTipTbl.BesinTipi = item.BesinTipTbl.BesinTipi;
                    bm.BesinGramaj = item.BesinGramaj;
                    bm.BesinKalori = item.BesinKalori;
                    bm.BesinID = item.BesinID;
                    bml.Add(bm);
                }
                return bml;
            }
        }
        public static string BesinIdyeGoreBesinTipGetir(int besinID)
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                var besinTip = de.BesinlerTbl.Where(x => x.BesinID == besinID).FirstOrDefault();
                ModelBesinlerTbl bm = new ModelBesinlerTbl();
                bm.BesinTipTbl.BesinTipi = besinTip.BesinTipTbl.BesinTipi;
                return bm.BesinTipTbl.BesinTipi.ToString();
            }
        }
        public static bool BesinlerCUD(BesinlerTbl besin, EntityState state)//besin silme ve düzenleme için kullanılacak metod.
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                de.Entry(besin).State = state;
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

        public static BesinlerTbl BesinIdyeGoreBesinGetir(int besinID)
        {
            using (DiyetDbEntities de=new DiyetDbEntities())
            {
                var besin = de.BesinlerTbl.Where(x => x.BesinID == besinID).FirstOrDefault();
                return besin;
            }
        }


        public static List<BesinlerTbl> BesinTipIdyeGoreBesinListesiGetir(int besinTipID)
        {
            using (DiyetDbEntities de=new DiyetDbEntities())
            {
                var list=de.BesinlerTbl.Where(x => x.BesinTipID == besinTipID && x.besinDurum==true).ToList();
                return list;
            }
        }

    }
}
