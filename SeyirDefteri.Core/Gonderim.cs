using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyirDefteri.Core
{
    public class Gonderim
    {
        public int GonderimId { get; set; }
        public Urun Urun { get; set; }
        public IlgilenenKisi IlgilenenKisi { get; set; }
        public SeyirKaydi SeyirKaydi { get; set; }
        public decimal GonderimTonaji { get; set; }
        public override string ToString() => $"{SeyirKaydi.Gemi.GemiAdi} - {SeyirKaydi.LimandanCikisTarihi} - {SeyirKaydi.LimanaVarisTarihi} - {Urun.UrunAdi} - {IlgilenenKisi.BagliOlduguFirma.FirmaAdi} - {GonderimTonaji}";
    }
}
