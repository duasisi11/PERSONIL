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
    public partial class Riwayat_Pangkat : Form
    {
        
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        SqlConnection conn = Connection.connect();

        public Riwayat_Pangkat(string nip_nrp)
        {
            InitializeComponent();
            t_nip_nrp.Text = nip_nrp;
            t_nip_nrp.Enabled = false;
        }

        void tampil()
        {
            da = new SqlDataAdapter("Select id_riw_pkt as 'ID', nama_pangkat, tmt_pangkat, nomor_skep, tgl_skep, status_pangkat, nip_nrp from Riwayat_Pangkat where nip_nrp='" + t_nip_nrp.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void segarkan()
        {
            t_nama_pangkat.Text = "";
            dt_tmt_pangkat.Value = DateTime.Now;
            t_nomor_skep.Text = "";
            dt_tgl_skep.Value = DateTime.Now;
            t_status_pangkat.Text = "";
        }

        private void Riwayat_Pangkat_Load(object sender, EventArgs e)
        {
            try
            {
                String sql = "Select id_riw_pkt as 'ID', nama_pangkat, tmt_pangkat, nomor_skep, tgl_skep, status_pangkat, nip_nrp from Riwayat_Pangkat where nip_nrp='" + t_nip_nrp.Text + "'";
                da = new SqlDataAdapter(sql, conn); //agar data dapat diolah

                conn.Open();

                da.Fill(ds, "Riwayat_Pangkat");
                dt = ds.Tables["Riwayat_Pangkat"];
                bm = BindingContext[dt];
                bm.Position = 0;

                dv = new DataView(dt); //data yang akan ditampilkan
                dataGridView1.DataSource = dv;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                dataGridView1.DataSource = dt; //memasukkan data ke dataGridView1 

                t_nama_pangkat.DataBindings.Add("Text", dt, "nama_pangkat").ToString();
                dt_tmt_pangkat.DataBindings.Add("Text", dt, "tmt_pangkat").ToString();
                t_nomor_skep.DataBindings.Add("Text", dt, "nomor_skep").ToString();
                dt_tgl_skep.DataBindings.Add("Text", dt, "tgl_skep").ToString();
                t_status_pangkat.DataBindings.Add("Text", dt, "status_pangkat").ToString();
                t_nip_nrp.DataBindings.Add("Text", dt, "nip_nrp").ToString();
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
                perintahTambah.CommandText = "insert dbo.Riwayat_Pangkat values(@nama_pangkat, @tmt_pangkat, @nomor_skep, @tgl_skep, @status_pangkat, @nip_nrp)";

                perintahTambah.Parameters.AddWithValue("@nama_pangkat", t_nama_pangkat.Text);
                perintahTambah.Parameters.AddWithValue("@tmt_pangkat", dt_tmt_pangkat.Value);
                perintahTambah.Parameters.AddWithValue("@nomor_skep", t_nomor_skep.Text);
                perintahTambah.Parameters.AddWithValue("@tgl_skep", dt_tgl_skep.Value);
                perintahTambah.Parameters.AddWithValue("@status_pangkat", t_status_pangkat.Text);
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
                perintahUbah.CommandText = "Update dbo.Riwayat_Pangkat set nama_pangkat=@nama_pangkat, tmt_pangkat=@tmt_pangkat, nomor_skep=@nomor_skep, tgl_skep=@tgl_skep, status_pangkat=@status_pangkat, nip_nrp=@nip_nrp where id_riw_pkt = @id_riw_pkt";

                perintahUbah.Parameters.AddWithValue("@id_riw_pkt", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                perintahUbah.Parameters.AddWithValue("@nama_pangkat", t_nama_pangkat.Text);
                perintahUbah.Parameters.AddWithValue("@tmt_pangkat", dt_tmt_pangkat.Value);
                perintahUbah.Parameters.AddWithValue("@nomor_skep", t_nomor_skep.Text);
                perintahUbah.Parameters.AddWithValue("@tgl_skep", dt_tgl_skep.Value);
                perintahUbah.Parameters.AddWithValue("@status_pangkat", t_status_pangkat.Text);
                perintahUbah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);

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

        private void p_delete_Click(object sender, EventArgs e)
        {
            SqlCommand perintahHapus = new SqlCommand();
            SqlConnection conn = Connection.connect();

            perintahHapus.Connection = conn;
            perintahHapus.CommandType = CommandType.Text;
            perintahHapus.CommandText = "Delete Riwayat_Pangkat where id_riw_pkt = @id_riw_pkt";
            perintahHapus.Parameters.AddWithValue("@id_riw_pkt", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

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
            t_nama_pangkat.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            dt_tmt_pangkat.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            t_nomor_skep.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            dt_tgl_skep.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            t_status_pangkat.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
            t_nip_nrp.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString(); 
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
