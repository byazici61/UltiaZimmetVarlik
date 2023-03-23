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
using UltiaVarlik.UI.RaporEkranlari;

namespace UltiaVarlik.UI
{
    public partial class FrmGenelEkran : Form
    {
      
   

        FrmVarliklarim FrmVarlik;
        FrmDuyurular FrmDuyuru = new FrmDuyurular();
        FrmSorular FrmSoru = new FrmSorular();
        private Personel GirisYapanKullanici;

        public FrmGenelEkran()
        {
            InitializeComponent();
        }

        public FrmGenelEkran(Personel GirisYapanKullanici) : this()
        {
            this.GirisYapanKullanici = GirisYapanKullanici;
            
        }


        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmDuyuru.MdiParent = this;
            FrmDuyuru.Show();
            FrmDuyuru.WindowState = FormWindowState.Maximized;
            
        }

        private void sikcaSorulanSorularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmSoru.MdiParent = this;
            FrmSoru.Show();
            FrmSoru.WindowState = FormWindowState.Maximized;

        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGirisEkrani frmGiris = new FrmGirisEkrani();
            frmGiris.Show();
        }

        private void varliklariGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVarlik = new FrmVarliklarim(GirisYapanKullanici);
            FrmVarlik.MdiParent = this;
            FrmVarlik.Show();
            FrmVarlik.WindowState = FormWindowState.Maximized;


        }

        private void FrmGenelEkran_Load(object sender, EventArgs e)
        {
            tstxtPersonelAdSoyad.Text = GirisYapanKullanici.PersonelAdi + " " + GirisYapanKullanici.PersonelSoyadi + " Ekip : " + GirisYapanKullanici.SirketEkip.SirketEkipAdi;
        }

        private void rapor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepoRapor frmdepo = new DepoRapor();
            frmdepo.MdiParent = this;
            frmdepo.Show();
            frmdepo.WindowState = FormWindowState.Maximized;
        }
    }
}
