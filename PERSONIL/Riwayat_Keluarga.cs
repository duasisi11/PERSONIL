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
    public partial class Riwayat_Keluarga : Form
    {
        
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        SqlConnection conn = Connection.connect();

        public Riwayat_Keluarga(string nip_nrp)
        {
            InitializeComponent();
            t_nip_nrp.Text = nip_nrp;
            t_nip_nrp.Enabled = false;
            //rb_laki.Checked = true;
        }

        void tampil()
        {
            da = new SqlDataAdapter("Select * from Riwayat_Keluarga where nip_nrp='" + t_nip_nrp.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void segarkan()
        {
            //t_nip_nrp.Text = "";
            t_nama_keluarga.Text = "";
            rb_laki.Checked = true;
            dt_tgl_lahir.Value = DateTime.Now;
            t_hub_klg.Text = "";
        }
            
        private void Riwayat_Keluarga_Load(object sender, EventArgs e)
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
                perintahTambah.CommandText = "insert dbo.Riwayat_Keluarga values(@nama_klg, @jns_kel, @tgl_lhr, @hub_klg, @nip_nrp)";

                perintahTambah.Parameters.AddWithValue("@nama_klg", t_nama_keluarga.Text);
                if (rb_laki.Checked == true)
                {
                    perintahTambah.Parameters.AddWithValue("@jns_kel", "Laki-laki");
                }
                else if (rb_perempuan.Checked == true)
                {
                    perintahTambah.Parameters.AddWithValue("@jns_kel", "Perempuan");
                }

                perintahTambah.Parameters.AddWithValue("@tgl_lhr", dt_tgl_lahir.Value);
                perintahTambah.Parameters.AddWithValue("@hub_klg", t_hub_klg.Text);
                perintahTambah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);
                MessageBox.Show("Apakah Anda Yakin Ingin Memasukkan Data...?");
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
                perintahUbah.CommandText = "UPDATE dbo.Riwayat_Keluarga SET nama_klg=@nama_klg, jns_kel=@jns_kel, tgl_lhr=tgl_lhr, hub_klg=@hub_klg, nip_nrp=@nip_nrp WHERE id_riw_klg=@id_riw_klg";

                perintahUbah.Parameters.AddWithValue("@id_riw_klg", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                perintahUbah.Parameters.AddWithValue("@nama_klg", t_nama_keluarga.Text);
                if (rb_laki.Checked == true)
                {
                    perintahUbah.Parameters.AddWithValue("@jns_kel", "Laki-laki");
                }
                else if (rb_perempuan.Checked == true)
                {
                    perintahUbah.Parameters.AddWithValue("@jns_kel", "Perempuan");
                }

                perintahUbah.Parameters.AddWithValue("@tgl_lhr", dt_tgl_lahir.Value);
                perintahUbah.Parameters.AddWithValue("@hub_klg", t_hub_klg.Text);
                perintahUbah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);
                MessageBox.Show("Apakah Anda Yakin Ingin Mengubah Data...?");
                conn.Open();
                int result = perintahUbah.ExecuteNonQuery();
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
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            t_nama_keluarga.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Laki-laki")
            {
                rb_laki.Checked = true;
            }
            else if (row.Cells[2].Value.ToString() == "Perempuan")
            {
                rb_perempuan.Checked = true;
            }
            dt_tgl_lahir.Text = row.Cells[3].Value.ToString();
            t_hub_klg.Text = row.Cells[4].Value.ToString();
            t_nip_nrp.Text = row.Cells[5].Value.ToString();
        }

        private void p_refresh_Click(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();
        }

        private void p_delete_Click(object sender, EventArgs e)
        {
            SqlCommand perintahHapus = new SqlCommand();
            SqlConnection conn = Connection.connect();

            perintahHapus.Connection = conn;
            perintahHapus.CommandType = CommandType.Text;
            perintahHapus.CommandText = "Delete Riwayat_Keluarga where id_riw_klg = @id_riw_klg";
            perintahHapus.Parameters.AddWithValue("@id_riw_klg", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            MessageBox.Show("Apakah Anda Yakin Ingin Munghapus Data...?");
            conn.Open();
            int Hasil = perintahHapus.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");
            conn.Close();

            this.segarkan();
            this.tampil();
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
