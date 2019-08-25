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
    public partial class DataPokok : Form
    {
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataView dv;
        DataTable dt;
        DataSet ds = new DataSet();
        BindingManagerBase bm;
        SqlConnection conn = Connection.connect();

        public DataPokok(string nip_nrp)
        {
            InitializeComponent();
            t_nip_nrp.Text = nip_nrp;
            t_nip_nrp.Enabled = false;
        }

        private void DataPokok_Load(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = Connection.connect();
            try
            {
                String sql = "SELECT DISTINCT nama_satker FROM Satker";
                cmd = new SqlCommand(sql, conn);
                conn.Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb_satker.Items.Add(dr["nama_satker"].ToString());
                }
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

                perintahTambah.CommandText = "Insert dbo.Personil values (@nip_nrp, @nama_gelar, @tempat_lahir, @tgl_lahir, @jns_kelamin, @angkatan, @sumber_ba_ta, @tmt_ba_ta, @sumber_pa_gol3, @tmt_pa_gol3, @kategori_pegawai, @tmt_tni_pns, @id_satker, @tmt_satker, @agama, @status_kawin, @suku_bangsa, @alamat_rumah, @kode_pos, @telp_rumah, @telp_seluler, @email, @tinggi_badan, @berat_badan, @ukuran_sepatu, @ukuran_ttp_kepala, @gol_darah, @ukuran_baju, @bentuk_muka, @jenis_rambut, @warna_rambut, @ciri_khusus)"; 
                
                perintahTambah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);
                perintahTambah.Parameters.AddWithValue("@nama_gelar", t_nama.Text);
                perintahTambah.Parameters.AddWithValue("@tempat_lahir", t_tpt_lahir.Text);
                perintahTambah.Parameters.AddWithValue("@tgl_lahir", dt_tgl_lahir.Value);

                if (rb_laki.Checked == true) 
                {
                    perintahTambah.Parameters.AddWithValue("@jns_kelamin", "Laki-laki");
                }
                else if (rb_perempuan.Checked == true)
                {
                    perintahTambah.Parameters.AddWithValue("@jns_kelamin", "Perempuan");
                }
                perintahTambah.Parameters.AddWithValue("@angkatan", cb_angkatan.Text);

                perintahTambah.Parameters.AddWithValue("@sumber_ba_ta", t_sumber_ba_ta.Text);
                perintahTambah.Parameters.AddWithValue("@tmt_ba_ta", dt_ba_ta.Value);
                perintahTambah.Parameters.AddWithValue("@sumber_pa_gol3", t_sumber_pa_gol3.Text);
                perintahTambah.Parameters.AddWithValue("@tmt_pa_gol3", dt_tmt_pa_gol3.Value);
                perintahTambah.Parameters.AddWithValue("@kategori_pegawai", t_kategori.Text);
                perintahTambah.Parameters.AddWithValue("@tmt_tni_pns", dt_tmt_tni_pns.Value);
                perintahTambah.Parameters.AddWithValue("@id_satker", this.cari_id_satker(cb_satker.Text)); //cari id
                perintahTambah.Parameters.AddWithValue("@tmt_satker", dt_tmt_satuan.Value);
                perintahTambah.Parameters.AddWithValue("@agama", cb_agama.Text);
                perintahTambah.Parameters.AddWithValue("@status_kawin", cb_status_kawin.Text);
                perintahTambah.Parameters.AddWithValue("@suku_bangsa", t_suku.Text);
                perintahTambah.Parameters.AddWithValue("@alamat_rumah", t_alamat_rumah.Text);
                perintahTambah.Parameters.AddWithValue("@kode_pos", t_kode_pos.Text);
                perintahTambah.Parameters.AddWithValue("@telp_rumah", t_tlp_rumah.Text);
                perintahTambah.Parameters.AddWithValue("@telp_seluler", t_no_hp.Text);
                perintahTambah.Parameters.AddWithValue("@email", t_email.Text);
                perintahTambah.Parameters.AddWithValue("@tinggi_badan", t_tb.Text);
                perintahTambah.Parameters.AddWithValue("@berat_badan", t_bb.Text);
                perintahTambah.Parameters.AddWithValue("@ukuran_sepatu", t_ukrn_sepatu.Text);
                perintahTambah.Parameters.AddWithValue("@ukuran_ttp_kepala", t_ukrn_tutup_kepala.Text);
                perintahTambah.Parameters.AddWithValue("@gol_darah", t_gol_darah.Text);
                perintahTambah.Parameters.AddWithValue("@ukuran_baju", t_ukrn_baju.Text);
                perintahTambah.Parameters.AddWithValue("@bentuk_muka", t_btk_wajah.Text);
                perintahTambah.Parameters.AddWithValue("@jenis_rambut", t_jns_rambut.Text);
                perintahTambah.Parameters.AddWithValue("@warna_rambut", t_warna_rambut.Text);
                perintahTambah.Parameters.AddWithValue("@ciri_khusus", t_ciri_khusus.Text);
                MessageBox.Show("Apakah Anda yakin ingin Memasukkan Data");
                conn.Open();
                int result = perintahTambah.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Dimasukkan");
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

                perintahUbah.CommandText = "UPDATE dbo.Personil SET nama_gelar=@nama_gelar, tempat_lahir=@tempat_lahir, tgl_lahir=@tgl_lahir, jns_kelamin=@jns_kelamin, angkatan=@angkatan, sumber_ba_ta=@sumber_ba_ta, tmt_ba_ta=@tmt_ba_ta, sumber_pa_gol3=@sumber_pa_gol3, tmt_pa_gol3=@tmt_pa_gol3, kategori_pegawai=@kategori_pegawai, tmt_tni_pns=@tmt_tni_pns, id_satker=@id_satker, tmt_satker=@tmt_satker, agama=@agama, status_kawin=@status_kawin, suku_bangsa=@suku_bangsa, alamat_rumah=@alamat_rumah, kode_pos=@kode_pos, telp_rumah=@telp_rumah, telp_seluler=@telp_seluler, email=@email, tinggi_badan=@tinggi_badan, berat_badan=@berat_badan, ukuran_sepatu=@ukuran_sepatu, ukuran_ttp_kepala=@ukuran_ttp_kepala, gol_darah=@gol_darah, ukuran_baju=@ukuran_baju,bentuk_muka=@bentuk_muka, jenis_rambut=@jenis_rambut, warna_rambut=@warna_rambut, ciri_khusus=@ciri_khusus where nip_nrp=@nip_nrp"; 
                
                perintahUbah.Parameters.AddWithValue("@nip_nrp", t_nip_nrp.Text);
                perintahUbah.Parameters.AddWithValue("@nama_gelar", t_nama.Text);
                perintahUbah.Parameters.AddWithValue("@tempat_lahir", t_tpt_lahir.Text);
                perintahUbah.Parameters.AddWithValue("@tgl_lahir", dt_tgl_lahir.Value);

                if (rb_laki.Checked == true) 
                {
                    perintahUbah.Parameters.AddWithValue("@jns_kelamin", "Laki-laki");
                }
                else if (rb_perempuan.Checked == true)
                {
                    perintahUbah.Parameters.AddWithValue("@jns_kelamin", "Perempuan");
                }
                perintahUbah.Parameters.AddWithValue("@angkatan", cb_angkatan.Text);
                
                perintahUbah.Parameters.AddWithValue("@sumber_ba_ta", t_sumber_ba_ta.Text);
                perintahUbah.Parameters.AddWithValue("@tmt_ba_ta", dt_ba_ta.Value);
                perintahUbah.Parameters.AddWithValue("@sumber_pa_gol3", t_sumber_pa_gol3.Text);
                perintahUbah.Parameters.AddWithValue("@tmt_pa_gol3", dt_tmt_pa_gol3.Value);
                perintahUbah.Parameters.AddWithValue("@kategori_pegawai", t_kategori.Text);
                perintahUbah.Parameters.AddWithValue("@tmt_tni_pns", dt_tmt_tni_pns.Value);
                perintahUbah.Parameters.AddWithValue("@id_satker", this.cari_id_satker(cb_satker.Text)); //cari id
                perintahUbah.Parameters.AddWithValue("@tmt_satker", dt_tmt_satuan.Value);
                perintahUbah.Parameters.AddWithValue("@agama", cb_agama.Text);
                perintahUbah.Parameters.AddWithValue("@status_kawin", cb_status_kawin.Text);
                perintahUbah.Parameters.AddWithValue("@suku_bangsa", t_suku.Text);
                perintahUbah.Parameters.AddWithValue("@alamat_rumah", t_alamat_rumah.Text);
                perintahUbah.Parameters.AddWithValue("@kode_pos", t_kode_pos.Text);
                perintahUbah.Parameters.AddWithValue("@telp_rumah", t_tlp_rumah.Text);
                perintahUbah.Parameters.AddWithValue("@telp_seluler", t_no_hp.Text);
                perintahUbah.Parameters.AddWithValue("@email", t_email.Text);
                perintahUbah.Parameters.AddWithValue("@tinggi_badan", t_tb.Text);
                perintahUbah.Parameters.AddWithValue("@berat_badan", t_bb.Text);
                perintahUbah.Parameters.AddWithValue("@ukuran_sepatu", t_ukrn_sepatu.Text);
                perintahUbah.Parameters.AddWithValue("@ukuran_ttp_kepala", t_ukrn_tutup_kepala.Text);
                perintahUbah.Parameters.AddWithValue("@gol_darah", t_gol_darah.Text);
                perintahUbah.Parameters.AddWithValue("@ukuran_baju", t_ukrn_baju.Text);
                perintahUbah.Parameters.AddWithValue("@bentuk_muka", t_btk_wajah.Text);
                perintahUbah.Parameters.AddWithValue("@jenis_rambut", t_jns_rambut.Text);
                perintahUbah.Parameters.AddWithValue("@warna_rambut", t_warna_rambut.Text);
                perintahUbah.Parameters.AddWithValue("@ciri_khusus", t_ciri_khusus.Text);
                MessageBox.Show("Apakah Anda yakin ingin mengubah data");
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
            t_nama.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString(); 
            t_tpt_lahir.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            dt_tgl_lahir.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
           
            if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString() == "Laki-laki")
            {
                rb_laki.Checked = true;
            }
            else if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString() == "Perempuan")
            {
                rb_perempuan.Checked = true;
            }

            cb_angkatan.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
            t_sumber_ba_ta.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
            dt_ba_ta.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
            t_sumber_pa_gol3.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
            dt_tmt_pa_gol3.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value.ToString();
            t_kategori.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[10].Value.ToString();
            dt_tmt_tni_pns.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[11].Value.ToString();

            cb_satker.Text = cari_nama_satker(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[12].Value.ToString());
            
            
            dt_tmt_satuan.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[13].Value.ToString();
            cb_agama.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[14].Value.ToString();
            cb_status_kawin.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[15].Value.ToString();
            t_suku.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[16].Value.ToString();
            t_alamat_rumah.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[17].Value.ToString();
            t_kode_pos.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[18].Value.ToString();
            t_tlp_rumah.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[19].Value.ToString();
            t_no_hp.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[20].Value.ToString();
            t_email.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[21].Value.ToString();
            t_tb.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[22].Value.ToString();
            t_bb.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[23].Value.ToString();
            t_ukrn_sepatu.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[24].Value.ToString();
            t_ukrn_tutup_kepala.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[25].Value.ToString();
            t_gol_darah.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[26].Value.ToString();
            t_ukrn_baju.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[27].Value.ToString();
            t_btk_wajah.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[28].Value.ToString();
            t_jns_rambut.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[29].Value.ToString();
            t_warna_rambut.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[30].Value.ToString();
            t_ciri_khusus.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[31].Value.ToString();

        }

        void tampil()
        {
            da = new SqlDataAdapter("Select * from Personil where nip_nrp = '"+t_nip_nrp.Text+"'", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void segarkan()
        {
            //t_nip_nrp.Text = "";
            t_nama.Text = "";
            t_tpt_lahir.Text = "";
            dt_tgl_lahir.Value = DateTime.Now;
            cb_angkatan.Text = "";
            t_sumber_ba_ta.Text = "";
            dt_ba_ta.Value = DateTime.Now;
            t_sumber_pa_gol3.Text = "";
            dt_tmt_pa_gol3.Value = DateTime.Now;
            t_kategori.Text = "";
            dt_tmt_tni_pns.Value = DateTime.Now;
            cb_satker.Text = "";
            dt_tmt_satuan.Value = DateTime.Now;
            cb_agama.Text = "";
            cb_status_kawin.Text = "";
            t_suku.Text = "";
            t_alamat_rumah.Text = "";
            t_kode_pos.Text = "";
            t_tlp_rumah.Text = "";
            t_no_hp.Text = "";
            t_email.Text = "";
            t_tb.Text = "";
            t_bb.Text = "";
            t_ukrn_sepatu.Text = "";
            t_ukrn_tutup_kepala.Text = "";
            t_gol_darah.Text = "";
            t_ukrn_baju.Text = "";
            t_btk_wajah.Text = "";
            t_jns_rambut.Text = "";
            t_warna_rambut.Text = "";
            t_ciri_khusus.Text = "";  
        }

       

        private string cari_id_satker(string nama_satker)
        {
            SqlCommand perintahCari = new SqlCommand();
            SqlConnection conn = Connection.connect();

            perintahCari.Connection = conn;
            perintahCari.CommandType = CommandType.Text;
            perintahCari.CommandText = "Select * from Satker where nama_satker=@nama_satker";
            perintahCari.Parameters.Add("@nama_satker", SqlDbType.VarChar);
            perintahCari.Parameters["@nama_satker"].Value = nama_satker;

            conn.Open();
            dr = perintahCari.ExecuteReader();
            dr.Read();
            return dr[0].ToString();
            conn.Close();
        }

        private string cari_nama_satker(string id_satker)
        {
            SqlCommand perintahCari = new SqlCommand();
            SqlConnection conn = Connection.connect();

            perintahCari.Connection = conn;
            perintahCari.CommandType = CommandType.Text;
            perintahCari.CommandText = "Select * from Satker where id_satker=@id_satker";
            perintahCari.Parameters.Add("@id_satker", SqlDbType.Int);
            perintahCari.Parameters["@id_satker"].Value = id_satker;

            conn.Open();
            dr = perintahCari.ExecuteReader();
            dr.Read();
            return dr[1].ToString();
            conn.Close();
        }

        private void b_home_Click(object sender, EventArgs e)
        {
            Form1 Frm = new Form1(t_nip_nrp.Text);
            Frm.Show();
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

        private void b_r_keluarga_Click(object sender, EventArgs e)
        {
            Riwayat_Keluarga rk = new Riwayat_Keluarga(t_nip_nrp.Text);
            rk.Show();
            this.Hide();
        }

        private void t_sumber_ba_ta_Leave(object sender, EventArgs e)
        {
            t_sumber_pa_gol3.Enabled = false;
            dt_tmt_pa_gol3.Enabled = false;
        }

        private void p_refresh_Click(object sender, EventArgs e)
        {
            this.segarkan();
            this.tampil();
            rb_laki.Checked = true;
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
