using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace IntecAppWS.Database
{
    public class DBConnection
    {
        string ConnectionString = "Server=tcp:intecappwsdb.database.windows.net,1433;Initial Catalog=IntecAppWS;Persist Security Info=False;User ID=intecappadmin;Password=Intecapp1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection con;

        public DBConnection()
        {
            this.OpenConection();
        }
        private void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }


        public bool Login(int id, string pin)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_LOGIN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters.Add("@PIN", SqlDbType.VarChar,255);
            cmd.Parameters.Add("@LOGIN", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@ID"].Value = id;
            cmd.Parameters["@PIN"].Value = pin;

            cmd.ExecuteNonQuery();
            int result = Convert.ToInt32(cmd.Parameters["@LOGIN"].Value);
            
            return  (result == 1) ? true : false;

        }

        public List<string> Alertas( int id)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_ALERT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Value = id;

            SqlDataReader reader = cmd.ExecuteReader();
            List<string> alertas = new List<string>();
            while (reader.Read())
            {
                alertas.Add(reader.GetString(0));
            }

            return alertas;
        }


        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}