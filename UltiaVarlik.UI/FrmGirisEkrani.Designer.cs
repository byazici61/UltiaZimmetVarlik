﻿
namespace UltiaVarlik.UI
{
    partial class FrmGirisEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullanıcıMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.cbSifereGöster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(180, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Mail:";
            // 
            // txtKullanıcıMail
            // 
            this.txtKullanıcıMail.Location = new System.Drawing.Point(290, 177);
            this.txtKullanıcıMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullanıcıMail.Multiline = true;
            this.txtKullanıcıMail.Name = "txtKullanıcıMail";
            this.txtKullanıcıMail.Size = new System.Drawing.Size(188, 29);
            this.txtKullanıcıMail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(238, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(290, 214);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(188, 28);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisYap.Location = new System.Drawing.Point(306, 250);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(156, 30);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // cbSifereGöster
            // 
            this.cbSifereGöster.AutoSize = true;
            this.cbSifereGöster.BackColor = System.Drawing.Color.Transparent;
            this.cbSifereGöster.Location = new System.Drawing.Point(486, 218);
            this.cbSifereGöster.Name = "cbSifereGöster";
            this.cbSifereGöster.Size = new System.Drawing.Size(107, 23);
            this.cbSifereGöster.TabIndex = 3;
            this.cbSifereGöster.Text = "Sifre Göster";
            this.cbSifereGöster.UseVisualStyleBackColor = false;
            this.cbSifereGöster.CheckedChanged += new System.EventHandler(this.cbSifereGöster_CheckedChanged);
            // 
            // FrmGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UltiaVarlik.UI.Properties.Resources.Login_;
            this.ClientSize = new System.Drawing.Size(779, 500);
            this.Controls.Add(this.cbSifereGöster);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullanıcıMail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGirisEkrani";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullanıcıMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.CheckBox cbSifereGöster;
    }
}