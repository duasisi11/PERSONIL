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
using System.Configuration;

namespace PERSONIL
{
    public partial class AdminForm : Form
    {
        SqlDataReader dr;
        public AdminForm()
        {
            InitializeComponent();

        }

        private void b_manajement_user_Click(object sender, EventArgs e)
        {
            Manajemen_User mu = new Manajemen_User();
            mu.Show();
            this.Hide();
        }

        private void b_rekap_data_Click(object sender, EventArgs e)
        {
            RekapDataPersonil rdp = new RekapDataPersonil();
            rdp.Show();
            this.Hide();
        }

        private void b_satker_Click(object sender, EventArgs e)
        {
            Satuan_Kerja sk = new Satuan_Kerja();
            sk.Show();
            this.Hide();
        }

        private void b_kategori_pend_Click(object sender, EventArgs e)
        {
            Kategori_Pendidikan kpen = new Kategori_Pendidikan();
            kpen.Show();
            this.Hide();
        }

        

    }
}
