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
using UltiaVarlik.DTO.GeriDonusTipi;
using UltiaVarlik.UI.Aksiyonlar;

namespace UltiaVarlik.UI
{
    public partial class FrmVarlikGuncelle : Form
    {
        private PersonelZimmet SecilenPersonelZimmet;
        private Varlik SecilenVarlik;
        ModelDAL Model;
        MarkaDAL Marka;
        VarlikDAL Varlik;
        VarlikGrubuDAL VarlikGrubu;
        ParaBirimiDAL ParaBirimi;
        FiyatDAL Fiyat;
        BirimDAL Birim;

        List<Fiyat> Fiyatlar;
        List<ParaBirimi> ParaBirimleri;
        //List<VarlikGrubu> varlikGrublari;
        List<Varlik> Varliklar;
        List<MarkaModel> MarkalarModeller;
        //List<Birim> birimler;

        public FrmVarlikGuncelle()
        {
            InitializeComponent();
        }

        public FrmVarlikGuncelle(PersonelZimmet secilenPersonelZimmet) : this()
        {
            this.SecilenPersonelZimmet = secilenPersonelZimmet;
        } 
        public FrmVarlikGuncelle(Varlik secilenVarlik) : this()
        {
            this.SecilenVarlik = secilenVarlik;
        }

        private void FrmVarlikGuncelle_Load(object sender, EventArgs e)
        {
            FormuDoldur();

        }

        /// <summary>
        /// Formun ilgili compeneentlerini DAL lardan gelen bilgilerle dolduran method
        /// </summary>
        private void FormuDoldur()
        {

            Fiyat = new FiyatDAL();
            ParaBirimi = new ParaBirimiDAL();
            VarlikGrubu = new VarlikGrubuDAL();
            Varlik = new VarlikDAL();
            Marka = new MarkaDAL();
            Model = new ModelDAL();
            Birim = new BirimDAL();
            if (SecilenVarlik==null)
            {
                Fiyatlar = Fiyat.VeriCek(SecilenPersonelZimmet.Zimmet.Varlik.VarlikID);
                Varliklar = Varlik.VeriCek(SecilenPersonelZimmet.Zimmet.Varlik.VarlikID);
            }
            else
            {
                Fiyatlar = Fiyat.VeriCek(SecilenVarlik.VarlikID);
                Varliklar = Varlik.VeriCek(SecilenVarlik.VarlikID);
            }
            
            ParaBirimleri = ParaBirimi.VeriCek();
            //varlikGrublari = VarlikGrubu.VeriCek();
            MarkalarModeller = Marka.VeriCek();
            //birimler = Birim.VeriCek();
          
            txtFiyat.Text = Fiyatlar[0].ParaMiktari.ToString();
            cmbFiyatParaBirimi.Items.AddRange(ParaBirimleri.ToArray());
            
            txtBarkod.Text = Varliklar[0].Barkot.ToString();
            if (Varliklar[0].Barkot==Guid.Empty)
            {
                cmbBirim.Text = Varliklar[0].Birim.BirimAdi;
                numAdet.Value = Convert.ToDecimal(Varliklar[0].Miktar);
                cbBarkod.Checked = false;
            }
            else
            {
                cmbBirim.Visible = false;
                numAdet.Visible = false;
                lblBirim.Visible = false;
                lblAdet.Visible = false;

            }
            cmbUrunTipi.SelectedItem = Varliklar[0].VarlikGrubu;
            cmbUrunTipi.Text = Varliklar[0].VarlikGrubu.VarlikGrubuAdi;
            cmbMarka.SelectedItem = Varliklar[0].MarkaModel.UstMarkaModel;
            cmbMarka.Text = Varliklar[0].MarkaModel.UstMarkaModel.MarkaModeAdi;
            cmbModel.Text = Varliklar[0].MarkaModel.MarkaModeAdi;
            cmbGaranti.SelectedIndex = (Varliklar[0].GarantiliMi == true ? 1 : 0);
            dtpGiris.Value = Varliklar[0].CikisTarihi;
            txtMaliyet.Text = Varliklar[0].MaliyetFiyati.ToString();
            cmbMaliyetParaBirimi.SelectedItem = Varliklar[0].MaaliyetParaBirimi;
            cmbMaliyetParaBirimi.Text = Varliklar[0].MaaliyetParaBirimi.ParaBirimiAdi;
            txtFiyat.Text = Fiyatlar[0].ParaMiktari.ToString();
            cmbFiyatParaBirimi.SelectedItem = Fiyatlar[0].ParaBirimi;
            cmbFiyatParaBirimi.Text = Fiyatlar[0].ParaBirimi.ParaBirimiAdi;
            txtAciklama.Text = Varliklar[0].Aciklama;


        }


