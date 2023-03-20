﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltiaVarlik.DAL.DAL;
using UltiaVarlik.DTO.GeriDonusTipi;

namespace UltiaVarlik.UI
{
    public partial class FrmGirisEkrani : Form
    {
        public FrmGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            PersonelGirisDAL personelGiris = new PersonelGirisDAL();
            GeriDonusum sonuc = personelGiris.VeriCek(txtKullanıcıMail.Text, txtSifre.Text);
            if (sonuc.GeriDonusTipi)
            {
                FrmGenelEkran frmGenel = new FrmGenelEkran();
                frmGenel.Show();
                this.Hide();
            }
            else MessageBox.Show(sonuc.GeriDonusMesaji);


        }
    }
}