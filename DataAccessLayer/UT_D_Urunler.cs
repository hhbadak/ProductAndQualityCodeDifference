using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UT_D_Urunler
    {
        public int ID { get; set; }
        public string BarkodNo { get; set; }
        public int DokumcuId { get; set; }
        public byte Adet { get; set; }
        public string Durum { get; set; }
        public DateTime DokumTarih { get; set; }
        public int TezgahKalipId { get; set; }
        public int TezgahId { get; set; }
        public int HataId { get; set; }
        public int VardiyaId { get; set; }
        public DateTime IslemTarih { get; set; }
        public int GunlukDokumId { get; set; }
    }
}
