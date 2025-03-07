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
            lvSeferler.Columns.Add("��k�� Tarihi", 150, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Var�� Tarihi", 150, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("��k�� Liman�", 150, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("U�rayaca�� Liman", 150, HorizontalAlignment.Center);
            lvSeferler.Columns.Add("Var�� Liman�", 150, HorizontalAlignment.Center);
        }

        int id = 0;
        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            if (dtpLimanaVarisTarihi.Value < dtpLimandanCikisTarihi.Value)
            {
                MessageBox.Show("Var�� tarihi ��k�� tarihinden b�y�k olamaz!");
                return;
            }
            if (cmbGemi.SelectedItem == null)
            {
                MessageBox.Show("Gemi girilmesi zorunludur!");
                return;
            }
            if (cmbCikisLimani.SelectedItem== cmbUgradigiLiman.SelectedItem || cmbCikisLimani.SelectedItem == cmbVarisLimani.SelectedItem || cmbVarisLimani.SelectedItem == cmbUgradigiLiman.SelectedItem)
            {
                MessageBox.Show("Sefer s�ras�nda girilen duraklar farkl� olmak zorundad�r!");
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
                "�stanbul Sar�yer Yat Liman�, T�rkiye",
                "�stanbul Be�ikta� Liman�, T�rkiye",
                "�stanbul Haydarpa�a Liman�, T�rkiye",
                "�stanbul Kad�k�y Liman�, T�rkiye",
                "�stanbul Karak�y Liman�, T�rkiye",
                "�stanbul Ambarl� Liman�, T�rkiye",
                "�stanbul Bak�rk�y Liman�, T�rkiye",
                "�zmir Alsancak Liman�, T�rkiye",
                "�zmir �e�me Liman�, T�rkiye",
                "�zmir Kar��yaka Liman�, T�rkiye",
                "�zmir Alia�a Liman�, T�rkiye",
                "Mersin Liman�, T�rkiye",
                "Antalya Liman�, T�rkiye",
                "Bodrum Liman�, T�rkiye",
                "G�cek Liman�, T�rkiye",
                "Fethiye Liman�, T�rkiye",
                "Ku�adas� Liman�, T�rkiye",
                "Trabzon Liman�, T�rkiye",
                "Samsun Liman�, T�rkiye",
                "Hopa Liman�, T�rkiye",
                "Port of Piraeus, Yunanistan",
                "Port of Thessaloniki, Yunanistan",
                "Port of Heraklion, Yunanistan",
                "Port of Patras, Yunanistan",
                "Port of Volos, Yunanistan",
                "Port of Genoa, �talya",
                "Port of Naples, �talya",
                "Port of Livorno, �talya",
                "Port of Civitavecchia, �talya",
                "Port of Venice, �talya",
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
