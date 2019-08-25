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
    public partial class Riwayat_Jabatan : Form
    {
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        SqlConnection conn = Connection.connect();

        public Riwayat_Jabatan(string nip_nrp)
        {
            InitializeComponent();
            t_nip_nrp.Text = nip_nrp;
            t_nip_nrp.Enabled = false;
        }

        void tampil()
        {
            da = new SqlDataAdapter("Select * from Riwayat_Jabatan where nip_nrp='" + t_nip_nrp.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void segarkan()
        {
            t_kode_jabatan.Text = "";
            t_nama_jabatan.Text = "";
            dt_tmt_Jabatan.Value = DateTime.Now;
            t_nomor_skep.Text = "";
            dt_tgl_skep.Value = DateTime.Now;
            t_status_jab.Text = "";
        }

        private void Riwayat_Jabatan_Load(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();
            // TODO: This line of code loads data into the 'dS_Data_Personil.Riwayat_Jabatan' table. You can move, or remove it, as needed.
            this.riwayat_JabatanTableAdapter.Fill(this.dS_Data_Personil.Riwayat_Jabatan);
        }

        
        private void p_insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahTambah = new SqlCommand();
                SqlConnection conn = Connection.connect();

                perintahTambah.Connection = conn;
                perintahTambah.CommandType = CommandType.Text;
                perintahTambah.CommandText = "insert dbo.Riwayat_Jabatan values(@kode_jabatan, @nama_jabatan, @tmt_jabatan, @nomor_skep, @tgl_skep, @status_jabatan, @nip_nrp)";

                perintahTambah.Parameters.AddWithValue("@kode_jabatan", t_kode_jabatan.Text);
                perintahTambah.Parameters.AddWithValue("@nama_jabatan", t_nama_jabatan.Text);
                perintahTambah.Parameters.AddWithValue("@tmt_jabatan", dt_tmt_Jabatan.Value);
                perintahTambah.Parameters.AddWithValue("@nomor_skep", t_nomor_skep.Text);
                perintahTambah.Parameters.AddWithValue("@tgl_skep", dt_tgl_skep.Value);
                perintahTambah.Parameters.AddWithValue("@status_jabatan", t_status_jab.Text);
                perintahTambah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);

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
                perintahUbah.CommandText = "UPDATE Riwayat_Jabatan SET kode_jabatan=@kode_jabatan, nama_jabatan=@nama_jabatan, tmt_jabatan=@tmt_jabatan, nomor_skep=@nomor_skep, tgl_skep=@tgl_skep, status_jabatan=@status_jabatan, nip_nrp=@nip_nrp WHERE id_riw_jab=@id_riw_jab";

                //Console.WriteLine(t_id_bahasa.Text);

                perintahUbah.Parameters.AddWithValue("@id_riw_jab", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                perintahUbah.Parameters.AddWithValue("@kode_jabatan", t_kode_jabatan.Text);
                perintahUbah.Parameters.AddWithValue("@nama_jabatan", t_nama_jabatan.Text);
                perintahUbah.Parameters.AddWithValue("@tmt_jabatan", dt_tmt_Jabatan.Value);
                perintahUbah.Parameters.AddWithValue("@nomor_skep", t_nomor_skep.Text);
                perintahUbah.Parameters.AddWithValue("@tgl_skep", dt_tgl_skep.Value);
                perintahUbah.Parameters.AddWithValue("@status_jabatan", t_status_jab.Text);
                perintahUbah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);

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
            perintahHapus.CommandText = "Delete Riwayat_Jabatan where id_riw_jab=@id_riw_jab";
            perintahHapus.Parameters.AddWithValue("@id_riw_jab", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

            conn.Open();
            int Hasil = perintahHapus.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");

            conn.Close();

            this.segarkan();
            this.tampil();
        }

        private void p_refresh_Click(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            t_kode_jabatan.Text = row.Cells[1].Value.ToString();
            t_nama_jabatan.Text = row.Cells[2].Value.ToString();
            dt_tmt_Jabatan.Text = row.Cells[3].Value.ToString();
            t_nomor_skep.Text = row.Cells[4].Value.ToString();
            dt_tgl_skep.Text = row.Cells[5].Value.ToString();
            t_status_jab.Text = row.Cells[6].Value.ToString();
            t_nip_nrp.Text = row.Cells[7].Value.ToString();
        }

        private void b_home_Click(object sender, EventArgs e)
        {
            Form1 Frm = new Form1(t_nip_nrp.Text);
            Frm.Show();
            this.Hide();
        }

        private void b_data_pokok_Click(object sender, EventArgs e)
        {
            DataPokok dtPokok = new DataPokok(t_nip_nrp.Text);
            dtPokok.Show();
            this.Hide();
        }

        private void b_kartu_identitas_Click(object sender, EventArgs e)
        {
            Kartu_Identitas krident = new Kartu_Identitas(t_nip_nrp.Text);
            krident.Show();
            this.Hide();
        }

        private void b_r_pangkat_Click(object sender, EventArgs e)
        {
            Riwayat_Pangkat rpang = new Riwayat_Pangkat(t_nip_nrp.Text);
            rpang.Show();
            this.Hide();
        }

        private void b_r_pendidikan_Click(object sender, EventArgs e)
        {
            Riwayat_Pendidikan rp = new Riwayat_Pendidikan(t_nip_nrp.Text);
            rp.Show();
            this.Hide();
        }

        private void b_r_penugasan_Click(object sender, EventArgs e)
        {
            Riwayat_Penugasan rpen = new Riwayat_Penugasan(t_nip_nrp.Text);
            rpen.Show();
            this.Hide();
        }

        private void b_r_tanda_jasa_Click(object sender, EventArgs e)
        {
            Riwayat_Tanda_Jasa rtj = new Riwayat_Tanda_Jasa(t_nip_nrp.Text);
            rtj.Show();
            this.Hide();
        }

        private void b_bahasa_Click(object sender, EventArgs e)
        {
            Bahasa b = new Bahasa(t_nip_nrp.Text);
            b.Show();
            this.Hide();
        }

        private void b_r_keluarga_Click(object sender, EventArgs e)
        {
            Riwayat_Keluarga rk = new Riwayat_Keluarga(t_nip_nrp.Text);
            rk.Show();
            this.Hide();
        }

        private void b_dokumen_Click(object sender, EventArgs e)
        {
            Dokumen d = new Dokumen(t_nip_nrp.Text);
            d.Show();
            this.Hide();
        }

        private void b_ubah_password_Click(object sender, EventArgs e)
        {
            Ubah_Password up = new Ubah_Password(t_nip_nrp.Text);
            up.Show();
            this.Hide();
        }

    }
}
