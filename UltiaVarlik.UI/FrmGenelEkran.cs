using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltiaVarlik.DTO;
using UltiaVarlik.UI.EkstraEkranlar;

namespace UltiaVarlik.UI
{
    public partial class FrmGenelEkran : Form
    {
      
        FrmGirisEkrani frmGiris;
        FrmVarlikGuncelle frmVarGun= new FrmVarlikGuncelle();
        FrmVarliklarim frmVarlik;
        FrmDuyurular frmDuyuru = new FrmDuyurular();
        FrmSorular frmSoru = new FrmSorular();
        private Personel girisYapanKullanici;

        public FrmGenelEkran()
        {
            InitializeComponent();
        }

        public FrmGenelEkran(Personel girisYapanKullanici) : this()
        {
            this.girisYapanKullanici = girisYapanKullanici;
            
        }


        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmDuyuru.MdiParent = this;
            frmDuyuru.Show();
            frmDuyuru.WindowState = FormWindowState.Maximized;
            
        }

        private void sikcaSorulanSorularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmSoru.MdiParent = this;
            frmSoru.Show();
            frmSoru.WindowState = FormWindowState.Maximized;

        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGirisEkrani frmGiris = new FrmGirisEkrani();
            frmGiris.Show();
        }

        private void varliklariGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVarlik = new FrmVarliklarim(girisYapanKullanici);
            frmVarlik.MdiParent = this;
            frmVarlik.Show();
            frmVarlik.WindowState = FormWindowState.Maximized;


        }

        private void FrmGenelEkran_Load(object sender, EventArgs e)
        {
            tstxtPersonelAdSoyad.Text = girisYapanKullanici.PersonelAdi + " " + girisYapanKullanici.PersonelSoyadi + " Ekip : " + girisYapanKullanici.SirketEkip.SirketEkipAdi;
        }
    }
}
