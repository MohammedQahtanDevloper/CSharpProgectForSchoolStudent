﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Qusai.Form_school
{
    public partial class school : Form
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-1011GBP\QUSAIHASAN;Initial Catalog=Qusai;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        CurrencyManager cm;
        SqlCommandBuilder cmdb;
      
        public school()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select school_id as'معرف المدرسة',school_name as'اسم المدرسة',school_email as'البريد الاكتروني',school_location as'الموقع الاكتروني',school_phone as'رقم التلفون',school_note as'الملاحظة' from TB_school", SqlConnection);
            da.Fill(dt);
            dgList.DataSource = dt;
            textid.DataBindings.Add("text", dt, "معرف المدرسة");
            textname.DataBindings.Add("text", dt, "اسم المدرسة");
            textemail.DataBindings.Add("text", dt, "البريد الاكتروني");
            textloc.DataBindings.Add("text", dt, "الموقع الاكتروني");
            textphone.DataBindings.Add("text", dt, "رقم التلفون");
            textdes.DataBindings.Add("text", dt, "الملاحظة");
            bmb = this.BindingContext[dt];
            position.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }
        private void butFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            position.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void butPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            position.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            position.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            position.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void but_new_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            but_new.Enabled = false;
            but_add.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            textid.Text = id.ToString();
            textdes.Focus();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            but_add.Enabled = false;
            but_new.Enabled = true;
            position.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            position.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            position.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }
    }
}
