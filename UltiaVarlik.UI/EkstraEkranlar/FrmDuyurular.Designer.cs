
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("cevap1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("soru1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("cevap2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("soru2", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.label2 = new System.Windows.Forms.Label();
            this.treeDuyuru = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(318, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duyurular";
            // 
            // treeDuyuru
            // 
            this.treeDuyuru.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeDuyuru.Location = new System.Drawing.Point(41, 88);
            this.treeDuyuru.Name = "treeDuyuru";
            treeNode1.Name = "Node1";
            treeNode1.Text = "cevap1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "soru1";
            treeNode3.Name = "Node3";
            treeNode3.Text = "cevap2";
            treeNode4.Name = "Node2";
            treeNode4.Text = "soru2";
            this.treeDuyuru.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.treeDuyuru.Size = new System.Drawing.Size(700, 291);
            this.treeDuyuru.TabIndex = 3;
            // 
            // FrmDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeDuyuru);
            this.Name = "FrmDuyurular";
            this.Text = "Duyurular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeDuyuru;
    }
}