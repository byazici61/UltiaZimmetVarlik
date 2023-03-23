using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UltiaVarlik.DAL.DAL;
using UltiaVarlik.DTO;

namespace UltiaVarlik.UI.EkstraEkranlar
{
    public partial class FrmSorular : Form
    {

        SoruDAL Soru;
        List<Soru> Sorular;
        public FrmSorular()
        {
            InitializeComponent();
        }
        /// <summary>
        /// sorularla tree dolduran method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSorular_Load(object sender, EventArgs e)
        {
            Soru = new SoruDAL();
            Sorular = new List<Soru>();
            Sorular.AddRange(Soru.VeriCek().ToArray());
            foreach (Soru item in Sorular)
            {
                treeSoru.Nodes.Add(item.SoruMetni).Nodes.Add(item.Cevap);
            }
            
        }

    }
}
