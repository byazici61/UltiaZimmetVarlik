
namespace UltiaVarlik.UI
{
    partial class FrmVarliklarim
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
            this.lblVarliklarim = new System.Windows.Forms.Label();
            this.lblEkipVarliklar = new System.Windows.Forms.Label();
            this.lblTumVarliklar = new System.Windows.Forms.Label();
            this.lvTablo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVarliklarim
            // 
            this.lblVarliklarim.AutoSize = true;
            this.lblVarliklarim.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVarliklarim.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblVarliklarim.Location = new System.Drawing.Point(291, 88);
            this.lblVarliklarim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVarliklarim.Name = "lblVarliklarim";
            this.lblVarliklarim.Size = new System.Drawing.Size(118, 26);
            this.lblVarliklarim.TabIndex = 1;
            this.lblVarliklarim.Text = "Varlıklarım";
            this.lblVarliklarim.Click += new System.EventHandler(this.lblVarliklarim_Click);
            // 
            // lblEkipVarliklar
            // 
            this.lblEkipVarliklar.AutoSize = true;
            this.lblEkipVarliklar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkipVarliklar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEkipVarliklar.Location = new System.Drawing.Point(439, 88);
            this.lblEkipVarliklar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEkipVarliklar.Name = "lblEkipVarliklar";
            this.lblEkipVarliklar.Size = new System.Drawing.Size(189, 26);
            this.lblEkipVarliklar.TabIndex = 1;
            this.lblEkipVarliklar.Text = "Ekibimin Varlıkları";
            this.lblEkipVarliklar.Click += new System.EventHandler(this.lblEkipVarliklar_Click);
            // 
            // lblTumVarliklar
            // 
            this.lblTumVarliklar.AutoSize = true;
            this.lblTumVarliklar.Enabled = false;
            this.lblTumVarliklar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTumVarliklar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTumVarliklar.Location = new System.Drawing.Point(657, 88);
            this.lblTumVarliklar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTumVarliklar.Name = "lblTumVarliklar";
            this.lblTumVarliklar.Size = new System.Drawing.Size(142, 26);
            this.lblTumVarliklar.TabIndex = 1;
            this.lblTumVarliklar.Text = "Tum Varlıklar";
            this.lblTumVarliklar.Click += new System.EventHandler(this.lblTumVarliklar_Click);
            // 
            // lvTablo
            // 
            this.lvTablo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvTablo.HideSelection = false;
            this.lvTablo.Location = new System.Drawing.Point(222, 138);
            this.lvTablo.Name = "lvTablo";
            this.lvTablo.Size = new System.Drawing.Size(652, 321);
            this.lvTablo.TabIndex = 2;
            this.lvTablo.UseCompatibleStateImageBehavior = false;
            this.lvTablo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kayıt Numarası";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Barkod";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Tipi";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ÜrünGüncelFiyati";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Marka";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Model";
            this.columnHeader6.Width = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 483);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(6, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 43);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Kayıt";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UltiaVarlik.UI.Properties.Resources.ultia;
            this.pictureBox1.Location = new System.Drawing.Point(37, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVarliklarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvTablo);
            this.Controls.Add(this.lblTumVarliklar);
            this.Controls.Add(this.lblEkipVarliklar);
            this.Controls.Add(this.lblVarliklarim);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVarliklarim";
            this.Text = "Varlıklarım";
            this.Load += new System.EventHandler(this.FrmVarliklarim_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVarliklarim;
        private System.Windows.Forms.Label lblEkipVarliklar;
        private System.Windows.Forms.Label lblTumVarliklar;
        private System.Windows.Forms.ListView lvTablo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}