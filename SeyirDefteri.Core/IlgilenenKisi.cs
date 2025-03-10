using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyirDefteri.Core
{
    public class IlgilenenKisi
    {
        public int IlgilenenKisiId { get; set; }
        public string IlgilenenKisiAdi { get; set; }
        public string IlgilenenKisiTelefonu { get; set; }
        public Firma BagliOlduguFirma { get; set; }
        public override string ToString() => $"{IlgilenenKisiAdi}";
    }
}
