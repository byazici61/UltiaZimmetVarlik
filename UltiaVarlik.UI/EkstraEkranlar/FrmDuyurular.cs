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
    
    public partial class FrmDuyurular : Form
    {
        DuyuruDAL duyuru;
        List<Duyuru> duyurular;
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        private void treeDuyuru_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            duyuru = new DuyuruDAL();
            duyurular = new List<Duyuru>();
            duyurular.AddRange(duyuru.VeriCek().ToArray());
            foreach (Duyuru item in duyurular)
            {
                treeDuyuru.Nodes.Add(item.DuyuruBasligi).Nodes.Add(item.DuyuruMetni);

            }
            
            
        }
    }
}
