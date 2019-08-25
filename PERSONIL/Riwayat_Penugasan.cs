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
    public partial class Riwayat_Penugasan : Form
    {

        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        SqlConnection conn = Connection.connect();

        public Riwayat_Penugasan(string nip_nrp)
        {
            InitializeComponent();
            t_nip_nrp.Text = nip_nrp;
            t_nip_nrp.Enabled = false;
        }

        void tampil()
        {
            da = new SqlDataAdapter("Select id_riw_penugasan as 'ID', nama_penugasan, kota, negara, tahun, ket, nip_nrp from Riwayat_Penugasan where nip_nrp='" + t_nip_nrp.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void segarkan()
        {
            t_nama_penugasan.Text = "";
            t_kota.Text = "";
            t_negara.Text = "";
            t_tahun.Text = "";
            t_ket.Text = "";
        }

        private void Riwayat_Penugasan_Load(object sender, EventArgs e)
        {
            try
            {
                String sql = "Select id_riw_penugasan as 'ID', nama_penugasan, kota, negara, tahun, ket, nip_nrp from Riwayat_Penugasan where nip_nrp='" + t_nip_nrp.Text + "'";
                da = new SqlDataAdapter(sql, conn); //agar data dapat diolah

                conn.Open();

                da.Fill(ds, "Riwayat_Penugasan");
                dt = ds.Tables["Riwayat_Penugasan"];
                bm = BindingContext[dt];
                bm.Position = 0;

                dv = new DataView(dt); //data yang akan ditampilkan
                dataGridView1.DataSource = dv;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                dataGridView1.DataSource = dt; //memasukkan data ke dataGridView1 

                t_nama_penugasan.DataBindings.Add("Text", dt, "nama_penugasan").ToString();
                t_kota.DataBindings.Add("Text", dt, "kota").ToString();
                t_negara.DataBindings.Add("Text", dt, "negara").ToString();
                t_tahun.DataBindings.Add("Text", dt, "tahun").ToString();
                t_ket.DataBindings.Add("Text", dt, "ket").ToString();
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
                perintahTambah.CommandText = "insert dbo.Riwayat_Penugasan values(@nama_penugasan, @kota, @negara, @tahun, @ket, @nip_nrp)";

                perintahTambah.Parameters.AddWithValue("@nama_penugasan", t_nama_penugasan.Text);
                perintahTambah.Parameters.AddWithValue("@kota", t_kota.Text);
                perintahTambah.Parameters.AddWithValue("@negara", t_negara.Text);
                perintahTambah.Parameters.AddWithValue("@tahun", t_tahun.Text);
                perintahTambah.Parameters.AddWithValue("@ket", t_ket.Text);
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
                perintahUbah.CommandText = "Update dbo.Riwayat_Penugasan set nama_penugasan=@nama_penugasan, kota=@kota, negara=@negara, tahun = @tahun, ket = @ket where id_riw_penugasan = @id_riw_penugasan";

                perintahUbah.Parameters.AddWithValue("@id_riw_penugasan", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                perintahUbah.Parameters.AddWithValue("@nama_penugasan", t_nama_penugasan.Text);
                perintahUbah.Parameters.AddWithValue("@kota", t_kota.Text);
                perintahUbah.Parameters.AddWithValue("@negara", t_negara.Text);
                perintahUbah.Parameters.AddWithValue("@tahun", t_tahun.Text);
                perintahUbah.Parameters.AddWithValue("@ket", t_ket.Text);
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

        private void p_refresh_Click(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t_nama_penugasan.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            t_kota.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString(); 
            t_negara.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString(); 
            t_tahun.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString(); 
            t_ket.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString(); ;
            t_nip_nrp.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString(); 
        }

        private void p_delete_Click(object sender, EventArgs e)
        {
            SqlCommand perintahHapus = new SqlCommand();
            SqlConnection conn = Connection.connect();

            perintahHapus.Connection = conn;
            perintahHapus.CommandType = CommandType.Text;
            perintahHapus.CommandText = "Delete Riwayat_Penugasan where id_riw_penugasan = @id_riw_penugasan";
            perintahHapus.Parameters.AddWithValue("@id_riw_penugasan", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

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
