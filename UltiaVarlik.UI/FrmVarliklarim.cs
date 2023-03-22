﻿using System;
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
        private Personel girisYapanKullanici;
        List<SirketEkipZimmet> sirketEkipZimmetler;
        List<PersonelZimmet> personelZimmetler;
        PersonelZimmet secilenPersonelZimmet;
        List<Varlik> varliklar;
        Varlik secilenVarlik;
        public FrmVarliklarim()
        {
            InitializeComponent();
        }

        public FrmVarliklarim(Personel girisYapanKullanici) : this()
        {
            this.girisYapanKullanici = girisYapanKullanici;

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
            VarlikDAL varlik = new VarlikDAL();
            varliklar = varlik.VeriCek();
            foreach (Varlik item in varliklar)
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
            PersonelZimmetDAL personelZimmet = new PersonelZimmetDAL();
            personelZimmetler = personelZimmet.VeriCek(girisYapanKullanici.PersonelID);
            foreach (PersonelZimmet item in personelZimmetler)
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
            sirketEkipZimmetler = sirketEkipZimmet.VeriCek(girisYapanKullanici.SirketEkip.SirketEkipID);
            foreach (SirketEkipZimmet item in sirketEkipZimmetler)
            {
                ListViewItem lvi = new ListViewItem(item.SirketEkipZimmetID.ToString());
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
            return (girisYapanKullanici.Rol.RolAdi == "Power User" || girisYapanKullanici.Rol.RolAdi == "Depo Admin" ? true : false);

        }


        /// <summary>
        /// varliklari düzele butonuna bastığında tabloda seçili olan varliğin bilgilerini düzenleme ekranına gönderen method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVarlikDüzenle_Click(object sender, EventArgs e)
        {
            string secilenID = lvTablo.SelectedItems[0].SubItems[0].Text.ToString();
            if (!AdminRol())
            {
                foreach (PersonelZimmet personelZimmet in personelZimmetler)
                {
                    if (personelZimmet.KullaniciZimmetID == int.Parse(secilenID))
                    {
                        secilenPersonelZimmet = personelZimmet;
                    }
                }
                FrmVarlikGuncelle frmVarlikGuncelle = new FrmVarlikGuncelle(secilenPersonelZimmet);
                frmVarlikGuncelle.Show();
                this.Tag = secilenPersonelZimmet.Zimmet.Varlik;
            }
            else
            {

                foreach (Varlik varlik in varliklar)
                {
                    if (varlik.VarlikID == int.Parse(secilenID))
                    {
                        secilenVarlik = varlik;
                    }

                }
                FrmVarlikGuncelle frmVarlikGuncelle = new FrmVarlikGuncelle(secilenVarlik);
                frmVarlikGuncelle.Show();
                this.Tag = secilenVarlik;
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
