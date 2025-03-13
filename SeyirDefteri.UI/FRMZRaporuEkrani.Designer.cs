namespace SeyirDefteri.UI
{
    partial class FRMZRaporuEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExcelOlustur = new Button();
            dtpBaslangic = new DateTimePicker();
            lvZRaporu = new ListView();
            dtpBitis = new DateTimePicker();
            btnPdfOlustur = new Button();
            btnMailGonder = new Button();
            SuspendLayout();
            // 
            // btnExcelOlustur
            // 
            btnExcelOlustur.Location = new Point(148, 390);
            btnExcelOlustur.Name = "btnExcelOlustur";
            btnExcelOlustur.Size = new Size(105, 29);
            btnExcelOlustur.TabIndex = 0;
            btnExcelOlustur.Text = "Excel Oluştur";
            btnExcelOlustur.UseVisualStyleBackColor = true;
            btnExcelOlustur.Click += btnExcelOlustur_Click;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(12, 31);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 1;
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // lvZRaporu
            // 
            lvZRaporu.Location = new Point(12, 76);
            lvZRaporu.Name = "lvZRaporu";
            lvZRaporu.Size = new Size(776, 284);
            lvZRaporu.TabIndex = 2;
            lvZRaporu.UseCompatibleStateImageBehavior = false;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(538, 31);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 1;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.Location = new Point(12, 390);
            btnPdfOlustur.Name = "btnPdfOlustur";
            btnPdfOlustur.Size = new Size(94, 29);
            btnPdfOlustur.TabIndex = 0;
            btnPdfOlustur.Text = "PDF Oluştur";
            btnPdfOlustur.UseVisualStyleBackColor = true;
            btnPdfOlustur.Click += btnPdfOlustur_Click;
            // 
            // btnMailGonder
            // 
            btnMailGonder.Location = new Point(296, 390);
            btnMailGonder.Name = "btnMailGonder";
            btnMailGonder.Size = new Size(231, 29);
            btnMailGonder.TabIndex = 0;
            btnMailGonder.Text = "Excel Dosyasını Mail Gönder";
            btnMailGonder.UseVisualStyleBackColor = true;
            // 
            // FRMZRaporuEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvZRaporu);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(btnMailGonder);
            Controls.Add(btnPdfOlustur);
            Controls.Add(btnExcelOlustur);
            Name = "FRMZRaporuEkrani";
            Text = "Z Raporu Ekranı";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExcelOlustur;
        private DateTimePicker dtpBaslangic;
        private ListView lvZRaporu;
        private DateTimePicker dtpBitis;
        private Button btnPdfOlustur;
        private Button btnMailGonder;
    }
}