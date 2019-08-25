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
    public partial class Kategori_Pendidikan : Form
    {
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        SqlConnection conn = Connection.connect();

        public Kategori_Pendidikan()
        {
            InitializeComponent();
        }

        void tampil()
        {
            da = new SqlDataAdapter("Select id_kategori as 'ID', nama_kategori as 'Kategori Pendidikan' from kategori_pendidikan", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        void segarkan()
        {
            t_nama_kategori.Text = "";
        }

        private void Kategori_Pendidikan_Load(object sender, EventArgs e)
        {
            try
            {
                this.tampil();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void p_tambah_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahTambah = new SqlCommand();
                SqlConnection conn = Connection.connect();

                perintahTambah.Connection = conn;
                perintahTambah.CommandType = CommandType.Text;
                perintahTambah.CommandText = "insert dbo.kategori_pendidikan values(@nama_kategori)";

                perintahTambah.Parameters.AddWithValue("@nama_kategori", t_nama_kategori.Text);

                conn.Open();
                int result = perintahTambah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                conn.Close();

                this.segarkan();
                this.tampil();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void p_ubah_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahUbah = new SqlCommand();
                SqlConnection conn = Connection.connect();

                perintahUbah.Connection = conn;
                perintahUbah.CommandType = CommandType.Text;
                perintahUbah.CommandText = "Update dbo.kategori_pendidikan set nama_kategori=@nama_kategori where id_kategori = @id_kategori";

                perintahUbah.Parameters.AddWithValue("@id_kategori", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                perintahUbah.Parameters.AddWithValue("@nama_kategori", t_nama_kategori.Text);
                
                conn.Open();
                int hasil = perintahUbah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diubah");
                conn.Close();

                this.segarkan();
                this.tampil();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t_nama_kategori.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(); 
        }

        private void p_refresh_Click(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();
        }

        private void p_hapus_Click(object sender, EventArgs e)
        {
            SqlCommand perintahHapus = new SqlCommand();
            SqlConnection conn = Connection.connect();

            perintahHapus.Connection = conn;
            perintahHapus.CommandType = CommandType.Text;
            perintahHapus.CommandText = "Delete kategori_pendidikan where id_kategori = @id_kategori";
            perintahHapus.Parameters.AddWithValue("@id_kategori", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

            conn.Open();
            int Hasil = perintahHapus.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");
            conn.Close();

            this.segarkan();
            this.tampil();
        }

        private void b_home_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            this.Hide();
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
    }
}
