using SeyirDefteri.Core;

namespace SeyirDefteri.UI
{
    public partial class FRMSeyirEkrani : Form
    {
        public FRMSeyirEkrani()
        {
            InitializeComponent();

        }
        private void FRMSeyirEkrani_Load(object sender, EventArgs e)
        {
            GemiOlsutur();
            LimanOlustur();
            ListVieweSutunEkle();
        }

        private void ListVieweSutunEkle()
        {
            lvSeferler.View = View.Details;
            lvSeferler.GridLines = true;

            lvSeferler.Columns.Add("ID", 50, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Gemi", 150, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Çýkýþ Tarihi", 150, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Varýþ Tarihi", 150, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Çýkýþ Limaný", 150, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Uðrayacaðý Liman", 150, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Varýþ Limaný", 150, HorizontalAlignment.Center);
        }

        int id = 0;
        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            if (dtpLimanaVarisTarihi.Value < dtpLimandanCikisTarihi.Value)
            {
                MessageBox.Show("Varýþ tarihi çýkýþ tarihinden büyük olamaz!");
                return;
            }
            if (cmbGemi.SelectedItem == null)
            {
                MessageBox.Show("Gemi girilmesi zorunludur!");
                return;
            }
            if (cmbCikisLimani.SelectedItem== cmbUgradigiLiman.SelectedItem || cmbCikisLimani.SelectedItem == cmbVarisLimani.SelectedItem || cmbVarisLimani.SelectedItem == cmbUgradigiLiman.SelectedItem)
            {
                MessageBox.Show("Sefer sýrasýnda girilen duraklar farklý olmak zorundadýr!");
                return;
            }

            SeyirKaydi seyirKaydi = new()
            {
                LimandanCikisTarihi = dtpLimandanCikisTarihi.Value,
                LimanaVarisTarihi = dtpLimanaVarisTarihi.Value,
                CikisLimani = cmbCikisLimani.SelectedItem.ToString(),
                VarisLimani = cmbVarisLimani.SelectedItem.ToString(),
                UgrayacagiLiman = cmbUgradigiLiman.SelectedItem.ToString(),
                Gemi = cmbGemi.SelectedItem as Gemi
            };

            ListViewItem listViewItem = new();

            listViewItem.Text = (++id).ToString();
            listViewItem.SubItems.Add(seyirKaydi.Gemi.ToString());
            listViewItem.SubItems.Add(seyirKaydi.LimandanCikisTarihi.ToString());
            listViewItem.SubItems.Add(seyirKaydi.LimanaVarisTarihi.ToString());
            listViewItem.SubItems.Add(seyirKaydi.CikisLimani.ToString());
            listViewItem.SubItems.Add(seyirKaydi.UgrayacagiLiman.ToString());
            listViewItem.SubItems.Add(seyirKaydi.VarisLimani.ToString());

            lvSeferler.Items.Add(listViewItem);
        }

        private void GemiOlsutur()
        {
            List<Gemi> gemiler = new List<Gemi>()
            {
                new Gemi { GemiId = 1, GemiAdi = "Titanic", GemiTonaji = 46000m },
                new Gemi { GemiId = 2, GemiAdi = "Queen Mary 2", GemiTonaji = 148528m },
                new Gemi { GemiId = 3, GemiAdi = "Oasis of the Seas", GemiTonaji = 226838m },
                new Gemi { GemiId = 4, GemiAdi = "Harmony of the Seas", GemiTonaji = 226963m },
                new Gemi { GemiId = 5, GemiAdi = "Symphony of the Seas", GemiTonaji = 228081m },
                new Gemi { GemiId = 6, GemiAdi = "MSC Meraviglia", GemiTonaji = 171598m },
                new Gemi { GemiId = 7, GemiAdi = "Norwegian Escape", GemiTonaji = 165300m },
                new Gemi { GemiId = 8, GemiAdi = "Costa Smeralda", GemiTonaji = 185010m },
                new Gemi { GemiId = 9, GemiAdi = "AIDAnova", GemiTonaji = 183900m },
                new Gemi { GemiId = 10, GemiAdi = "Mardi Gras", GemiTonaji = 180000m },
                new Gemi { GemiId = 11, GemiAdi = "Regal Princess", GemiTonaji = 142714m },
                new Gemi { GemiId = 12, GemiAdi = "Majestic Princess", GemiTonaji = 143700m },
                new Gemi { GemiId = 13, GemiAdi = "Celebrity Edge", GemiTonaji = 130818m },
                new Gemi { GemiId = 14, GemiAdi = "MSC Seaview", GemiTonaji = 154000m },
                new Gemi { GemiId = 15, GemiAdi = "Carnival Vista", GemiTonaji = 133500m }
            };

            foreach (var gemi in gemiler)
            {
                cmbGemi.Items.Add(gemi);
            }

        }
        private void LimanOlustur()
        {
            List<string> limanlar = new List<string>()
            {
                "Ýstanbul Sarýyer Yat Limaný, Türkiye",
                "Ýstanbul Beþiktaþ Limaný, Türkiye",
                "Ýstanbul Haydarpaþa Limaný, Türkiye",
                "Ýstanbul Kadýköy Limaný, Türkiye",
                "Ýstanbul Karaköy Limaný, Türkiye",
                "Ýstanbul Ambarlý Limaný, Türkiye",
                "Ýstanbul Bakýrköy Limaný, Türkiye",
                "Ýzmir Alsancak Limaný, Türkiye",
                "Ýzmir Çeþme Limaný, Türkiye",
                "Ýzmir Karþýyaka Limaný, Türkiye",
                "Ýzmir Aliaða Limaný, Türkiye",
                "Mersin Limaný, Türkiye",
                "Antalya Limaný, Türkiye",
                "Bodrum Limaný, Türkiye",
                "Göcek Limaný, Türkiye",
                "Fethiye Limaný, Türkiye",
                "Kuþadasý Limaný, Türkiye",
                "Trabzon Limaný, Türkiye",
                "Samsun Limaný, Türkiye",
                "Hopa Limaný, Türkiye",
                "Port of Piraeus, Yunanistan",
                "Port of Thessaloniki, Yunanistan",
                "Port of Heraklion, Yunanistan",
                "Port of Patras, Yunanistan",
                "Port of Volos, Yunanistan",
                "Port of Genoa, Ýtalya",
                "Port of Naples, Ýtalya",
                "Port of Livorno, Ýtalya",
                "Port of Civitavecchia, Ýtalya",
                "Port of Venice, Ýtalya",
                "Port of Marseille, Fransa",
                "Port of Le Havre, Fransa"
            };

            foreach (var liman in limanlar)
            {
                cmbCikisLimani.Items.Add(liman);
                cmbUgradigiLiman.Items.Add(liman);
                cmbVarisLimani.Items.Add(liman);
            }
        }
    }
}
