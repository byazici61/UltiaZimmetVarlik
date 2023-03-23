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

namespace UltiaVarlik.UI.RaporEkranlari
{
    public partial class ParaBirimiRapor : Form
    {
        ParaBirimiDAL paraBirimi;
        VarlikDAL varlik; 
        public ParaBirimiRapor()
        {
            InitializeComponent();
        }

        private void ParaBirimiRapor_Load(object sender, EventArgs e)
        {
            paraBirimi = new ParaBirimiDAL();
            cmbParaBirimi.Items.AddRange(paraBirimi.VeriCek().ToArray());
        }

        private void cmbParaBirimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBilgi.Text = "";
            lvTablo.Items.Clear();

            double ToplamFiyat = 0;
            varlik = new VarlikDAL();
            List<Varlik> varliklar = varlik.VeriCek((cmbParaBirimi.SelectedItem as ParaBirimi).ParaBirimiAdi);
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
