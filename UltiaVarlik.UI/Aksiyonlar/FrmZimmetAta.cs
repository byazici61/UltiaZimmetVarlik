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

namespace UltiaVarlik.UI.Aksiyonlar
{
    public partial class FrmZimmetAta : Form
    {
        private Varlik varlik;
        VarlikDepoDAL VArlikDepo;
        ZimmetDAL Zimmet;
        ZimmetNedeniDAL ZimmetNedeni;
        ZimmetTuruDAL ZimmetTuru;
        SirketEkipZimmetDAL SirketEkipZimmet;
        PersonelZimmetDAL PersonelZimmet;
        PersonelDAL Personel;
        SirketEkipDAL SirketEkip;
        int eklenenZimmetID;



        List<VarlikDepo> VArlikDepolar = new List<VarlikDepo>();
        public FrmZimmetAta()
        {
            InitializeComponent();
        }

        public FrmZimmetAta(Varlik varlik):this()
        {
            this.varlik = varlik;
        }

        private void btnZimmetAta_Click(object sender, EventArgs e)
        {
            Zimmet = new ZimmetDAL();
            VArlikDepo = new VarlikDepoDAL();
            VArlikDepolar.AddRange(VArlikDepo.VeriCek(varlik.VarlikID));
            Zimmet eklenecekZimmet = new Zimmet()
            {
                ZimmetNedeni =new ZimmetNedeni() {ZimmetNedeniID= (cmbZimmetNedeni.SelectedItem as ZimmetNedeni).ZimmetNedeniID },
                ZimmetTuru = new ZimmetTuru() { ZimmetTuruID = (cmbZimmetTuru.SelectedItem as ZimmetTuru).ZimmetTuruID },
                VarlikDepo = new VarlikDepo() { Varlik = varlik, VarlikDepoID =VArlikDepolar[0].VarlikDepoID },
                Aciklama = txtAciklama.Text

            };
            Zimmet.VeriEkle(eklenecekZimmet);
            eklenenZimmetID = Zimmet.IdDon();
            ZimmetAta(eklenenZimmetID);

        }
        GeriDonusum geri;
        private void ZimmetAta(int eklenenZimmetID)
        {
            if (cmbZimmetTuru.SelectedIndex==0 )
            {
                PersonelZimmet eklenecekPersonelZimmet = new PersonelZimmet()
                {
                    Personel = new Personel() { PersonelID = (cmbZimmetSahibi.SelectedItem as Personel).PersonelID},
                    Zimmet = new Zimmet { ZimmetID = eklenenZimmetID },
                    ZimmetBaslangicTarihi = dtpZimmetBaslangic.Value,
                    ZimmetBitisTarihi = dtpZimmetBitis.Value

                };
                PersonelZimmet = new PersonelZimmetDAL();
                 geri= PersonelZimmet.VeriEkle(eklenecekPersonelZimmet);
                MessageBox.Show(geri.GeriDonusMesaji);

            }
            else if (cmbZimmetTuru.SelectedIndex == 1)
            {
                SirketEkipZimmet eklenecekSirketSkipZimmet = new SirketEkipZimmet()
                {
                    SirketEkip = new SirketEkip() { SirketEkipID = (cmbZimmetSahibi.SelectedItem as SirketEkip).SirketEkipID },
                    Zimmet = new Zimmet { ZimmetID = eklenenZimmetID },
                    ZimmetBaslangicTarihi = dtpZimmetBaslangic.Value,
                    ZimmetBitisTarihi = dtpZimmetBitis.Value
                };
                SirketEkipZimmet = new SirketEkipZimmetDAL();
                geri =SirketEkipZimmet.VeriEkle(eklenecekSirketSkipZimmet);
                MessageBox.Show(geri.GeriDonusMesaji);

            }


        }

        private void FrmZimmetAta_Load(object sender, EventArgs e)
        {
            ZimmetNedeni = new ZimmetNedeniDAL();
            ZimmetTuru = new ZimmetTuruDAL();

            cmbZimmetNedeni.Items.AddRange(ZimmetNedeni.VeriCek().ToArray());
            cmbZimmetTuru.Items.AddRange(ZimmetTuru.VeriCek().ToArray());

        }

        private void cmbZimmetTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbZimmetSahibi.Items.Clear();
            Personel = new PersonelDAL();
            SirketEkip = new SirketEkipDAL();
            cmbZimmetSahibi.Visible = true;
            if (cmbZimmetTuru.SelectedIndex==0)
            {
                cmbZimmetSahibi.Items.AddRange(Personel.VeriCek().ToArray());

            }
            else if (cmbZimmetTuru.SelectedIndex == 1)
            {
                cmbZimmetSahibi.Items.AddRange(SirketEkip.VeriCek().ToArray());
            }
            else
            {
                MessageBox.Show("Şirket bazında atama yapmak içiçn yetkiniz yok");
                cmbZimmetSahibi.SelectedItem = null;
            }

        }
    }
}
