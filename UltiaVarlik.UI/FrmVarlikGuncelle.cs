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
        private PersonelZimmet personelZimmet;
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

        public FrmVarlikGuncelle(PersonelZimmet personelZimmet) : this()
        {
            this.personelZimmet = personelZimmet;
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

            fiyatlar = fiyat.VeriCek(1);
            paraBirimleri = paraBirimi.VeriCek();
            varlikGrublari = varlikGrubu.VeriCek();
            varliklar = varlik.VeriCek(1);
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

            -
        }
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarkayaGoreModelleriGuncelle();
        }
    }
}
