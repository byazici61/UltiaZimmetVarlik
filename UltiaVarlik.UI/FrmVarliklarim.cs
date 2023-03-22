using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltiaVarlik.DAL;
using UltiaVarlik.DAL.DAL;
using UltiaVarlik.DTO;

namespace UltiaVarlik.UI
{
    public partial class FrmVarliklarim : Form
    {
        private Personel GirisYapanKullanici;
        List<SirketEkipZimmet> SirketEkipZimmetler;
        List<PersonelZimmet> PersonelZimmetler;
        PersonelZimmet SecilenPersonelZimmet;
        List<Varlik> Varliklar;
        Varlik SecilenVarlik;
        public FrmVarliklarim()
        {
            InitializeComponent();
        }

        public FrmVarliklarim(Personel GirisYapanKullanici) : this()
        {
            this.GirisYapanKullanici = GirisYapanKullanici;
            
        }

        private void FrmVarliklarim_Load(object sender, EventArgs e)
        {
            // Giren Kişinin Rolüne Göre Erişebileceği yerleri Belirler
            if (AdminRol())
            {
                lblTumVarliklar.Enabled = true;
                lblEkipVarliklar.Enabled = false;
                lblVarliklarim.Enabled = false;
            }
        }


        /// <summary>
        /// Label'a tıklandığında tüm varliklari getiren method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTumVarliklar_Click(object sender, EventArgs e)
        {
            LabelRenkDegistir((Label)sender);
            lvTablo.Items.Clear();
            VarlikDAL Varlik = new VarlikDAL();
            Varliklar = Varlik.VeriCek();
            foreach (Varlik item in Varliklar)
            {
                ListViewItem lvi = new ListViewItem(item.VarlikID.ToString());
                lvi.SubItems.Add(item.Barkot.ToString());
                lvi.SubItems.Add(item.VarlikGrubu.VarlikGrubuAdi);
                lvi.SubItems.Add(item.Fiyat.ToString());
                string[] markamodelAdi = item.MarkaModel.MarkaModeAdi.Split(' ');
                foreach (string markaModel in markamodelAdi)
                {
                    lvi.SubItems.Add(markaModel);
                }


                lvTablo.Items.Add(lvi);
            }
           
            btnVarlikDüzenle.Enabled = true;
        }
       
        /// <summary>
        /// labela tıklandığında sadece giriş yapan kullanıcaya ait zimmetleri geteren method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblVarliklarim_Click(object sender, EventArgs e)
        {
            LabelRenkDegistir((Label)sender);
            lvTablo.Items.Clear();
            PersonelZimmetDAL PersonelZimmet = new PersonelZimmetDAL();
            PersonelZimmetler = PersonelZimmet.VeriCek(GirisYapanKullanici.PersonelID);
            foreach (PersonelZimmet item in PersonelZimmetler)
            {
                ListViewItem lvi = new ListViewItem(item.KullaniciZimmetID.ToString());
                lvi.SubItems.Add(item.Zimmet.Varlik.Barkot.ToString());
                lvi.SubItems.Add(item.Zimmet.Varlik.VarlikGrubu.VarlikGrubuAdi);
                lvi.SubItems.Add(item.Zimmet.Varlik.Fiyat.ToString());
                string[] markamodelAdi = item.Zimmet.Varlik.MarkaModel.MarkaModeAdi.Split(' ');
                foreach (string markaModel in markamodelAdi)
                {
                    lvi.SubItems.Add(markaModel);
                }


                lvTablo.Items.Add(lvi);
            }
            btnVarlikDüzenle.Enabled = true;
        }

        /// <summary>
        /// label a tıklandığından giriş yapan kullanıcın ekibine ait zimmetleri getiren method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblEkipVarliklar_Click(object sender, EventArgs e)
        {
            LabelRenkDegistir((Label)sender);
            lvTablo.Items.Clear();
            SirketEkipZimmetDAL sirketEkipZimmet = new SirketEkipZimmetDAL();
            SirketEkipZimmetler = sirketEkipZimmet.VeriCek(GirisYapanKullanici.SirketEkip.SirketEkipID);
            foreach (SirketEkipZimmet item in SirketEkipZimmetler)
            {
                ListViewItem lvi = new ListViewItem(item.Zimmet.Varlik.VarlikID.ToString());
                lvi.SubItems.Add(item.Zimmet.Varlik.Barkot.ToString());
                lvi.SubItems.Add(item.Zimmet.Varlik.VarlikGrubu.VarlikGrubuAdi);
                lvi.SubItems.Add(item.Zimmet.Varlik.Fiyat.ToString());
                string[] markamodelAdi = item.Zimmet.Varlik.MarkaModel.MarkaModeAdi.Split(' ');
                foreach (string markaModel in markamodelAdi)
                {
                    lvi.SubItems.Add(markaModel);
                }


                lvTablo.Items.Add(lvi);
            }
            btnVarlikDüzenle.Enabled = false;
            //lvTablo.FullRowSelect = false;

        }
        
        /// <summary>
        /// kullanının rolüne göre dönüş yapan method. power user veya depo adminse true
        /// </summary>
        /// <returns></returns>
        private bool AdminRol()
        {
            return (GirisYapanKullanici.Rol.RolAdi == "Power User" || GirisYapanKullanici.Rol.RolAdi == "Depo Admin" ? true : false);

        }


        /// <summary>
        /// varliklari düzele butonuna bastığında tabloda seçili olan varliğin bilgilerini düzenleme ekranına gönderen method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVarlikDüzenle_Click(object sender, EventArgs e)
        {
            string SecilenID = lvTablo.SelectedItems[0].SubItems[0].Text.ToString();
            if (!AdminRol())
            {
                foreach (PersonelZimmet PersonelZimmet in PersonelZimmetler)
                {
                    if (PersonelZimmet.KullaniciZimmetID == int.Parse(SecilenID))
                    {
                        SecilenPersonelZimmet = PersonelZimmet;
                    }
                }
                FrmVarlikGuncelle FrmVarlikGuncelle = new FrmVarlikGuncelle(SecilenPersonelZimmet);
                FrmVarlikGuncelle.Show();
                this.Tag = SecilenPersonelZimmet.Zimmet.Varlik;
            }
            else
            {

                foreach (Varlik varlik in Varliklar)
                {
                    if (varlik.VarlikID == int.Parse(SecilenID))
                    {
                        SecilenVarlik = varlik;
                    }

                }
                FrmVarlikGuncelle FrmVarlikGuncelle = new FrmVarlikGuncelle(SecilenVarlik);
                FrmVarlikGuncelle.Show();
                this.Tag = SecilenVarlik;
            }
            
        }
        /// <summary>
        /// labellara tıkalndığında renk değiştirtenmethod.
        /// </summary>
        /// <param name="label"></param>
        public void LabelRenkDegistir(Label label)
        {
            foreach (Control c in Controls)
            {
                if (c is Label && ((Label)c).Text == label.Text)
                {
                    ((Label)c).ForeColor = Color.DodgerBlue;
                }
                else if (c is Label)
                {
                    ((Label)c).ForeColor = Color.Black;
                }
            }
        }
    }
}
