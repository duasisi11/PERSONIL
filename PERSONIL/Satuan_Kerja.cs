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
    public partial class Satuan_Kerja : Form
    {
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        SqlConnection conn = Connection.connect();

        public Satuan_Kerja()
        {
            InitializeComponent();
        }

        void tampil()
        {
            da = new SqlDataAdapter("Select * from Satker", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void segarkan()
        {
            t_satuan.Text = "";
            t_alamat_sat.Text = "";
            t_no_telp.Text = "";
        }

        private void Satuan_Kerja_Load(object sender, EventArgs e)
        {
            try
            {
                this.segarkan();
                this.tampil();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void p_insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahTambah = new SqlCommand();
                SqlConnection conn = Connection.connect();

                perintahTambah.Connection = conn;
                perintahTambah.CommandType = CommandType.Text;
                perintahTambah.CommandText = "insert dbo.Satker values(@nama_satker, @alamat, @telp)";

                perintahTambah.Parameters.AddWithValue("@nama_satker", t_satuan.Text);
                perintahTambah.Parameters.AddWithValue("@alamat", t_alamat_sat.Text);
                perintahTambah.Parameters.AddWithValue("@telp", t_no_telp.Text);

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

        private void p_refresh_Click(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t_satuan.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            t_alamat_sat.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            t_no_telp.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }

        private void p_delete_Click(object sender, EventArgs e)
        {
            SqlCommand perintahHapus = new SqlCommand();
            SqlConnection conn = Connection.connect();

            perintahHapus.Connection = conn;
            perintahHapus.CommandType = CommandType.Text;
            perintahHapus.CommandText = "Delete Satker where nama_satker=@nama_satker";
            perintahHapus.Parameters.AddWithValue("@nama_satker", t_satuan.Text.Trim());

            conn.Open();
            int Hasil = perintahHapus.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");

            conn.Close();

            this.tampil();
            this.segarkan();
        }

        
        private void p_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahUbah = new SqlCommand();
                SqlConnection conn = Connection.connect();

                perintahUbah.Connection = conn;
                perintahUbah.CommandType = CommandType.Text;
                perintahUbah.CommandText = "Update dbo.Satker set nama_satker=@nama_satker, alamat=@alamat, telp=@telp where id_satker=@id_satker";

                perintahUbah.Parameters.AddWithValue("@id_satker", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                perintahUbah.Parameters.AddWithValue("@nama_satker", t_satuan.Text);
                perintahUbah.Parameters.AddWithValue("@alamat", t_alamat_sat.Text);
                perintahUbah.Parameters.AddWithValue("@telp", t_no_telp.Text);

                conn.Open();
                int result = perintahUbah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil DiUbah");
                conn.Close();

                this.tampil();
                this.segarkan();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void b_kategori_pend_Click(object sender, EventArgs e)
        {
            Kategori_Pendidikan kpen = new Kategori_Pendidikan();
            kpen.Show();
            this.Hide();
        } 
    }
}
