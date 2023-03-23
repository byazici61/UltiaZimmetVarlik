using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UltiaVarlik.DAL;
using UltiaVarlik.DAL.DAL;
using UltiaVarlik.DTO;

namespace UltiaVarlik.UI.RaporEkranlari
{
    public partial class ParaBirimiRapor : Form
    {
        ParaBirimiDAL ParaBirimi;
        VarlikDAL Varlik; 
        public ParaBirimiRapor()
        {
            InitializeComponent();
        }

        private void ParaBirimiRapor_Load(object sender, EventArgs e)
        {
            ParaBirimi = new ParaBirimiDAL();
            cmbParaBirimi.Items.AddRange(ParaBirimi.VeriCek().ToArray());
        }

        /// <summary>
        /// para birimine göre tabloyu dolduran ve toplam fiyatı yazan method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbParaBirimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBilgi.Text = "";
            lvTablo.Items.Clear();

            double ToplamFiyat = 0;
            Varlik = new VarlikDAL();
            List<Varlik> varliklar = Varlik.VeriCek((cmbParaBirimi.SelectedItem as ParaBirimi).ParaBirimiAdi);
            if (varliklar!=null)
            {
                foreach (Varlik item in varliklar)
                {
                    ToplamFiyat += item.Fiyat;
                    ListViewItem lvi = new ListViewItem(item.MarkaModel.MarkaModeAdi);
                    lvi.SubItems.Add(item.VarlikGrubu.VarlikGrubuAdi);
                    lvi.SubItems.Add(item.Fiyat.ToString());
                    lvTablo.Items.Add(lvi);
                }
                lblBilgi.Text = "Urunlerin Toplam Değeri :" + ToplamFiyat.ToString() + " " + cmbParaBirimi.SelectedItem;

            }
            else
            {

                MessageBox.Show("Bu Para Biriminde Kayıtlı Ürün Yok");
            }
            

        }
    }
}
