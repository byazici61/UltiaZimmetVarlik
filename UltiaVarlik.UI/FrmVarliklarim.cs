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
        public FrmVarliklarim()
        {
            InitializeComponent();
        }

        private void lblEkipVarliklar_Load(object sender, EventArgs e)
        {

        }

        private void lblTumVarliklar_Click(object sender, EventArgs e)
        {
            lvTablo.Items.Clear();
            VarlikDAL varlik = new VarlikDAL();
            List<Varlik> varliklar = varlik.VeriCek();
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
            
        }
        private void lblVarliklarim_Click(object sender, EventArgs e)
        {
            lvTablo.Items.Clear();
            PersonelZimmetDAL personelZimmet = new PersonelZimmetDAL();
            List<PersonelZimmet> personelZimmetler = personelZimmet.VeriCek(2);
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
        }

        private void lblEkipVarliklar_Click(object sender, EventArgs e)
        {
            lvTablo.Items.Clear();
            SirketEkipZimmetDAL sirketEkipZimmet = new SirketEkipZimmetDAL();
            List<SirketEkipZimmet> sirketEkipZimmetler = sirketEkipZimmet.VeriCek(2);
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

        }
    }
}