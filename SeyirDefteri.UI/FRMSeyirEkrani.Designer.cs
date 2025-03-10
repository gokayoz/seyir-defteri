namespace SeyirDefteri.UI
{
    partial class FRMSeyirEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpLimanaVarisTarihi = new DateTimePicker();
            label1 = new Label();
            cmbGemi = new ComboBox();
            btnSeferOlustur = new Button();
            lvSeferler = new ListView();
            cmbCikisLimani = new ComboBox();
            cmbUgradigiLiman = new ComboBox();
            cmbVarisLimani = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpLimandanCikisTarihi = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            btnGec = new Button();
            SuspendLayout();
            // 
            // dtpLimanaVarisTarihi
            // 
            dtpLimanaVarisTarihi.Location = new Point(246, 69);
            dtpLimanaVarisTarihi.Name = "dtpLimanaVarisTarihi";
            dtpLimanaVarisTarihi.Size = new Size(357, 27);
            dtpLimanaVarisTarihi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 24);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 1;
            label1.Text = "Limandan Çıkış Tarihi:";
            // 
            // cmbGemi
            // 
            cmbGemi.FormattingEnabled = true;
            cmbGemi.Location = new Point(246, 116);
            cmbGemi.Name = "cmbGemi";
            cmbGemi.Size = new Size(357, 28);
            cmbGemi.TabIndex = 2;
            // 
            // btnSeferOlustur
            // 
            btnSeferOlustur.Location = new Point(618, 224);
            btnSeferOlustur.Name = "btnSeferOlustur";
            btnSeferOlustur.Size = new Size(161, 46);
            btnSeferOlustur.TabIndex = 3;
            btnSeferOlustur.Text = "Sefer Oluştur";
            btnSeferOlustur.UseVisualStyleBackColor = true;
            btnSeferOlustur.Click += btnSeferOlustur_Click;
            // 
            // lvSeferler
            // 
            lvSeferler.Location = new Point(10, 290);
            lvSeferler.Name = "lvSeferler";
            lvSeferler.Size = new Size(945, 325);
            lvSeferler.TabIndex = 4;
            lvSeferler.UseCompatibleStateImageBehavior = false;
            // 
            // cmbCikisLimani
            // 
            cmbCikisLimani.FormattingEnabled = true;
            cmbCikisLimani.Location = new Point(246, 158);
            cmbCikisLimani.Name = "cmbCikisLimani";
            cmbCikisLimani.Size = new Size(357, 28);
            cmbCikisLimani.TabIndex = 2;
            // 
            // cmbUgradigiLiman
            // 
            cmbUgradigiLiman.FormattingEnabled = true;
            cmbUgradigiLiman.Location = new Point(246, 199);
            cmbUgradigiLiman.Name = "cmbUgradigiLiman";
            cmbUgradigiLiman.Size = new Size(357, 28);
            cmbUgradigiLiman.TabIndex = 2;
            // 
            // cmbVarisLimani
            // 
            cmbVarisLimani.FormattingEnabled = true;
            cmbVarisLimani.Location = new Point(246, 242);
            cmbVarisLimani.Name = "cmbVarisLimani";
            cmbVarisLimani.Size = new Size(357, 28);
            cmbVarisLimani.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 74);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 1;
            label2.Text = "Limana Varış Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 119);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 1;
            label3.Text = "Gemi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 161);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 1;
            label4.Text = "Çıkış Limanı:";
            // 
            // dtpLimandanCikisTarihi
            // 
            dtpLimandanCikisTarihi.Location = new Point(246, 19);
            dtpLimandanCikisTarihi.Name = "dtpLimandanCikisTarihi";
            dtpLimandanCikisTarihi.Size = new Size(357, 27);
            dtpLimandanCikisTarihi.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 202);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 1;
            label5.Text = "Uğradığı Liman:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 246);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 1;
            label6.Text = "Varış Limanı:";
            // 
            // btnGec
            // 
            btnGec.Location = new Point(794, 224);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(161, 46);
            btnGec.TabIndex = 5;
            btnGec.Text = "Sonraki Sayfa";
            btnGec.UseVisualStyleBackColor = true;
            btnGec.Click += btnGec_Click;
            // 
            // FRMSeyirEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 627);
            Controls.Add(btnGec);
            Controls.Add(lvSeferler);
            Controls.Add(btnSeferOlustur);
            Controls.Add(cmbVarisLimani);
            Controls.Add(cmbUgradigiLiman);
            Controls.Add(cmbCikisLimani);
            Controls.Add(cmbGemi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpLimandanCikisTarihi);
            Controls.Add(dtpLimanaVarisTarihi);
            Name = "FRMSeyirEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seyir Ekranı";
            Load += FRMSeyirEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpLimanaVarisTarihi;
        private Label label1;
        private ComboBox cmbGemi;
        private Button btnSeferOlustur;
        private ListView lvSeferler;
        private ComboBox cmbCikisLimani;
        private ComboBox cmbUgradigiLiman;
        private ComboBox cmbVarisLimani;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpLimandanCikisTarihi;
        private Label label5;
        private Label label6;
        private Button btnGec;
    }
}
