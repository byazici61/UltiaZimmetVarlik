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
        SqlCommand[] sqlcommandlar;

        public MSSQLSaglayicisi(string YapilamakIstenenQuery, string Adres = "server=DESKTOP-CI8397F\\MSSQLSERVER03;Database=VarlıkDB;uid=sa;pwd=123")
        {
            conn = new SqlConnection(Adres);
            cmd = new SqlCommand();
            cmd.CommandText = YapilamakIstenenQuery;

            cmd.Connection = conn;
        }
        public MSSQLSaglayicisi(string YapilamakIstenenBirinciQuery, string YapilamakIstenenIkinciQuery, string ConnectionText = "server=DESKTOP-CI8397F\\MSSQLSERVER03;Database=VarlıkDB;uid=sa;pwd=123")
        {
            conn = new SqlConnection(ConnectionText);
            sqlcommandlar[0] = new SqlCommand(YapilamakIstenenBirinciQuery, conn);
            sqlcommandlar[1] = new SqlCommand(YapilamakIstenenIkinciQuery, conn);
        }

        public void BaglantiKapat()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
        public void BaglantiAc()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }


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


        public object ExecutScalar()
        {
            object result = null;

            try
            {
                BaglantiAc();
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                BaglantiKapat();
            }


            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SqlDataReader ExcuteRedaer()//yukardakiyle aynı yukarda sadece try cach var
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

        public void TransactionFoksiyonu()
        {

            BaglantiAc();

            SqlTransaction transaction = conn.BeginTransaction(); ;
            foreach (SqlCommand command in sqlcommandlar)
            {

                command.Transaction = transaction;
            }
            try
            {

                foreach (SqlCommand command in sqlcommandlar)
                {
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                Console.WriteLine("Transaction geri alındı." + ex.Message);
            }
            finally
            {
                BaglantiKapat();
            }
        }



        public void ParametreEkle(SqlParameter[] sqlParameters)
        {
           
            cmd.Parameters.AddRange(sqlParameters);

        }
    }
}
