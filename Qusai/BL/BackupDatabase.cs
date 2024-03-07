using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Qusai.BL
{
    class BackupDatabase
    {
        public void BD(string NAME, string PATH)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            param[0].Value = NAME;
            param[1] = new SqlParameter("@path", SqlDbType.NVarChar, 255);
            param[1].Value = PATH;
            DAl.ExecuteCommand("SP_DB_B", param);
            DAl.cloes();
        }

    }
}
