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
    class educational_level
    {
        public DataTable GET_ALL_EDUCATIONL_LEVEL()
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("GET_ALL_EDUCATIONL_LEVEL", null);
            DAl.cloes();
            return dt;
            //قصي
            //جلب نوع المستخدم
        }
        public DataTable GET_ALL_CLASS_ROOM()
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("GET_ALL_CLASS_ROOM", null);
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
        public DataTable GET_ALL_SCHOOL_YEAR()
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("GET_ALL_SCHOOL_YEAR", null);
            DAl.cloes();
            return dt;
            //قصي
            //جلب نوع الجنس
        }
        public DataTable SP_SHOW_STUDENT()
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("SP_SHOW_STUDENT", null);
            DAl.cloes();
            return dt;
            //قصي
            //عرض جدول الطلاب
        }
        public DataTable GET_ALL_GOVERNORATES()
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("GET_ALL_GOVERNORATES", null);
            DAl.cloes();
            return dt;
            //قصي
            //عرض جدول المحافظات
        }
        public DataTable GET_ALL_DISTRICTS()
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("GET_ALL_DISTRICTS", null);
            DAl.cloes();
            return dt;
            //قصي
            //عرض جدول المدريات
        }
        public DataTable GET_ALL_UZAAL()
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("GET_ALL_UZAAL", null);
            DAl.cloes();
            return dt;
            //قصي TB_uzaal
            //عرض جدول العزل
        }
        public DataTable VERIFY_GOVERNORATES_ID(string ID)
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

    }
}
