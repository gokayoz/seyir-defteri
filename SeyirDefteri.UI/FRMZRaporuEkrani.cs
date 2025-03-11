using SeyirDefteri.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyirDefteri.UI
{
    public partial class FRMZRaporuEkrani : Form
    {
        private List<Gonderim> Gonderimler;
        public FRMZRaporuEkrani()
        {
            InitializeComponent();
        }
        public FRMZRaporuEkrani(List<Gonderim> gonderimler) : this()
        {
            Gonderimler = gonderimler;
        }
    }
}
