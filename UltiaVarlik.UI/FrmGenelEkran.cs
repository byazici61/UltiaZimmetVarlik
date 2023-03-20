using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltiaVarlik.UI.EkstraEkranlar;

namespace UltiaVarlik.UI
{
    public partial class FrmGenelEkran : Form
    {
      
        FrmGirisEkrani frmGiris;
        FrmVarlikGuncelle frmVarGun;
        FrmVarliklarim frmVarlik;
        FrmDuyurular frmDuyuru;
        FrmSorular frmSoru;
        public FrmGenelEkran()
        {
            InitializeComponent();
        }

 
        private void varliklariGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVarGun = new FrmVarlikGuncelle();
            frmVarGun.MdiParent = this;
            frmVarGun.Show();
            //frmDuyuru.WindowState = FormWindowState.Minimized;
            //frmSoru.WindowState = FormWindowState.Minimized;
            //frmVarlik.WindowState = FormWindowState.Minimized;

        }

        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDuyuru = new FrmDuyurular();
            frmDuyuru.MdiParent = this;
            frmDuyuru.Show();
            //frmVarGun.WindowState = FormWindowState.Minimized;
            //frmSoru.WindowState = FormWindowState.Minimized;
            //frmVarlik.WindowState = FormWindowState.Minimized;
        }

        private void sikcaSorulanSorularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoru = new FrmSorular();
            frmSoru.MdiParent = this;
            frmSoru.Show();
            //frmVarGun.WindowState = FormWindowState.Minimized;
            //frmDuyuru.WindowState = FormWindowState.Minimized;
            //frmVarlik.WindowState = FormWindowState.Minimized;

        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGirisEkrani frmGiris = new FrmGirisEkrani();
            frmGiris.Show();
        }

        private void varliklariGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVarlik = new FrmVarliklarim();
            frmVarlik.MdiParent = this;
            frmVarlik.Show();
            //frmVarGun.WindowState = FormWindowState.Minimized;
            //frmDuyuru.WindowState = FormWindowState.Minimized;
            //frmSoru.WindowState = FormWindowState.Minimized;

        }
    }
}
