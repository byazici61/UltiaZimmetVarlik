
namespace UltiaVarlik.UI.RaporEkranlari
{
    partial class ParaBirimiRapor
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
            this.lvTablo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbParaBirimi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvTablo
            // 
            this.lvTablo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvTablo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvTablo.HideSelection = false;
            this.lvTablo.Location = new System.Drawing.Point(0, 194);
            this.lvTablo.Name = "lvTablo";
            this.lvTablo.Size = new System.Drawing.Size(774, 320);
            this.lvTablo.TabIndex = 0;
            this.lvTablo.UseCompatibleStateImageBehavior = false;
            this.lvTablo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka Model Adı";
            this.columnHeader1.Width = 214;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            this.columnHeader2.Width = 247;
            // 
            // cmbParaBirimi
            // 
            this.cmbParaBirimi.FormattingEnabled = true;
            this.cmbParaBirimi.Location = new System.Drawing.Point(12, 40);
            this.cmbParaBirimi.Name = "cmbParaBirimi";
            this.cmbParaBirimi.Size = new System.Drawing.Size(188, 27);
            this.cmbParaBirimi.TabIndex = 1;
            this.cmbParaBirimi.SelectedIndexChanged += new System.EventHandler(this.cmbParaBirimi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para Birimi Seçiniz";
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(273, 21);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(50, 19);
            this.lblBilgi.TabIndex = 3;
            this.lblBilgi.Text = "label2";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Varlik Grubu";
            this.columnHeader3.Width = 306;
            // 
            // ParaBirimiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 514);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbParaBirimi);
            this.Controls.Add(this.lvTablo);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ParaBirimiRapor";
            this.Text = "ParaBirimiRapor";
            this.Load += new System.EventHandler(this.ParaBirimiRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTablo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cmbParaBirimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}