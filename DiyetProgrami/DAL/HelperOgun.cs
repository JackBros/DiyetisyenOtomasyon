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
    public static class HelperOgun
    {
        public static List<ModelOgun> OgunListele(int kisiID)
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                List<ModelOgun> oml = new List<ModelOgun>();
                var ogunListesi = de.OgunTbl.Where(x => x.KisiID == kisiID && x.ogunDurum == true).ToList();
                foreach (var item in ogunListesi)
                {
                    ModelOgun om = new ModelOgun();
                    om.KisiTbl.Adi = item.KisiTbl.Adi;
                    om.KisiTbl.Soyadi = item.KisiTbl.Soyadi;
                    om.BesinlerTbl.BesinAdi = item.BesinlerTbl.BesinAdi;
                    om.BesinlerTbl.BesinGramaj = item.BesinlerTbl.BesinGramaj;
                    om.BesinAdet = item.BesinAdet;
                    om.ToplamKalori =item.BesinlerTbl.BesinKalori * item.BesinAdet;
                    om.diyetProgramiTarihi = item.diyetProgramiTarihi;
                    om.OgunID = item.OgunID;
                    oml.Add(om);
                }
                return oml;
            }
        }

        public static bool OgunCUD(OgunTbl ogun, EntityState state)//ogun ekleme silme ve düzenleme için kullanılacak metod.
        {
            using (DiyetDbEntities de = new DiyetDbEntities())
            {
                de.Entry(ogun).State = state;
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


        public static OgunTbl OgunIdyeGoreOgunGetir(int ogunID)
        {
            using (DiyetDbEntities de=new DiyetDbEntities())
            {
                var ogun=de.OgunTbl.Where(x => x.OgunID == ogunID).FirstOrDefault();
                return ogun;
            }
        }



    }
}
