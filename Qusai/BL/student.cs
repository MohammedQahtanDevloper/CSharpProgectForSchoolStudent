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
    class student
    {
        public void SP_ADD_STUDENT(string id,string name_first,string name_second,string name_third,
            string name_surname,string student_age, byte[] student_img,string student_add,string student_birth,
            string student_emal,int gender_id,int governorate_id,int district_id, int uzaal_id)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            SqlParameter[] param = new SqlParameter[13];
            param[0] = new SqlParameter("@id",SqlDbType.VarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@student_name_first",SqlDbType.VarChar,10);
            param[1].Value = name_first;
            param[2] = new SqlParameter("@student_name_second",SqlDbType.VarChar, 10);
            param[2].Value = name_second;
            param[3] = new SqlParameter("@student_name_third",SqlDbType.VarChar, 20);
            param[3].Value = name_third;
            param[4] = new SqlParameter("@student_name_surname",SqlDbType.VarChar, 10);
            param[4].Value = name_surname;
            param[5] = new SqlParameter("@student_age",SqlDbType.VarChar, 2);
            param[5].Value = student_age;
            param[6] = new SqlParameter("@student_img",SqlDbType.Image);
            param[6].Value = student_img;
            param[7] = new SqlParameter("@student_add",SqlDbType.DateTime);
            param[7].Value = student_add;
            param[8] = new SqlParameter("@student_birth",SqlDbType.DateTime);
            param[8].Value = student_birth;
            param[9] = new SqlParameter("@student_emal",SqlDbType.VarChar, 50);
            param[9].Value = student_emal;
            param[10] = new SqlParameter("@gender_id",SqlDbType.Int);
            param[10].Value = gender_id;
            param[11] = new SqlParameter("@governorate_id",SqlDbType.Int);
            param[11].Value = governorate_id;
            param[12] = new SqlParameter("@district_id",SqlDbType.Int);
            param[12].Value = district_id;
            param[13] = new SqlParameter("@uzaal_id",SqlDbType.Int);
            param[13].Value = uzaal_id;
            DAl.ExecuteCommand("SP_ADD_STUDENT", param);
            DAl.cloes();
        }
        public void SP_DELETE_STUDENT(string ID)
        {
            DAL.DataAccessLayer DAl = new DAL.DataAccessLayer();
            DAl.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DAl.ExecuteCommand("SP_DELETE_STUDENT", param);
            DAl.cloes();
            //قصي
            //حذف المستخدم
        }
    }
}
