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

namespace Qusai.From_sut
{
    public partial class Form1 : Form
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-1011GBP\QUSAIHASAN;Initial Catalog=Qusai;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        CurrencyManager cm;
        SqlCommandBuilder cmdb;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void butFirst_Click(object sender, EventArgs e)
        {
        }

        private void butLast_Click(object sender, EventArgs e)
        {
          
        }

        private void butPrevious_Click(object sender, EventArgs e)
        {
           
        }

        private void butNext_Click(object sender, EventArgs e)
        {
           
        }

        private void but_new_Click(object sender, EventArgs e)
        {
           
        }

        private void but_add_Click(object sender, EventArgs e)
        {
           
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
           
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
           
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }
    }
}
