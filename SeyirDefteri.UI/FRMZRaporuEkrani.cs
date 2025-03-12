using ClosedXML.Excel;
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
            ListVieweKolonEkle();
            ListeyiGuncelle();
        }

        private void ListVieweKolonEkle()
        {
            lvZRaporu.View = View.Details;
            lvZRaporu.GridLines = true;

            lvZRaporu.Columns.Add("Gemi Adı", 150);
            lvZRaporu.Columns.Add("Limandan Çıkış Tarihi", 150);
            lvZRaporu.Columns.Add("Limana Varış Tarihi", 150);
            lvZRaporu.Columns.Add("Ürün Adı", 150);
            lvZRaporu.Columns.Add("Firma Adı", 150);
            lvZRaporu.Columns.Add("Ürün Yükü", 150);
            lvZRaporu.Columns.Add("Kalan Tonaj", 150);
        }

        decimal kalanTonaj;
        private void ListeyiGuncelle()
        {
            DateTime baslangicTarihi = dtpBaslangic.Value.Date;
            DateTime bitisTarihi = dtpBitis.Value.Date;

            decimal toplamKullanilanTonaj = 0;
            decimal gemiTonaji = 0;

            foreach (Gonderim gonderim in Gonderimler)
            {
                DateTime limandanCikisTarihi = gonderim.SeyirKaydi.LimandanCikisTarihi.Date;
                DateTime limanaVarisTarihi = gonderim.SeyirKaydi.LimanaVarisTarihi.Date;

                if (limandanCikisTarihi >= baslangicTarihi && limanaVarisTarihi <= bitisTarihi)
                {
                    if (gemiTonaji <= 0)
                    {
                        gemiTonaji = gonderim.SeyirKaydi.Gemi.GemiTonaji;
                    }
                    toplamKullanilanTonaj += gonderim.GonderimTonaji;
                    kalanTonaj = gemiTonaji - toplamKullanilanTonaj;

                    ListViewItem listViewItem = new ListViewItem();

                    listViewItem.Text = gonderim.SeyirKaydi.Gemi.GemiAdi;
                    listViewItem.SubItems.Add(gonderim.SeyirKaydi.LimandanCikisTarihi.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add(gonderim.SeyirKaydi.LimanaVarisTarihi.ToString("dd/MMM/yyyy"));
                    listViewItem.SubItems.Add(gonderim.Urun.UrunAdi);
                    listViewItem.SubItems.Add(gonderim.IlgilenenKisi.BagliOlduguFirma.FirmaAdi);
                    listViewItem.SubItems.Add(gonderim.GonderimTonaji.ToString());

                    if (kalanTonaj >= 0)
                    {
                        listViewItem.SubItems.Add(kalanTonaj.ToString());
                    }
                    else
                    {
                        listViewItem.SubItems.Add("Gemi tonajından fazla yük yüklenmiştir!");
                    }
                    lvZRaporu.Items.Add(listViewItem);
                }
            }
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void btnExcelOlustur_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.AddWorksheet("ZRaporu");

                workSheet.Cell(1, 1).Value = "Gemi Adı";
                workSheet.Cell(1, 2).Value = "Limandan Çıkış Tarihi";
                workSheet.Cell(1, 3).Value = "Limana Varış Tarihi";
                workSheet.Cell(1, 4).Value = "Ürün Adı";
                workSheet.Cell(1, 4).Value = "Firma Adı";
                workSheet.Cell(1, 5).Value = "Gönderim Tonajı";

                int satir = 2;
                foreach (ListViewItem item in lvZRaporu.Items)
                {
                    workSheet.Cell(satir, 1).Value = item.SubItems[0].Text;
                    workSheet.Cell(satir, 2).Value = item.SubItems[1].Text;
                    workSheet.Cell(satir, 3).Value = item.SubItems[2].Text;
                    workSheet.Cell(satir, 4).Value = item.SubItems[3].Text;
                    workSheet.Cell(satir, 5).Value = item.SubItems[4].Text;
                    workSheet.Cell(satir, 6).Value = item.SubItems[5].Text;
                    workSheet.Cell(satir, 7).Value = item.SubItems[6].Text;
                    satir++;
                }

                using (SaveFileDialog saveFileDialog = new())
                {
                    saveFileDialog.Filter = "Excel Files|*xlsx";
                    saveFileDialog.Title = "Excel Dosyasını Kaydet";
                    saveFileDialog.FileName = "ZRaporu.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        workbook.SaveAs(filePath);
                        MessageBox.Show("Excel Başarıyla Oluşturuldu.");
                    }
                }
            }
        }
    }
}
