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
using UltiaVarlik.Provider;

namespace UltiaVarlik.UI.Aksiyonlar
{
    public partial class FrmTuket : Form
    {
        MusteriVarlikDAL musterivarlik;
        private Varlik varlik;

        public FrmTuket()
        {
            InitializeComponent();
        }

        public FrmTuket(Varlik varlik) : this()
        {
            this.varlik = varlik;
        }

        private void btnTuket_Click(object sender, EventArgs e)
        {
            if (txtAboneNo.Text.DoubleKontorlu())
            {
                musterivarlik = new MusteriVarlikDAL();

                MusteriVarlik eklenecekMusteriVarlik = new MusteriVarlik()
                {
                    Aciklama = txtAcıklama.Text,
                    Musteri = new Musteri { MusteriID = int.Parse(txtAboneNo.Text) },
                    Varlik = new Varlik { VarlikID = varlik.VarlikID },
                };
                GeriDonusum donus = musterivarlik.VeriEkle(eklenecekMusteriVarlik);
                MessageBox.Show(donus.GeriDonusMesaji);
            }
            else
            {
                MessageBox.Show("Lütfen Abone No Kısmına Harf Girmeyin");
            }

        }
    }
}
