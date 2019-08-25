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
    public partial class Manajemen_User : Form
    {
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        SqlConnection conn = Connection.connect();

        public Manajemen_User()
        {
            InitializeComponent();
        }

        void tampil()
        {
            da = new SqlDataAdapter("Select * from Manajemen_User", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void segarkan()
        {
            t_nip_nrp.Text = "";
            t_password.Text = "";
            cb_role.Text = "";
            dt_tgl_terdaftar.Value = DateTime.Now;
        }

        private void Manajement_User_Load(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();  
        }

        private void p_cari_Click(object sender, EventArgs e)
        {
            SqlCommand perintahCari = new SqlCommand();
            SqlConnection conn = Connection.connect();

            perintahCari.Connection = conn;
            perintahCari.CommandType = CommandType.Text;
            perintahCari.CommandText = "Select * from Manajement_User where nip_nrp = @nip_nrp";
            perintahCari.Parameters.Add("@nip_nrp", SqlDbType.Char);
            perintahCari.Parameters["@nip_nrp"].Value = t_nip_nrp.Text.Trim();

            conn.Open();
            dr = perintahCari.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Data Berhasil Ditemukan");
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                t_password.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(); // dr[1].ToString();
                cb_role.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();// dr[2].ToString();
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                t_nip_nrp.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();// dr[4].ToString();
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }
            conn.Close();
            this.segarkan();
            this.tampil();  
        }

        private void p_insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahTambah = new SqlCommand();
                SqlConnection conn = Connection.connect();
                
                perintahTambah.Connection = conn;
                perintahTambah.CommandType = CommandType.Text;
                perintahTambah.CommandText = "insert dbo.Manajement_User values(@password, @role, @tgl_terdaftar,@nip_nrp)";

                perintahTambah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);
                perintahTambah.Parameters.AddWithValue("@password", t_password.Text);
                perintahTambah.Parameters.AddWithValue("@role", cb_role.Text);
                perintahTambah.Parameters.AddWithValue("@tgl_terdaftar", dt_tgl_terdaftar.Value);
                
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

        private void p_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahUbah = new SqlCommand();
                SqlConnection conn = Connection.connect();

                perintahUbah.Connection = conn;
                perintahUbah.CommandType = CommandType.Text;
                perintahUbah.CommandText = "Update dbo.Manajement_User set password=@password, role=@role where id=@id";

                perintahUbah.Parameters.AddWithValue("@id", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                perintahUbah.Parameters.AddWithValue("@password", t_password.Text);
                perintahUbah.Parameters.AddWithValue("@role", cb_role.Text);
                

                conn.Open();
                int result = perintahUbah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil DiUbah");
                conn.Close();

                this.segarkan();
                this.tampil();  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void p_delete_Click(object sender, EventArgs e)
        {
            SqlCommand perintahHapus = new SqlCommand();
            SqlConnection conn = Connection.connect();

            perintahHapus.Connection = conn;
            perintahHapus.CommandType = CommandType.Text;
            perintahHapus.CommandText = "Delete Manajement_User where id=@id";
            perintahHapus.Parameters.AddWithValue("@id", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

            conn.Open();
            int Hasil = perintahHapus.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");

            conn.Close();

            this.tampil();
            this.segarkan();
        }

        private void p_refresh_Click(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            t_password.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            cb_role.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            t_nip_nrp.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
        }

        private void b_home_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
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

        private void b_rekap_data_Click(object sender, EventArgs e)
        {
            RekapDataPersonil rdp = new RekapDataPersonil();
            rdp.Show();
            this.Hide();
        }
    }
}
