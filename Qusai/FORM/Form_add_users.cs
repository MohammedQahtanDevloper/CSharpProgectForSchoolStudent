using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Qusai
{
    public partial class Form_add_users : Form
    {
        public string state = "add";
        BL.users us = new BL.users();
        public Form_add_users()
        {
            InitializeComponent();
            com_type.DataSource = us.GET_ALL_USER_TYPE();
            com_type.DisplayMember = "type_name";
            com_type.ValueMember = "type_id";
            com_gnder.DataSource = us.GET_ALL_GENDER();
            com_gnder.DisplayMember = "gender_name";
            com_gnder.ValueMember = "gender_id";
        }

        private void but_sle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG;*.PNG;*.GIF;*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void but_re_Click(object sender, EventArgs e)
        {
            if (state == "add")
            { 
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            byte[] byteimage = ms.ToArray();
                // log.add_loing(Convert.ToInt32(com_type.SelectedValue), text_name.Text, text_pass.Text, text_emal.Text, byteimage);
                us.SP_ADD_LOGING(text_id.Text, text_name.Text, text_pass.Text, byteimage, text_emal.Text, Convert.ToInt32(com_type.SelectedValue), Convert.ToInt32(com_gnder.SelectedValue));
            MessageBox.Show("تمت الإضافة بنجاح ", "عمليةالإضافة",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                // log.add_loing(Convert.ToInt32(com_type.SelectedValue), text_name.Text, text_pass.Text, text_emal.Text, byteimage);
                us.SP_UPDATE_LOGING(text_id.Text, text_name.Text, text_pass.Text, byteimage, text_emal.Text, Convert.ToInt32(com_type.SelectedValue), Convert.ToInt32(com_gnder.SelectedValue));
                MessageBox.Show("تمت التعديل بنجاح ", "عمليةالتعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FORM.login.getMainForm.dataGridView1.DataSource = us.SP_SHOW_LOGING();

        }
        private void text_id_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            { 
            DataTable dt = new DataTable();
            dt = us.VERIF_YUSER_ID(text_id.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("هذا المعرف موجود مسبقا ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_id.Focus();
                text_id.SelectionStart = 0;
                text_id.SelectionLength = text_id.TextLength;
            }
            }
        }
        private void Form_add_users_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
