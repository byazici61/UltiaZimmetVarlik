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

namespace UltiaVarlik.UI.EkstraEkranlar
{
    public partial class FrmSorular : Form
    {

        SoruDAL soru;
        List<Soru> sorular;
        public FrmSorular()
        {
            InitializeComponent();
        }

        private void FrmSorular_Load(object sender, EventArgs e)
        {
            soru = new SoruDAL();
            sorular = new List<Soru>();
            sorular.AddRange(soru.VeriCek().ToArray());
            foreach (Soru item in sorular)
            {
                treeSoru.Nodes.Add(item.SoruMetni).Nodes.Add(item.Cevap);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
