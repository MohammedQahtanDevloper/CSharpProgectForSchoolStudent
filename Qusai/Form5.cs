using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qusai
{
    public partial class Form5 : Form
    {
        BL.loing_db log = new BL.loing_db();
        public Form5()
        {
            InitializeComponent();
           // this.dataGridView1.DataSource = log.show_loing();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
