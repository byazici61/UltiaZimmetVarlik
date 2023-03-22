using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltiaVarlik.DAL.ArayuzDeposu;
using UltiaVarlik.DTO;
using UltiaVarlik.Provider;

namespace UltiaVarlik.DAL.DAL
{
    public class VarlikGrubuDAL : IVeriCek<VarlikGrubu>
    {
        List<VarlikGrubu> varlikGrubuListesi;
        /// <summary>
        /// DB den varlik Gruplarini çeken DAL
        /// </summary>
        /// <returns></returns>
        public List<VarlikGrubu> VeriCek()
        {

            MSSQLSaglayicisi con = new MSSQLSaglayicisi("select VarlikGrubuID,VarlikGrubuAdi from VarlikGrubu where AktifMi = 'True'");
            SqlDataReader rdr = con.ExcuteRedaer();
            if (rdr.HasRows)
            {
                varlikGrubuListesi = new List<VarlikGrubu>();
                while (rdr.Read())
                {
                    varlikGrubuListesi.Add(new VarlikGrubu()
                    {
                        VarlikGrubuID = rdr.GetInt32(0),
                        VarlikGrubuAdi = rdr.GetString(1),
                        
                    });
                }
                
            }
            return varlikGrubuListesi;


        }
    }
}
