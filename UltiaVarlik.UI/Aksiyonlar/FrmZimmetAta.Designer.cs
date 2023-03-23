
namespace UltiaVarlik.UI.Aksiyonlar
{
    partial class FrmZimmetAta
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
            this.cmbZimmetSahibi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZimmetNedeni = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbZimmetTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpZimmetBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpZimmetBitis = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnZimmetAta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbZimmetSahibi
            // 
            this.cmbZimmetSahibi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZimmetSahibi.FormattingEnabled = true;
            this.cmbZimmetSahibi.Location = new System.Drawing.Point(39, 36);
            this.cmbZimmetSahibi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbZimmetSahibi.Name = "cmbZimmetSahibi";
            this.cmbZimmetSahibi.Size = new System.Drawing.Size(371, 27);
            this.cmbZimmetSahibi.TabIndex = 0;
            this.cmbZimmetSahibi.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Zimmet Sahibi:";
            // 
            // cmbZimmetNedeni
            // 
            this.cmbZimmetNedeni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZimmetNedeni.FormattingEnabled = true;
            this.cmbZimmetNedeni.Location = new System.Drawing.Point(39, 95);
            this.cmbZimmetNedeni.Margin = new System.Windows.Forms.Padding(4);
            this.cmbZimmetNedeni.Name = "cmbZimmetNedeni";
            this.cmbZimmetNedeni.Size = new System.Drawing.Size(371, 27);
            this.cmbZimmetNedeni.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Zimmet Nedeni:";
            // 
            // cmbZimmetTuru
            // 
            this.cmbZimmetTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZimmetTuru.FormattingEnabled = true;
            this.cmbZimmetTuru.Location = new System.Drawing.Point(39, 153);
            this.cmbZimmetTuru.Margin = new System.Windows.Forms.Padding(4);
            this.cmbZimmetTuru.Name = "cmbZimmetTuru";
            this.cmbZimmetTuru.Size = new System.Drawing.Size(371, 27);
            this.cmbZimmetTuru.TabIndex = 0;
            this.cmbZimmetTuru.SelectedIndexChanged += new System.EventHandler(this.cmbZimmetTuru_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Zimmet Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "*Zimmet Başlangıç Tarihi:";
            // 
            // dtpZimmetBaslangic
            // 
            this.dtpZimmetBaslangic.Location = new System.Drawing.Point(39, 207);
            this.dtpZimmetBaslangic.Name = "dtpZimmetBaslangic";
            this.dtpZimmetBaslangic.Size = new System.Drawing.Size(371, 25);
            this.dtpZimmetBaslangic.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "*Zimmet Bitiş Tarihi";
            // 
            // dtpZimmetBitis
            // 
            this.dtpZimmetBitis.Location = new System.Drawing.Point(39, 265);
            this.dtpZimmetBitis.Name = "dtpZimmetBitis";
            this.dtpZimmetBitis.Size = new System.Drawing.Size(371, 25);
            this.dtpZimmetBitis.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "*Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(39, 334);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(371, 106);
            this.txtAciklama.TabIndex = 4;
            // 
            // btnZimmetAta
            // 
            this.btnZimmetAta.Location = new System.Drawing.Point(299, 452);
            this.btnZimmetAta.Name = "btnZimmetAta";
            this.btnZimmetAta.Size = new System.Drawing.Size(110, 31);
            this.btnZimmetAta.TabIndex = 5;
            this.btnZimmetAta.Text = "Zimmet Ata";
            this.btnZimmetAta.UseVisualStyleBackColor = true;
            this.btnZimmetAta.Click += new System.EventHandler(this.btnZimmetAta_Click);
            // 
            // FrmZimmetAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(443, 487);
            this.Controls.Add(this.btnZimmetAta);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dtpZimmetBitis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpZimmetBaslangic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbZimmetTuru);
            this.Controls.Add(this.cmbZimmetNedeni);
            this.Controls.Add(this.cmbZimmetSahibi);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZimmetAta";
            this.Text = "Zimmet Ata";
            this.Load += new System.EventHandler(this.FrmZimmetAta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbZimmetSahibi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZimmetNedeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZimmetTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpZimmetBaslangic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpZimmetBitis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnZimmetAta;
    }
}