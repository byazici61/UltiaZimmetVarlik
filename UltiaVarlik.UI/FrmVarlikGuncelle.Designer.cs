
namespace UltiaVarlik.UI
{
    partial class FrmVarlikGuncelle
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
            this.pbBilgiler = new System.Windows.Forms.GroupBox();
            this.cbBarkod = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtMaliyet = new System.Windows.Forms.TextBox();
            this.dtpEmekli = new System.Windows.Forms.DateTimePicker();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiyatParaBirimi = new System.Windows.Forms.ComboBox();
            this.cmbGaranti = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbMaliyetParaBirimi = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbUrunTipi = new System.Windows.Forms.ComboBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.cmbAksiyonlar = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pbBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBilgiler
            // 
            this.pbBilgiler.BackColor = System.Drawing.SystemColors.Control;
            this.pbBilgiler.Controls.Add(this.cbBarkod);
            this.pbBilgiler.Controls.Add(this.btnKaydet);
            this.pbBilgiler.Controls.Add(this.txtAciklama);
            this.pbBilgiler.Controls.Add(this.txtFiyat);
            this.pbBilgiler.Controls.Add(this.txtMaliyet);
            this.pbBilgiler.Controls.Add(this.dtpEmekli);
            this.pbBilgiler.Controls.Add(this.dtpGiris);
            this.pbBilgiler.Controls.Add(this.numAdet);
            this.pbBilgiler.Controls.Add(this.cmbBirim);
            this.pbBilgiler.Controls.Add(this.label14);
            this.pbBilgiler.Controls.Add(this.label5);
            this.pbBilgiler.Controls.Add(this.label13);
            this.pbBilgiler.Controls.Add(this.label12);
            this.pbBilgiler.Controls.Add(this.label4);
            this.pbBilgiler.Controls.Add(this.label11);
            this.pbBilgiler.Controls.Add(this.label3);
            this.pbBilgiler.Controls.Add(this.label2);
            this.pbBilgiler.Controls.Add(this.lblAdet);
            this.pbBilgiler.Controls.Add(this.lblBirim);
            this.pbBilgiler.Controls.Add(this.label9);
            this.pbBilgiler.Controls.Add(this.label10);
            this.pbBilgiler.Controls.Add(this.label8);
            this.pbBilgiler.Controls.Add(this.label1);
            this.pbBilgiler.Controls.Add(this.cmbFiyatParaBirimi);
            this.pbBilgiler.Controls.Add(this.cmbGaranti);
            this.pbBilgiler.Controls.Add(this.cmbModel);
            this.pbBilgiler.Controls.Add(this.cmbMaliyetParaBirimi);
            this.pbBilgiler.Controls.Add(this.cmbMarka);
            this.pbBilgiler.Controls.Add(this.cmbUrunTipi);
            this.pbBilgiler.Controls.Add(this.txtBarkod);
            this.pbBilgiler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBilgiler.Location = new System.Drawing.Point(0, 133);
            this.pbBilgiler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbBilgiler.Name = "pbBilgiler";
            this.pbBilgiler.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbBilgiler.Size = new System.Drawing.Size(842, 483);
            this.pbBilgiler.TabIndex = 0;
            this.pbBilgiler.TabStop = false;
            this.pbBilgiler.Text = "Varlık Bilgileri";
            // 
            // cbBarkod
            // 
            this.cbBarkod.AutoSize = true;
            this.cbBarkod.Checked = true;
            this.cbBarkod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBarkod.Location = new System.Drawing.Point(29, 53);
            this.cbBarkod.Name = "cbBarkod";
            this.cbBarkod.Size = new System.Drawing.Size(108, 20);
            this.cbBarkod.TabIndex = 12;
            this.cbBarkod.Text = "Barkodlu Ürün";
            this.cbBarkod.UseVisualStyleBackColor = true;
            this.cbBarkod.CheckedChanged += new System.EventHandler(this.cbBarkod_CheckedChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(582, 429);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 37);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(29, 346);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(474, 119);
            this.txtAciklama.TabIndex = 10;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(496, 248);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(294, 22);
            this.txtFiyat.TabIndex = 9;
            // 
            // txtMaliyet
            // 
            this.txtMaliyet.Enabled = false;
            this.txtMaliyet.Location = new System.Drawing.Point(496, 147);
            this.txtMaliyet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaliyet.Name = "txtMaliyet";
            this.txtMaliyet.Size = new System.Drawing.Size(294, 22);
            this.txtMaliyet.TabIndex = 9;
            // 
            // dtpEmekli
            // 
            this.dtpEmekli.Enabled = false;
            this.dtpEmekli.Location = new System.Drawing.Point(496, 102);
            this.dtpEmekli.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpEmekli.Name = "dtpEmekli";
            this.dtpEmekli.Size = new System.Drawing.Size(294, 22);
            this.dtpEmekli.TabIndex = 8;
            // 
            // dtpGiris
            // 
            this.dtpGiris.Enabled = false;
            this.dtpGiris.Location = new System.Drawing.Point(496, 54);
            this.dtpGiris.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(294, 22);
            this.dtpGiris.TabIndex = 7;
            // 
            // numAdet
            // 
            this.numAdet.Enabled = false;
            this.numAdet.Location = new System.Drawing.Point(276, 53);
            this.numAdet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(57, 22);
            this.numAdet.TabIndex = 6;
            // 
            // cmbBirim
            // 
            this.cmbBirim.Enabled = false;
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(158, 53);
            this.cmbBirim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(106, 24);
            this.cmbBirim.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 330);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Garantili Mi?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 227);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Model";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 176);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Güncel Fiyat Para Birimi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ürün Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Güncel Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Para Birimi";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(273, 33);
            this.lblAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(34, 16);
            this.lblAdet.TabIndex = 3;
            this.lblAdet.Text = "Adet";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(154, 33);
            this.lblBirim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(38, 16);
            this.lblBirim.TabIndex = 3;
            this.lblBirim.Text = "Birim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Emeklilik Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Barkod";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giriş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Maliyeti";
            // 
            // cmbFiyatParaBirimi
            // 
            this.cmbFiyatParaBirimi.FormattingEnabled = true;
            this.cmbFiyatParaBirimi.Location = new System.Drawing.Point(496, 301);
            this.cmbFiyatParaBirimi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbFiyatParaBirimi.Name = "cmbFiyatParaBirimi";
            this.cmbFiyatParaBirimi.Size = new System.Drawing.Size(294, 24);
            this.cmbFiyatParaBirimi.TabIndex = 2;
            // 
            // cmbGaranti
            // 
            this.cmbGaranti.FormattingEnabled = true;
            this.cmbGaranti.Items.AddRange(new object[] {
            "Hayır",
            "Evet"});
            this.cmbGaranti.Location = new System.Drawing.Point(29, 301);
            this.cmbGaranti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbGaranti.Name = "cmbGaranti";
            this.cmbGaranti.Size = new System.Drawing.Size(304, 24);
            this.cmbGaranti.TabIndex = 2;
            // 
            // cmbModel
            // 
            this.cmbModel.Enabled = false;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(29, 248);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(304, 24);
            this.cmbModel.TabIndex = 2;
            // 
            // cmbMaliyetParaBirimi
            // 
            this.cmbMaliyetParaBirimi.Enabled = false;
            this.cmbMaliyetParaBirimi.FormattingEnabled = true;
            this.cmbMaliyetParaBirimi.Location = new System.Drawing.Point(496, 195);
            this.cmbMaliyetParaBirimi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMaliyetParaBirimi.Name = "cmbMaliyetParaBirimi";
            this.cmbMaliyetParaBirimi.Size = new System.Drawing.Size(294, 24);
            this.cmbMaliyetParaBirimi.TabIndex = 2;
            // 
            // cmbMarka
            // 
            this.cmbMarka.Enabled = false;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(29, 195);
            this.cmbMarka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(304, 24);
            this.cmbMarka.TabIndex = 2;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbUrunTipi
            // 
            this.cmbUrunTipi.Enabled = false;
            this.cmbUrunTipi.FormattingEnabled = true;
            this.cmbUrunTipi.Location = new System.Drawing.Point(29, 147);
            this.cmbUrunTipi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbUrunTipi.Name = "cmbUrunTipi";
            this.cmbUrunTipi.Size = new System.Drawing.Size(304, 24);
            this.cmbUrunTipi.TabIndex = 2;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Enabled = false;
            this.txtBarkod.Location = new System.Drawing.Point(29, 102);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(304, 22);
            this.txtBarkod.TabIndex = 1;
            // 
            // cmbAksiyonlar
            // 
            this.cmbAksiyonlar.FormattingEnabled = true;
            this.cmbAksiyonlar.Items.AddRange(new object[] {
            "Tüket",
            "Zimmet Ata",
            "Depoya Ata",
            "Üstlen",
            "İade Et ",
            "İptal Et",
            "Emekli Et",
            "Kayıp/Çalıntı Bildir ",
            "Yorum Ekle"});
            this.cmbAksiyonlar.Location = new System.Drawing.Point(622, 24);
            this.cmbAksiyonlar.Name = "cmbAksiyonlar";
            this.cmbAksiyonlar.Size = new System.Drawing.Size(208, 24);
            this.cmbAksiyonlar.TabIndex = 4;
            this.cmbAksiyonlar.SelectedIndexChanged += new System.EventHandler(this.cmbAksiyonlar_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(619, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Aksiyonlar:";
            // 
            // FrmVarlikGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(842, 616);
            this.Controls.Add(this.cmbAksiyonlar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pbBilgiler);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmVarlikGuncelle";
            this.Text = "Varlik Güncelleme";
            this.Load += new System.EventHandler(this.FrmVarlikGuncelle_Load);
            this.pbBilgiler.ResumeLayout(false);
            this.pbBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pbBilgiler;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGaranti;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbUrunTipi;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtMaliyet;
        private System.Windows.Forms.DateTimePicker dtpEmekli;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFiyatParaBirimi;
        private System.Windows.Forms.ComboBox cmbMaliyetParaBirimi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbAksiyonlar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbBarkod;
    }
}