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

namespace PERSONIL
{
    public partial class Riwayat_Pendidikan : Form
    {
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        SqlConnection conn = Connection.connect();

        public Riwayat_Pendidikan(string nip_nrp)
        {
            InitializeComponent();
            t_nip_nrp.Text = nip_nrp;
            t_nip_nrp.Enabled = false;
        }

        void tampil()
        {
            da = new SqlDataAdapter("Select r.id_riw_pend AS 'ID', r.nip_nrp, r.nama_pendidikan, r.tahun, r.keterangan ,k.nama_kategori from Riwayat_Pendidikan r, Kategori_Pendidikan k where r.id_kategori=k.id_kategori and nip_nrp='" + t_nip_nrp.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void segarkan()
        {
            t_nama_pend.Text = "";
            t_tahun.Text = "";
            t_ket.Text = "";
            cb_kategori_pend.Text = "";
        }

        private void Riwayat_Pendidikan_Load(object sender, EventArgs e)
        {
           
            try
            {
                String sql = "Select r.id_riw_pend AS 'ID', r.nip_nrp, r.nama_pendidikan, r.tahun, r.keterangan ,k.nama_kategori from Riwayat_Pendidikan r, Kategori_Pendidikan k where r.id_kategori=k.id_kategori and nip_nrp='" + t_nip_nrp.Text + "'";
                da = new SqlDataAdapter(sql, conn); //agar data dapat diolah

                conn.Open();

                da.Fill(ds, "Riwayat_Pendidikan");
                dt = ds.Tables["Riwayat_Pendidikan"];
                bm = BindingContext[dt];
                bm.Position = 0;

                dv = new DataView(dt); //data yang akan ditampilkan
                dataGridView1.DataSource = dv;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                dataGridView1.DataSource = dt; //memasukkan data ke dataGridView1 

                t_nama_pend.DataBindings.Add("Text", dt, "nama_pendidikan").ToString();
                t_tahun.DataBindings.Add("Text", dt, "tahun").ToString();
                t_ket.DataBindings.Add("Text", dt, "keterangan").ToString();
                t_nip_nrp.DataBindings.Add("Text", dt, "nip_nrp").ToString();
                cb_kategori_pend.DataBindings.Add("Text", dt, "nama_kategori").ToString();

                conn.Close();
                //this.tampil();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {

                String sql = "SELECT DISTINCT nama_kategori FROM Kategori_Pendidikan";
                cmd = new SqlCommand(sql, conn);
                conn.Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb_kategori_pend.Items.Add(dr["nama_kategori"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
               
        }

        private void p_insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand perintahTambah = new SqlCommand();

                perintahTambah.Connection = conn;
                perintahTambah.CommandType = CommandType.Text;
                perintahTambah.CommandText = "insert dbo.Riwayat_Pendidikan values(@nama_pendidikan, @tahun, @keterangan, @nip_nrp, @id_kategori)";

                perintahTambah.Parameters.AddWithValue("@nama_pendidikan", t_nama_pend.Text);
                perintahTambah.Parameters.AddWithValue("@tahun", t_tahun.Text);
                perintahTambah.Parameters.AddWithValue("@keterangan", t_ket.Text);
                perintahTambah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);
                perintahTambah.Parameters.AddWithValue("@id_kategori", this.cari_id_kategori(cb_kategori_pend.Text));
                //Console.WriteLine(this.cari_id_kategori(cb_kategori_pend.Text));

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

                perintahUbah.Connection = conn;
                perintahUbah.CommandType = CommandType.Text;
                perintahUbah.CommandText = "Update dbo.Riwayat_Pendidikan set nama_pendidikan=@nama_pendidikan, tahun=@tahun, keterangan=@keterangan, nip_nrp=@nip_nrp, id_kategori=@id_kategori where id_riw_pend = @id_riw_pend";

                perintahUbah.Parameters.AddWithValue("@id_riw_pend", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                perintahUbah.Parameters.AddWithValue("@nama_pendidikan", t_nama_pend.Text);
                perintahUbah.Parameters.AddWithValue("@tahun", t_tahun.Text);
                perintahUbah.Parameters.AddWithValue("@keterangan", t_ket.Text);
                perintahUbah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);
                //Console.WriteLine(this.cari_id_kategori(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString()));
                perintahUbah.Parameters.AddWithValue("@id_kategori", this.cari_id_kategori(cb_kategori_pend.Text));

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

        private string cari_id_kategori(string nama_kategori)
        {
            SqlCommand perintahCari = new SqlCommand();

            SqlConnection conn = Connection.connect();
            perintahCari.Connection = conn;
            perintahCari.CommandType = CommandType.Text;
            perintahCari.CommandText = "Select * from Kategori_Pendidikan where nama_kategori=@nama_kategori";
            perintahCari.Parameters.Add("@nama_kategori", SqlDbType.VarChar);
            perintahCari.Parameters["@nama_kategori"].Value = nama_kategori;

            conn.Open();
            dr = perintahCari.ExecuteReader();
            dr.Read();     
            return dr[0].ToString();
            conn.Close();
        }

        private void p_refresh_Click(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t_nip_nrp.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            t_nama_pend.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            t_tahun.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            t_ket.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            cb_kategori_pend.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();

           // Console.WriteLine(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //Console.WriteLine(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString());
            
        }

        private void p_delete_Click(object sender, EventArgs e)
        {
            SqlCommand perintahHapus = new SqlCommand();
            SqlConnection conn = Connection.connect();

            perintahHapus.Connection = conn;
            perintahHapus.CommandType = CommandType.Text;
            perintahHapus.CommandText = "Delete Riwayat_Pendidikan where id_riw_pend = @id_riw_pend";
            perintahHapus.Parameters.AddWithValue("@id_riw_pend", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

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
