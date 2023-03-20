using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltiaVarlik.DAL.DAL;
using UltiaVarlik.DTO;
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
            Personel girisYapanKullanici = personelGiris.VeriCek(txtKullanıcıMail.Text, txtSifre.Text);
            if (girisYapanKullanici!=null)
            {
                
                FrmGenelEkran frmGenel = new FrmGenelEkran(girisYapanKullanici);
                frmGenel.Show();
                this.Hide();
            }
            


        }
    }
}
