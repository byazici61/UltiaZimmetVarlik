﻿
namespace UltiaVarlik.UI
{
    partial class FrmGenelEkran
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.varlıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varliklariGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varliklariGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapor1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapor2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duyurularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sikcaSorulanSorularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnCikisYap = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varlıkToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.duyurularToolStripMenuItem,
            this.sikcaSorulanSorularToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // varlıkToolStripMenuItem
            // 
            this.varlıkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varliklariGosterToolStripMenuItem,
            this.varliklariGuncelleToolStripMenuItem});
            this.varlıkToolStripMenuItem.Name = "varlıkToolStripMenuItem";
            this.varlıkToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.varlıkToolStripMenuItem.Text = "Varlık";
            // 
            // varliklariGosterToolStripMenuItem
            // 
            this.varliklariGosterToolStripMenuItem.Name = "varliklariGosterToolStripMenuItem";
            this.varliklariGosterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.varliklariGosterToolStripMenuItem.Text = "Varlıkları Göster";
            this.varliklariGosterToolStripMenuItem.Click += new System.EventHandler(this.varliklariGosterToolStripMenuItem_Click);
            // 
            // varliklariGuncelleToolStripMenuItem
            // 
            this.varliklariGuncelleToolStripMenuItem.Name = "varliklariGuncelleToolStripMenuItem";
            this.varliklariGuncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.varliklariGuncelleToolStripMenuItem.Text = "Varlıkları Güncelle";
            this.varliklariGuncelleToolStripMenuItem.Click += new System.EventHandler(this.varliklariGuncelleToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapor1ToolStripMenuItem,
            this.rapor2ToolStripMenuItem});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // rapor1ToolStripMenuItem
            // 
            this.rapor1ToolStripMenuItem.Name = "rapor1ToolStripMenuItem";
            this.rapor1ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.rapor1ToolStripMenuItem.Text = "Rapor1";
            // 
            // rapor2ToolStripMenuItem
            // 
            this.rapor2ToolStripMenuItem.Name = "rapor2ToolStripMenuItem";
            this.rapor2ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.rapor2ToolStripMenuItem.Text = "Rapor2";
            // 
            // duyurularToolStripMenuItem
            // 
            this.duyurularToolStripMenuItem.Name = "duyurularToolStripMenuItem";
            this.duyurularToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.duyurularToolStripMenuItem.Text = "Duyurular";
            this.duyurularToolStripMenuItem.Click += new System.EventHandler(this.duyurularToolStripMenuItem_Click);
            // 
            // sikcaSorulanSorularToolStripMenuItem
            // 
            this.sikcaSorulanSorularToolStripMenuItem.Name = "sikcaSorulanSorularToolStripMenuItem";
            this.sikcaSorulanSorularToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.sikcaSorulanSorularToolStripMenuItem.Text = "Sıkca Sorulan Sorular";
            this.sikcaSorulanSorularToolStripMenuItem.Click += new System.EventHandler(this.sikcaSorulanSorularToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.btnCikisYap});
            this.toolStrip1.Location = new System.Drawing.Point(527, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(352, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 25);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCikisYap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCikisYap.Image = global::UltiaVarlik.UI.Properties.Resources.LogOut;
            this.btnCikisYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(23, 22);
            this.btnCikisYap.Text = "toolStripButton1";
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // FrmGenelEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UltiaVarlik.UI.Properties.Resources.ultia;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGenelEkran";
            this.Text = "Varlık Yönetim Sistemi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCikisYap;
        private System.Windows.Forms.ToolStripMenuItem varlıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varliklariGosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varliklariGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapor1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapor2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem duyurularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sikcaSorulanSorularToolStripMenuItem;
    }
}