        /// <summary>
        /// MArkaya Göre modelleri listle fonksiyonu yazılmış fakat analizde bir talep olmadığı için kullanılmadan bırakılmıştır.
        /// </summary>
        public void MarkayaGoreModelleriGuncelle()
        {
            cmbModel.Items.Clear();
            cmbModel.Text = "";
            MarkalarModeller = Model.VeriCek((cmbMarka.SelectedItem as MarkaModel).MarkaModelID);
            cmbModel.Items.AddRange(MarkalarModeller.ToArray());
        }
        /// <summary>
        /// marka füzenlenbilir bırakılsaydı seçilen markaya göre modelleri getirren method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarkayaGoreModelleriGuncelle();
        }



        /// <summary>
        /// Barkod durumuna göre ilgili kompanentlerin davranışlarını düzenleyen method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBarkod_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBarkod.Checked)
            {
                cmbBirim.Visible = false;
                numAdet.Visible = false;
                lblBirim.Visible = false;
                lblAdet.Visible = false;
                
            }
            else
            {
              
                cmbBirim.Visible = true;
                numAdet.Visible = true;
                lblBirim.Visible = true;
                lblAdet.Visible = true;
            }
            

        }

         /// <summary>
         /// kaydet Butonu Eventi
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            VarlikGuncelle();
        }

        /// <summary>
        /// Kaydet Butonuna tıklandığında İlgili DAlları kullanarak yeni fiyat oluşturan ve varlığın özellikleirni düzenleyen method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void VarlikGuncelle()
        {
            Varlik düzenleneceVarlik = new Varlik()
            {
                Aciklama = txtAciklama.Text,
                GarantiliMi = cmbGaranti.SelectedIndex == 1 ? true : false,
                VarlikID = Varliklar[0].VarlikID

            };
            Fiyat eklenecekFiyat = new Fiyat()
            {
                ParaMiktari = double.Parse(txtFiyat.Text),
                ParaBirimi = new ParaBirimi() { ParaBirimiID = (cmbFiyatParaBirimi.SelectedItem as ParaBirimi).ParaBirimiID },
                Varlik = new Varlik() { VarlikID = Varliklar[0].VarlikID }
            };
            Varlik = new VarlikDAL();
            Fiyat = new FiyatDAL();
            GeriDonusum g1 = Varlik.VeriDuzenle(düzenleneceVarlik);
            GeriDonusum g2 = Fiyat.VeriEkle(eklenecekFiyat);
            MessageBox.Show(g1.GeriDonusMesaji + " " + g2.GeriDonusMesaji);


        }


        /// <summary>
        /// Aksiyonlarda seçili işleme göre yönlendirme yapan case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAksiyonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbAksiyonlar.SelectedIndex)
            {
                case 0:
                    FrmTuket frmTuket = new FrmTuket(Varliklar[0]);
                    frmTuket.Show();
                    break;
                case 1:
                    FrmZimmetAta frmZimmetAta = new FrmZimmetAta();
                    frmZimmetAta.Show();
                    break;
                default:
                    MessageBox.Show("Giriş Yetkiniz Bulunmamakta");
                    break;
            }
        }
    }
}
