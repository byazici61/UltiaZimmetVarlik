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

        List<Fiyat> fiyatlar;
        List<ParaBirimi> paraBirimleri;
        List<VarlikGrubu> varlikGrublari;
        List<Varlik> varliklar;
        List<MarkaModel> MarkalarModeller;

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


            txtFiyat.Text = fiyatlar[0].ParaMiktari.ToString();
            cmbMaliyetParaBirimi.Items.AddRange(paraBirimleri.ToArray());
            cmbFiyatParaBirimi.Items.AddRange(paraBirimleri.ToArray());
            cmbUrunTipi.Items.AddRange(varlikGrublari.ToArray());
            cmbMarka.Items.AddRange(MarkalarModeller.ToArray());
            txtBarkod.Text = varliklar[0].Barkot.ToString();
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
            cmbFiyatParaBirimi.SelectedItem = fiyatlar[0];
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
                txtBarkod.Enabled = true;
            }
            else
            {
                txtBarkod.Enabled = false;
                cmbBirim.Visible = true;
                numAdet.Visible = true;
                lblBirim.Visible = true;
                lblAdet.Visible = true;
            }
            

        }
    }
}
