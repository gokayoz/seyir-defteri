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
    public partial class FRMGonderimEkrani : Form
    {
        public FRMGonderimEkrani()
        {
            InitializeComponent();
        }
        private void FRMGonderimEkrani_Load(object sender, EventArgs e)
        {
            FirmaOlustur();
            ListVieweSutunEkle();
        }
        public FRMGonderimEkrani(List<SeyirKaydi> seyirKayitlari) : this()
        {
            foreach (SeyirKaydi seyirKaydi in seyirKayitlari)
            {
                if (seyirKaydi.Gemi == null)
                {
                    MessageBox.Show("Sefer kayıtlarındaki gemi bilgisi eksik!");
                    return;
                }
                cmbSeferler.Items.Add(seyirKaydi);
            }
        }
        private void ListVieweSutunEkle()
        {
            lvGonderim.View = View.Details;
            lvGonderim.GridLines = true;

            lvGonderim.Columns.Add("ID", 50, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Tonaj ", 100, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Ürün ", 100, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Firma ", 150, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Kişi Adı", 150, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("İletişim", 150, HorizontalAlignment.Center);
        }
        private void Temizle()
        {
            nudTonaj.Value = 0;
            cmbSeferler.SelectedItem = cmbFirmalar.SelectedItem = null;
            txtIlgilenenKisi.Text = txtUrunler.Text = mtxtTelefon.Text = string.Empty;
        }
        private void FirmaOlustur()
        {
            List<Firma> firmalar = new List<Firma>()
            {
                new Firma { FirmaId = 1, FirmaAdi = "TechNet" },
                new Firma { FirmaId = 2, FirmaAdi = "Alpha Industries" },
                new Firma { FirmaId = 3, FirmaAdi = "Beta Solutions" },
                new Firma { FirmaId = 4, FirmaAdi = "Gamma Technologies" },
                new Firma { FirmaId = 5, FirmaAdi = "Delta Innovations" },
                new Firma { FirmaId = 6, FirmaAdi = "Sigma Systems" },
                new Firma { FirmaId = 7, FirmaAdi = "Omega Enterprises" },
                new Firma { FirmaId = 8, FirmaAdi = "Vega Corporation" },
                new Firma { FirmaId = 9, FirmaAdi = "Zeta Networks" },
                new Firma { FirmaId = 10, FirmaAdi = "Kappa Solutions" },
                new Firma { FirmaId = 11, FirmaAdi = "Epsilon Labs" },
                new Firma { FirmaId = 12, FirmaAdi = "Theta Industries" },
                new Firma { FirmaId = 13, FirmaAdi = "Lambda Innovations" },
                new Firma { FirmaId = 14, FirmaAdi = "Nu Technologies" },
                new Firma { FirmaId = 15, FirmaAdi = "Xi Enterprises" },
                new Firma { FirmaId = 16, FirmaAdi = "Pi Corporation" },
                new Firma { FirmaId = 17, FirmaAdi = "Rho Networks" },
                new Firma { FirmaId = 18, FirmaAdi = "Chi Solutions" },
                new Firma { FirmaId = 19, FirmaAdi = "Psi Systems" },
                new Firma { FirmaId = 20, FirmaAdi = "Tau Enterprises" },
                new Firma { FirmaId = 21, FirmaAdi = "Phi Innovations" },
                new Firma { FirmaId = 22, FirmaAdi = "Mu Technologies" },
                new Firma { FirmaId = 23, FirmaAdi = "Nu Labs" },
                new Firma { FirmaId = 24, FirmaAdi = "Zeta Solutions" },
                new Firma { FirmaId = 25, FirmaAdi = "Alpha Enterprises" },
                new Firma { FirmaId = 26, FirmaAdi = "Omega Industries" },
                new Firma { FirmaId = 27, FirmaAdi = "Vega Innovations" },
                new Firma { FirmaId = 28, FirmaAdi = "Amazon" },
                new Firma { FirmaId = 29, FirmaAdi = "Trendyol" },
                new Firma { FirmaId = 30, FirmaAdi = "Hepsiburada" }
            };

            foreach (var firma in firmalar)
            {
                cmbFirmalar.Items.Add(firma);
            }
        }
        int id = 0, urunId = 1, ilgilenenKisiId = 0;
        private Gemi seciliGemi;
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (cmbSeferler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen sefer seçin!");
                return;
            }
            if (cmbFirmalar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen firma seçin!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUrunler.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz!");
                return;
            }

            SeyirKaydi seciliSeyir = cmbSeferler.SelectedItem as SeyirKaydi;

            if (seciliSeyir.Gemi == null || seciliSeyir == null)
            {
                MessageBox.Show("Geçerli bir sefer seçilemedi veya gemi bilgisi eksik!");
                return;
            }

            seciliGemi = seciliSeyir.Gemi;

            if (nudTonaj.Value < 0 || seciliGemi.GemiTonaji < nudTonaj.Value)
            {
                MessageBox.Show("Geminin tonajı büyük bir değer giremez!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIlgilenenKisi.Text) || string.IsNullOrWhiteSpace(mtxtTelefon.Text))
            {
                MessageBox.Show("İlgilenen kişi boş olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(mtxtTelefon.Text))
            {
                MessageBox.Show("Telefon boş olamaz!");
                return;
            }

            Gonderim gonderim = new Gonderim();
            gonderim.SeyirKaydi = cmbSeferler.SelectedItem as SeyirKaydi;

            gonderim.Urun = new Urun();
            gonderim.Urun.UrunId = urunId++;
            gonderim.Urun.UrunAdi = txtUrunler.Text;

            gonderim.GonderimTonaji = nudTonaj.Value;

            gonderim.IlgilenenKisi = new IlgilenenKisi();
            gonderim.IlgilenenKisi.IlgilenenKisiId = ilgilenenKisiId++;
            gonderim.IlgilenenKisi.IlgilenenKisiAdi = txtIlgilenenKisi.Text;
            gonderim.IlgilenenKisi.IlgilenenKisiTelefonu = mtxtTelefon.Text;
            gonderim.IlgilenenKisi.BagliOlduguFirma = cmbFirmalar.SelectedItem as Firma;





        }
    }
}
