using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Qusai.DAL
{
    class DataAccessLayer
    {
        SqlConnection SqlConnection;
        public DataAccessLayer()
        {
            SqlConnection = new SqlConnection(@"Data Source=MOHAMMEDQAHTAN;Initial Catalog=Qusai;Integrated Security=True");
        }
        public void open()
        {
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
        }
        public void cloes()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public DataTable SelectData(String stored_procedure, SqlParameter[] Param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if (Param != null)
            {
                for (int i = 0; i < Param.Length; i++)
                {
                    sqlcmd.Parameters.Add(Param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ExecuteCommand(String stored_procedure, SqlParameter[] Param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if (Param != null)
            {
                sqlcmd.Parameters.AddRange(Param);
            }
         sqlcmd.ExecuteNonQuery();
        }


    }
}
