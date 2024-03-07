using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace Qusai.BL
{
    class loing_db
    {

        public DataTable select_loing(string Name,string PWD)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[0].Value = Name;
            param[1] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
            param[1].Value = PWD;
            DAl.open();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("SP_LOGING", param);
            DAl.cloes();
            return dt;
            //MohammedQahtan
        }
        public DataTable get_all_loing(string Name, string PWD)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("SP_LOGING", null);
            DAl.cloes();
            return dt;
        }
        
 
       
    }
}
