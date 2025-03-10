using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyirDefteri.Core
{
    public class Firma
    {
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; }
        public override string ToString() => $"Firma Adı: {FirmaAdi} Firma ID: {FirmaId}";
    }
}
