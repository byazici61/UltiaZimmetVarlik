using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UltiaVarlik.DAL.DAL;
using UltiaVarlik.DTO;

namespace UltiaVarlik.UI.RaporEkranlari
{
    public partial class DepoRapor : Form
    {
        DepoDAL Depo;
        VarlikDepoDAL VarlikDepo;
        public DepoRapor()
        {
            InitializeComponent();
        }

        private void DepoRapor_Load(object sender, EventArgs e)
        {
            Depo = new DepoDAL();
            cmbDepo.Items.AddRange(Depo.VeriCek().ToArray());
        }
        /// <summary>
        /// depo bilgisine göre lisitviewi düzenleyen method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDepo.Items.Clear();
            List<VarlikDepo> varlikDepolar = new List<VarlikDepo>(); 
            VarlikDepo = new VarlikDepoDAL();
            varlikDepolar = VarlikDepo.VeriCek((cmbDepo.SelectedItem as Depo).DepoID);
            foreach (VarlikDepo item in varlikDepolar)
            {
                ListViewItem lvi = new ListViewItem(item.Varlik.MarkaModel.MarkaModeAdi);
                lvi.SubItems.Add(item.Varlik.Fiyat.ToString());
                lvi.SubItems.Add(item.Varlik.Aciklama);
                lvDepo.Items.Add(lvi);
            }

        }
    }
}
