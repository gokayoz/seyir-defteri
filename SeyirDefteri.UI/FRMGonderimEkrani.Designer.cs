namespace SeyirDefteri.UI
{
    partial class FRMGonderimEkrani
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
            cmbSeferler = new ComboBox();
            txtUrunler = new TextBox();
            nudTonaj = new NumericUpDown();
            mtxtTelefon = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbFirmalar = new ComboBox();
            txtIlgilenenKisi = new TextBox();
            lvGonderim = new ListView();
            btnUrunEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTonaj).BeginInit();
            SuspendLayout();
            // 
            // cmbSeferler
            // 
            cmbSeferler.FormattingEnabled = true;
            cmbSeferler.Location = new Point(188, 42);
            cmbSeferler.Name = "cmbSeferler";
            cmbSeferler.Size = new Size(420, 28);
            cmbSeferler.TabIndex = 0;
            // 
            // txtUrunler
            // 
            txtUrunler.Location = new Point(188, 79);
            txtUrunler.Name = "txtUrunler";
            txtUrunler.Size = new Size(420, 27);
            txtUrunler.TabIndex = 1;
            // 
            // nudTonaj
            // 
            nudTonaj.Location = new Point(188, 126);
            nudTonaj.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            nudTonaj.Name = "nudTonaj";
            nudTonaj.Size = new Size(420, 27);
            nudTonaj.TabIndex = 2;
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(188, 267);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(420, 27);
            mtxtTelefon.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 45);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "Seferler:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 86);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "Urunler:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 133);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Tonaj:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 178);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 4;
            label4.Text = "Firma:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 225);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 4;
            label5.Text = "İlgilenen Kişi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 267);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 4;
            label6.Text = "Telefon:";
            // 
            // cmbFirmalar
            // 
            cmbFirmalar.FormattingEnabled = true;
            cmbFirmalar.Location = new Point(188, 170);
            cmbFirmalar.Name = "cmbFirmalar";
            cmbFirmalar.Size = new Size(420, 28);
            cmbFirmalar.TabIndex = 0;
            // 
            // txtIlgilenenKisi
            // 
            txtIlgilenenKisi.Location = new Point(188, 218);
            txtIlgilenenKisi.Name = "txtIlgilenenKisi";
            txtIlgilenenKisi.Size = new Size(420, 27);
            txtIlgilenenKisi.TabIndex = 1;
            // 
            // lvGonderim
            // 
            lvGonderim.Location = new Point(12, 323);
            lvGonderim.Name = "lvGonderim";
            lvGonderim.Size = new Size(772, 247);
            lvGonderim.TabIndex = 5;
            lvGonderim.UseCompatibleStateImageBehavior = false;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(666, 267);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(94, 29);
            btnUrunEkle.TabIndex = 6;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // FRMGonderimEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 580);
            Controls.Add(btnUrunEkle);
            Controls.Add(lvGonderim);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mtxtTelefon);
            Controls.Add(nudTonaj);
            Controls.Add(txtIlgilenenKisi);
            Controls.Add(txtUrunler);
            Controls.Add(cmbFirmalar);
            Controls.Add(cmbSeferler);
            Name = "FRMGonderimEkrani";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gönderim Ekranı";
            Load += FRMGonderimEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)nudTonaj).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSeferler;
        private TextBox txtUrunler;
        private NumericUpDown nudTonaj;
        private MaskedTextBox mtxtTelefon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbFirmalar;
        private TextBox txtIlgilenenKisi;
        private ListView lvGonderim;
        private Button btnUrunEkle;
    }
}