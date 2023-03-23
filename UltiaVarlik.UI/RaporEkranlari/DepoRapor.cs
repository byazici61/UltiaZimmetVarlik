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

namespace UltiaVarlik.UI.RaporEkranlari
{
    public partial class DepoRapor : Form
    {
        DepoDAL depo;
        VarlikDepoDAL varlikDepo;
        public DepoRapor()
        {
            InitializeComponent();
        }

        private void DepoRapor_Load(object sender, EventArgs e)
        {
            depo = new DepoDAL();
            cmbDepo.Items.AddRange(depo.VeriCek().ToArray());
        }

        private void cmbDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDepo.Items.Clear();
            List<VarlikDepo> varlikDepolar = new List<VarlikDepo>(); 
            varlikDepo = new VarlikDepoDAL();
            varlikDepolar = varlikDepo.VeriCek((cmbDepo.SelectedItem as Depo).DepoID);
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
