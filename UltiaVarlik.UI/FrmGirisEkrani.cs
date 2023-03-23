using System;
using System.Windows.Forms;
using UltiaVarlik.DAL.DAL;
using UltiaVarlik.DTO;


namespace UltiaVarlik.UI
{
    public partial class FrmGirisEkrani : Form
    {
        public FrmGirisEkrani()
        {
            InitializeComponent();
            txtSifre.PasswordChar = '*';
        }
        /// <summary>
        /// Giriş yap butonunda db den şifre kontrolü yapıp doğru kullanıcı ise giriş yapar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            PersonelGirisDAL PersonelGiris = new PersonelGirisDAL();
            Personel GirisYapanKullanici = PersonelGiris.VeriCek(txtKullanıcıMail.Text, txtSifre.Text);
            if (GirisYapanKullanici!=null)
            {
                
                FrmGenelEkran FrmGenel = new FrmGenelEkran(GirisYapanKullanici);
                FrmGenel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Mail ve Şifrenizi eksiksiz ve Doğru Girini");
            }
            


        }


        /// <summary>
        /// Şifreyi gösterme Gizlme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSifereGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifereGöster.Checked)
            {
                txtSifre.PasswordChar = '\0';
                cbSifereGöster.Text = "Sifreyi Gizle";

            }
            else
            {
                txtSifre.PasswordChar = '*';
                cbSifereGöster.Text = "Sifreyi Göster";
            }
        }
    }
}
