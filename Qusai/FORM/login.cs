using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
//This is the main form for progect

namespace Qusai.FORM
{
    public partial class login : Form
    {

        private static login frm;
        static void frm_formClosed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }
        public static login getMainForm
        {
            get
            {
                if (frm==null)
                {
                    frm = new login();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
            }
        }
     //   BL.loing_db log = new BL.loing_db();
        BL.users user = new BL.users();
        private object classroom;

        public login()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = user.SP_SHOW_LOGING();
        }

        private void text_re_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = user.SP_RESEARCH_LOGING(text_re.Text);
            this.dataGridView1.DataSource = Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Form3 f1 = new Form3();
            //f1.Show();
        }

        private void but_up_Click_1(object sender, EventArgs e)
        {
            getMainForm.dataGridView1.DataSource = user.SP_SHOW_LOGING();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            Form_add_users f1 = new Form_add_users();
            f1.Show();
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف المستخدم المحدد ؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                user.SP_DELETE_LOGING(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاج", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getMainForm.dataGridView1.DataSource = user.SP_SHOW_LOGING();
            }
            else
            {
                MessageBox.Show("تم إلغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void but_uptate_Click(object sender, EventArgs e)
        {
            Form_add_users frm = new Form_add_users();
            frm.text_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.text_name.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.text_pass.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.text_emal.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.com_type.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.com_gnder.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تحديث بيانات المستخدمين:" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.but_re.Text = "تحديث";
            frm.state = "update";
            frm.text_id.ReadOnly = true;
            byte[] image=(byte[])user.GET_IMAGE_USER(dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms= new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FROM_PREVIEW frm = new FROM_PREVIEW();
            byte[] image = (byte[])user.GET_IMAGE_USER(dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report.CrystalReport4 my =new Report.CrystalReport4();
            my.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Report.Report_user myform = new Report.Report_user();
            myform.crystalReportViewer1.ReportSource = my;
            myform.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report.Report_All_Users myReport = new Report.Report_All_Users();
            Report.Report_user myform = new Report.Report_user();
            myform.crystalReportViewer1.ReportSource = myReport;
            myform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report.Report_All_Users myReport = new Report.Report_All_Users();
            //  Create Export Options
            ExportOptions Expor = new ExportOptions();

            //  Create Object For dfOption
            DiskFileDestinationOptions dfOptions = new DiskFileDestinationOptions();

            ExcelFormatOptions excelformat =new ExcelFormatOptions();
            //set the pathdf Option
            dfOptions.DiskFileName = @"D:\Memory card\سالم المسعودي2021.xls";
            Expor = myReport.ExportOptions;
            Expor.ExportDestinationType = ExportDestinationType.DiskFile;
            Expor.ExportFormatType = ExportFormatType.Excel;
            Expor.ExportFormatOptions = excelformat;
            Expor.ExportDestinationOptions = dfOptions;
            myReport.Export();
            MessageBox.Show("hggg");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }
    }
}
