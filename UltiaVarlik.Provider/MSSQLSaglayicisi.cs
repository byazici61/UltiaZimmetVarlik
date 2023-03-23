using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.Provider
{
    public class MSSQLSaglayicisi
    {
        SqlConnection conn = null;
        public SqlCommand cmd = null;
        
        /// <summary>
        /// Default bir  connection stirnge sahip const. Parametre olarak verilen queryİ ilkgili db de işleme sokar
        /// </summary>
        /// <param name="YapilamakIstenenQuery"></param>
        /// <param name="Adres"></param>
        public MSSQLSaglayicisi(string YapilamakIstenenQuery, string Adres = "server=DESKTOP-CI8397F\\MSSQLSERVER03;Database=VarlıkDB;uid=sa;pwd=123")
        {
            conn = new SqlConnection(Adres);
            cmd = new SqlCommand();
            cmd.CommandText = YapilamakIstenenQuery;

            cmd.Connection = conn;
        }


        /// <summary>
        /// Baglantinin durumuna göre Bağlantı Açar.
        /// </summary>
        public void BaglantiKapat()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }

        /// <summary>
        /// Baglantinin durumuna göre Bağlantı kapatır.
        /// </summary>
        public void BaglantiAc()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }

        /// <summary>
        /// insert update delete işlemleri için execute 
        /// </summary>
        /// <returns></returns>
        public int ExcecuteNon()
        {
            int result = 0;

            try
            {
                BaglantiAc();
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex )
            {

                result = 0;
            }
            finally
            {
                BaglantiKapat();
            }

            return result;

        }

        /// <summary>
        /// Tek bir değer sorgular için execute
        /// </summary>
        /// <returns></returns>
        public object ExecutScalar()
        {
            object result = null;

            try
            {
                BaglantiAc();
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex )
            {


            }
            finally
            {
                BaglantiKapat();
            }


            return result;
        }
      
        /// <summary>
        /// select işlemi için execute
        /// </summary>
        /// <returns></returns>
        ///
        public SqlDataReader ExcuteRedaer()
        {
            SqlDataReader rdr = null;
            try
            {
                BaglantiAc();
                rdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {

                
            }
            return rdr;
        }

        /// <summary>
        /// Giriilen parameterleri işleme sokan method
        /// </summary>
        /// <param name="sqlParameters"></param>
        public void ParametreEkle(SqlParameter[] sqlParameters)
        {
           
            cmd.Parameters.AddRange(sqlParameters);

        }
    }
}
