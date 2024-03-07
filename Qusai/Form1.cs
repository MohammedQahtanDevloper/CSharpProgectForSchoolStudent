using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Qusai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void But_login_CheckedChanged(object sender, EventArgs e)
        {
           // BL.loing_db login = new BL.loing_db();
           // DataTable dt = login.select_loing(textEdit_usur.Text, textEdit_pass.Text);
            //if(dt.Rows.Count > 0)
           // {
            //    MessageBox.Show("اهلان بك");
               
           // }
          //  else
           // {
              //  MessageBox.Show("الرجاء التاكد");
              
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
