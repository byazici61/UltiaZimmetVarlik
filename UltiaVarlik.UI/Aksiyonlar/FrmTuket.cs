using System;
using System.Windows.Forms;
using UltiaVarlik.DAL.DAL;
using UltiaVarlik.DTO;
using UltiaVarlik.DTO.GeriDonusTipi;
using UltiaVarlik.Provider;

namespace UltiaVarlik.UI.Aksiyonlar
{
    public partial class FrmTuket : Form
    {
        MusteriVarlikDAL MusteriVarlik;
        private Varlik Varlik;

        public FrmTuket()
        {
            InitializeComponent();
        }

        public FrmTuket(Varlik varlik) : this()
        {
            this.Varlik = varlik;
        }
        /// <summary>
        /// tüketme işlemini yapan event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTuket_Click(object sender, EventArgs e)
        {
            if (txtAboneNo.Text.DoubleKontorlu())
            {
                MusteriVarlik = new MusteriVarlikDAL();

                MusteriVarlik eklenecekMusteriVarlik = new MusteriVarlik()
                {
                    Aciklama = txtAcıklama.Text,
                    Musteri = new Musteri { MusteriID = int.Parse(txtAboneNo.Text) },
                    Varlik = new Varlik { VarlikID = Varlik.VarlikID },
                };
                GeriDonusum donus = MusteriVarlik.VeriEkle(eklenecekMusteriVarlik);
                MessageBox.Show(donus.GeriDonusMesaji);
            }
            else
            {
                MessageBox.Show("Lütfen Abone No Kısmına Harf Girmeyin");
            }

        }
    }
}
