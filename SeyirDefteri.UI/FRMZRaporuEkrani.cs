using ClosedXML.Excel;
using iTextSharp.text.pdf;
using SeyirDefteri.Core;
using iTextSharp.text;
using System.Net.Mail;
using System.Net;

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

            var gemiBazliGonderimler = Gonderimler
                .Where(g => g.SeyirKaydi.LimandanCikisTarihi.Date >= baslangicTarihi && g.SeyirKaydi.LimanaVarisTarihi.Date <= bitisTarihi)
                .GroupBy(g => g.SeyirKaydi.Gemi.GemiAdi)
                .ToList();

            lvZRaporu.Items.Clear();
            foreach (var grup in gemiBazliGonderimler)
            {
                decimal gemiTonaji = grup.First()
                    .SeyirKaydi.Gemi?.GemiTonaji ?? 0;

                decimal toplamKullanilanTonaj = 0;

                foreach (Gonderim gonderim in grup)
                {
                    toplamKullanilanTonaj += gonderim.GonderimTonaji;
                    decimal kalanTonaj = gemiTonaji - toplamKullanilanTonaj;

                    ListViewItem listViewItem = new ListViewItem();

                    listViewItem.Text = gonderim.SeyirKaydi.Gemi.GemiAdi;
                    listViewItem.SubItems.Add(gonderim.SeyirKaydi.LimandanCikisTarihi.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add(gonderim.SeyirKaydi.LimanaVarisTarihi.ToString("dd/MM/yyyy"));
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
                workSheet.Cell(1, 5).Value = "Firma Adı";
                workSheet.Cell(1, 6).Value = "Gönderim Tonajı";
                workSheet.Cell(1, 7).Value = "Kalan Tonaj";

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
        private void btnPdfOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                saveFileDialog.Title = "PDF Dosyası Kaydet";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document document = new Document();

                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    PdfPTable pdfPTable = new PdfPTable(lvZRaporu.Columns.Count);
                    pdfPTable.WidthPercentage = 100;

                    foreach (ColumnHeader column in lvZRaporu.Columns)
                    {
                        PdfPCell pdfPCell = new PdfPCell(new Phrase(column.Text));
                        pdfPCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdfPTable.AddCell(pdfPCell);
                    }

                    foreach (ListViewItem item in lvZRaporu.Items)
                    {
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            pdfPTable.AddCell(subItem.Text);
                        }
                    }
                    document.Add(pdfPTable);

                    document.Close();
                    MessageBox.Show("PDF başarıyla oluşturuldu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            try
            {
                string excelDosyaYolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ZRaporu.xlsx");
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Gönderim ZRaporu");

                    for (int col = 0; col < lvZRaporu.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = lvZRaporu.Columns[col].Text;
                    }
                    int row = 2;
                    foreach (ListViewItem item in lvZRaporu.Items)
                    {
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            worksheet.Cell(row, i + 1).Value = item.SubItems[i].Text;
                        }
                        row++;
                    }
                    workbook.SaveAs(excelDosyaYolu);
                }

                MailMessage mailMessage = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mailMessage.From = new MailAddress("denizgokay.yzlm@gmail.com");
                mailMessage.To.Add("buraksenolyzl@gmail.com");
                mailMessage.Subject = "Gönderimin Z Raporu";
                mailMessage.Body = "Merhaba İyi çalışmalar,\n" +
                    "Ekteki dosya gönderimin z raporudur.";
                mailMessage.Attachments.Add(new Attachment(excelDosyaYolu));

                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("denizgokay.yzlm@gmail.com", "lwivyhxcxirhohjv");
                smtp.EnableSsl = true;

                smtp.Send(mailMessage);
                MessageBox.Show("E-posta gönderildi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
