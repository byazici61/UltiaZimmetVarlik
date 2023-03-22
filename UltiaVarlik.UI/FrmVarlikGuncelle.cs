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
        private PersonelZimmet secilenPersonelZimmet;
        private Varlik secilenVarlik;
        ModelDAL Model;
        MarkaDAL Marka;
        VarlikDAL varlik;
        VarlikGrubuDAL varlikGrubu;
        ParaBirimiDAL paraBirimi;
        FiyatDAL fiyat;
        BirimDAL birim;

        List<Fiyat> fiyatlar;
        List<ParaBirimi> paraBirimleri;
        List<VarlikGrubu> varlikGrublari;
        List<Varlik> varliklar;
        List<MarkaModel> MarkalarModeller;
        List<Birim> birimler;

        public FrmVarlikGuncelle()
        {
            InitializeComponent();
        }

        public FrmVarlikGuncelle(PersonelZimmet secilenPersonelZimmet) : this()
        {
            this.secilenPersonelZimmet = secilenPersonelZimmet;
        } 
        public FrmVarlikGuncelle(Varlik secilenVarlik) : this()
        {
            this.secilenVarlik = secilenVarlik;
        }

        private void FrmVarlikGuncelle_Load(object sender, EventArgs e)
        {
            FormuDoldur();

        }

        private void FormuDoldur()
        {

            fiyat = new FiyatDAL();
            paraBirimi = new ParaBirimiDAL();
            varlikGrubu = new VarlikGrubuDAL();
            varlik = new VarlikDAL();
            Marka = new MarkaDAL();
            Model = new ModelDAL();
            birim = new BirimDAL();
            if (secilenVarlik==null)
            {
                fiyatlar = fiyat.VeriCek(secilenPersonelZimmet.Zimmet.Varlik.VarlikID);
                varliklar = varlik.VeriCek(secilenPersonelZimmet.Zimmet.Varlik.VarlikID);
            }
            else
            {
                fiyatlar = fiyat.VeriCek(secilenVarlik.VarlikID);
                varliklar = varlik.VeriCek(secilenVarlik.VarlikID);
            }
            
            paraBirimleri = paraBirimi.VeriCek();
            varlikGrublari = varlikGrubu.VeriCek();
            MarkalarModeller = Marka.VeriCek();
            birimler = birim.VeriCek();
          
            txtFiyat.Text = fiyatlar[0].ParaMiktari.ToString();
            cmbFiyatParaBirimi.Items.AddRange(paraBirimleri.ToArray());
            
            txtBarkod.Text = varliklar[0].Barkot.ToString();
            if (varliklar[0].Barkot==Guid.Empty)
            {
                cmbBirim.Text = varliklar[0].Birim.BirimAdi;
                numAdet.Value = Convert.ToDecimal(varliklar[0].Miktar);
                cbBarkod.Checked = false;
            }
            else
            {
                cmbBirim.Visible = false;
                numAdet.Visible = false;
                lblBirim.Visible = false;
                lblAdet.Visible = false;

            }
            cmbUrunTipi.SelectedItem = varliklar[0].VarlikGrubu;
            cmbUrunTipi.Text = varliklar[0].VarlikGrubu.VarlikGrubuAdi;
            cmbMarka.SelectedItem = varliklar[0].MarkaModel.UstMarkaModel;
            cmbMarka.Text = varliklar[0].MarkaModel.UstMarkaModel.MarkaModeAdi;
            cmbModel.Text = varliklar[0].MarkaModel.MarkaModeAdi;
            cmbGaranti.SelectedIndex = (varliklar[0].GarantiliMi == true ? 1 : 0);
            dtpGiris.Value = varliklar[0].CikisTarihi;
            txtMaliyet.Text = varliklar[0].MaliyetFiyati.ToString();
            cmbMaliyetParaBirimi.SelectedItem = varliklar[0].MaaliyetParaBirimi;
            cmbMaliyetParaBirimi.Text = varliklar[0].MaaliyetParaBirimi.ParaBirimiAdi;
            txtFiyat.Text = fiyatlar[0].ParaMiktari.ToString();
            cmbFiyatParaBirimi.SelectedItem = fiyatlar[0].ParaBirimi;
            cmbFiyatParaBirimi.Text = fiyatlar[0].ParaBirimi.ParaBirimiAdi;
            txtAciklama.Text = varliklar[0].Aciklama;


        }
        public void MarkayaGoreModelleriGuncelle()
        {
            cmbModel.Items.Clear();
            cmbModel.Text = "";
            MarkalarModeller = Model.VeriCek((cmbMarka.SelectedItem as MarkaModel).MarkaModelID);
            cmbModel.Items.AddRange(MarkalarModeller.ToArray());
        }
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarkayaGoreModelleriGuncelle();
        }

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

     
        private void btnKaydet_Click(object sender, EventArgs e)
        {
  
            Varlik düzenleneceVarlik = new Varlik()
            {
                Aciklama = txtAciklama.Text,
                GarantiliMi = cmbGaranti.SelectedIndex == 1 ? true : false,
                VarlikID = varliklar[0].VarlikID
                
            };
            Fiyat eklenecekFiyat = new Fiyat()
            {
                ParaMiktari = double.Parse(txtFiyat.Text),
                ParaBirimi = new ParaBirimi() { ParaBirimiID = (cmbFiyatParaBirimi.SelectedItem as ParaBirimi).ParaBirimiID },
                Varlik = new Varlik() { VarlikID = varliklar[0].VarlikID }
            };
            varlik = new VarlikDAL();
            fiyat = new FiyatDAL();
            GeriDonusum g1 = varlik.VeriDuzenle(düzenleneceVarlik);
            GeriDonusum g2 =fiyat.VeriEkle(eklenecekFiyat);
            MessageBox.Show(g1.GeriDonusMesaji+" "+g2.GeriDonusMesaji);
        }

        private void cmbAksiyonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbAksiyonlar.SelectedIndex)
            {
                case 0:
                    FrmTuket frmTuket = new FrmTuket(varliklar[0]);
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
