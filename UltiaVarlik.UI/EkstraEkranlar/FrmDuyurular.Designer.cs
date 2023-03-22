
namespace UltiaVarlik.UI.EkstraEkranlar
{
    partial class FrmDuyurular
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
            this.label2 = new System.Windows.Forms.Label();
            this.treeDuyuru = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(505, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duyurular";
            // 
            // treeDuyuru
            // 
            this.treeDuyuru.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeDuyuru.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeDuyuru.Location = new System.Drawing.Point(0, 70);
            this.treeDuyuru.Name = "treeDuyuru";
            this.treeDuyuru.Size = new System.Drawing.Size(1153, 489);
            this.treeDuyuru.TabIndex = 3;
            this.treeDuyuru.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDuyuru_AfterSelect);
            // 
            // FrmDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1153, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeDuyuru);
            this.Name = "FrmDuyurular";
            this.Text = "Duyurular";
            this.Load += new System.EventHandler(this.FrmDuyurular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeDuyuru;
    }
}