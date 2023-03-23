using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UltiaVarlik.DAL.DAL;
using UltiaVarlik.DTO;

namespace UltiaVarlik.UI.EkstraEkranlar
{
    
    public partial class FrmDuyurular : Form
    {
        DuyuruDAL Duyuru;
        List<Duyuru> Duyurular;
        public FrmDuyurular()
        {
            InitializeComponent();
        }


        /// <summary>
        /// duyurukları ve cevaplarını tree ye ekleyen fonk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            Duyuru = new DuyuruDAL();
            Duyurular = new List<Duyuru>();
            Duyurular.AddRange(Duyuru.VeriCek().ToArray());
            foreach (Duyuru item in Duyurular)
            {
                treeDuyuru.Nodes.Add(item.DuyuruBasligi).Nodes.Add(item.DuyuruMetni);

            }
            
            
        }
    }
}
