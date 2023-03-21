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

namespace UltiaVarlik.UI
{
    public partial class FrmVarlikGuncelle : Form
    {
        public FrmVarlikGuncelle()
        {
            InitializeComponent();
        }

        private void FrmVarlikGuncelle_Load(object sender, EventArgs e)
        {
            ComboBoxlariDoldur();
            
        }

        private void ComboBoxlariDoldur()
        {
            VarlikGrubuDAL varlikGrubu = new VarlikGrubuDAL();
            cmbUrunTipi.Items.AddRange(varlikGrubu.VeriCek().ToArray());
            ParaBirimiDAL paraBirimi = new ParaBirimiDAL();
            cmbMaliyetParaBirimi.Items.AddRange(paraBirimi.VeriCek().ToArray());
        }
    }
}
