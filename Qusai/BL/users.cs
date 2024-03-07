using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Qusai.BL
{
    class users
    {
        public DataTable GET_ALL_USER_TYPE()
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("GET_ALL_USER_TYPE", null);
            DAl.cloes();
            return dt;
            //قصي
            //جلب نوع المستخدم
        }
        public DataTable GET_ALL_GENDER()
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("GET_ALL_GENDER", null);
            DAl.cloes();
            return dt;
            //قصي
            //جلب نوع الجنس
        }
        public DataTable VERIF_YUSER_ID(string ID)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            dt = DAl.SelectData("VERIF_YUSER_ID", param);
            DAl.cloes();
            return dt;
            //قصي
            //معرف المستخدم بحيث عدم التكرر نفس المعرف
        }
        public DataTable GET_IMAGE_USER(string ID)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID ", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DataTable dt = new DataTable();
            dt = DAl.SelectData("GET_IMAGE_USER", param);
            DAl.cloes();
            return dt;
            //قصي
            //جلب الصورة من قاعدة البيانات
        }
        public void SP_ADD_LOGING(string user_id, string user_name, string user_pass, byte[] user_image, string user_date, int type_id, int gender_id)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = user_id;
            param[1] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[1].Value = user_name;
            param[2] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
            param[2].Value = user_pass;
            param[3] = new SqlParameter("@user_image", SqlDbType.Image);
            param[3].Value = user_image;
            param[4] = new SqlParameter("@user_date", SqlDbType.DateTime);
            param[4].Value = user_date;
            param[5] = new SqlParameter("@type_id", SqlDbType.Int);
            param[5].Value = type_id;
            param[6] = new SqlParameter("@gender_id", SqlDbType.Int);
            param[6].Value = gender_id;
            DAl.ExecuteCommand("SP_ADD_LOGING", param);
            DAl.cloes();
            //قصي
            //اضافة المستخدمين

        }
        public void SP_UPDATE_LOGING(string user_id, string user_name, string user_pass, byte[] user_image, string user_date, int type_id, int gender_id)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = user_id;
            param[1] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[1].Value = user_name;
            param[2] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
            param[2].Value = user_pass;
            param[3] = new SqlParameter("@user_image", SqlDbType.Image);
            param[3].Value = user_image;
            param[4] = new SqlParameter("@user_date", SqlDbType.DateTime);
            param[4].Value = user_date;
            param[5] = new SqlParameter("@type_id", SqlDbType.Int);
            param[5].Value = type_id;
            param[6] = new SqlParameter("@gender_id", SqlDbType.Int);
            param[6].Value = gender_id;
            DAl.ExecuteCommand("SP_UPDATE_LOGING", param);
            DAl.cloes();
            //قصي
            //التعديل على المستخدمين
        }
        public void SP_DELETE_LOGING(string ID)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DAl.ExecuteCommand("SP_DELETE_LOGING", param);
            DAl.cloes();
            //قصي
            //حذف المستخدم
        }
        public DataTable SP_SHOW_LOGING()
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("SP_SHOW_LOGING", null);
            DAl.cloes();
            return dt;
            //قصي
            //عرض جدول المستخدمين
        }
        public DataTable SP_RESEARCH_LOGING(string ID)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID ", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DataTable dt = new DataTable();
            dt = DAl.SelectData("SP_RESEARCH_LOGING", param);
            DAl.cloes();
            return dt;
        }

    }
}
