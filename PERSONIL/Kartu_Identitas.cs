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
    public partial class Kartu_Identitas : Form
    {
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        SqlConnection conn = Connection.connect();
        
        public Kartu_Identitas(string nip_nrp)
        {
            InitializeComponent();
            t_nip_nrp.Text = nip_nrp;
            t_nip_nrp.Enabled = false;
        }

        void tampil()
        {
            da = new SqlDataAdapter("Select * from Kartu_Identitas where nip_nrp='" + t_nip_nrp.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void segarkan()
        {
            t_no_kta.Text = "";
            t_no_label_sec.Text = "";
            t_no_karpeg.Text = "";
            t_no_npwp.Text = "";
            t_no_ktp.Text = "";
            t_karis_karsu.Text = "";
            t_no_asabri.Text = "";
            t_no_kpi.Text = "";
            t_no_registrasi.Text = "";
            t_no_randis.Text = "";
        }

        private void Kartu_Identitas_Load(object sender, EventArgs e)
        {
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
                perintahTambah.CommandText = "insert dbo.Kartu_Identitas values(@no_kta, @no_label_sec, @no_karpeg_pns, @no_npwp, @no_ktp, @no_karis_karsu, @no_ktpa_asabri, @no_kartu_kpi, @no_registrasi, @no_randis, @nip_nrp)";

                perintahTambah.Parameters.AddWithValue("@no_kta", t_no_kta.Text);
                perintahTambah.Parameters.AddWithValue("@no_label_sec", t_no_label_sec.Text);
                perintahTambah.Parameters.AddWithValue("@no_karpeg_pns", t_no_karpeg.Text);
                perintahTambah.Parameters.AddWithValue("@no_npwp", t_no_npwp.Text);
                perintahTambah.Parameters.AddWithValue("@no_ktp", t_no_ktp.Text);
                perintahTambah.Parameters.AddWithValue("@no_karis_karsu", t_karis_karsu.Text);
                perintahTambah.Parameters.AddWithValue("@no_ktpa_asabri", t_no_asabri.Text);
                perintahTambah.Parameters.AddWithValue("@no_kartu_kpi", t_no_kpi.Text);
                perintahTambah.Parameters.AddWithValue("@no_registrasi", t_no_registrasi.Text);
                perintahTambah.Parameters.AddWithValue("@no_randis", t_no_randis.Text);
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
                perintahUbah.CommandText = "UPDATE Kartu_Identitas SET no_kta=@no_kta, no_label_sec=@no_label_sec, no_karpeg_pns=@no_karpeg_pns, no_npwp=@no_npwp, no_ktp=@no_ktp, no_karis_karsu=@no_karis_karsu, no_ktpa_asabri=@no_ktpa_asabri, no_kartu_kpi=@no_kartu_kpi, no_registrasi=@no_registrasi, no_randis=@no_randis WHERE nip_nrp=@nip_nrp";

                //Console.WriteLine(t_id_bahasa.Text);

                perintahUbah.Parameters.AddWithValue("@no_kta", t_no_kta.Text);
                perintahUbah.Parameters.AddWithValue("@no_label_sec", t_no_label_sec.Text);
                perintahUbah.Parameters.AddWithValue("@no_karpeg_pns", t_no_karpeg.Text);
                perintahUbah.Parameters.AddWithValue("@no_npwp", t_no_npwp.Text);
                perintahUbah.Parameters.AddWithValue("@no_ktp", t_no_ktp.Text);
                perintahUbah.Parameters.AddWithValue("@no_karis_karsu", t_karis_karsu.Text);
                perintahUbah.Parameters.AddWithValue("@no_ktpa_asabri", t_no_asabri.Text);
                perintahUbah.Parameters.AddWithValue("@no_kartu_kpi", t_no_kpi.Text);
                perintahUbah.Parameters.AddWithValue("@no_registrasi", t_no_registrasi.Text);
                perintahUbah.Parameters.AddWithValue("@no_randis", t_no_randis.Text);
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
            perintahHapus.CommandText = "Delete Kartu_Identitas where nip_nrp=@nip_nrp";
            perintahHapus.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);

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
            t_no_kta.Text = row.Cells[0].Value.ToString();
            t_no_label_sec.Text = row.Cells[1].Value.ToString();
            t_no_karpeg.Text = row.Cells[2].Value.ToString();
            t_no_npwp.Text = row.Cells[3].Value.ToString();
            t_no_ktp.Text = row.Cells[4].Value.ToString();
            t_karis_karsu.Text = row.Cells[5].Value.ToString();
            t_no_asabri.Text = row.Cells[6].Value.ToString();
            t_no_kpi.Text = row.Cells[7].Value.ToString();
            t_no_registrasi.Text = row.Cells[8].Value.ToString();
            t_no_randis.Text = row.Cells[9].Value.ToString();
            t_nip_nrp.Text = row.Cells[10].Value.ToString();
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

        private void b_r_pangkat_Click(object sender, EventArgs e)
        {
            Riwayat_Pangkat rpang = new Riwayat_Pangkat(t_nip_nrp.Text);
            rpang.Show();
            this.Hide();
        }

        private void b_r_jabatan_Click(object sender, EventArgs e)
        {
            Riwayat_Jabatan rj = new Riwayat_Jabatan(t_nip_nrp.Text);
            rj.Show();
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
