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
    public partial class Ubah_Password : Form
    {
        SqlConnection conn;
        SqlDataReader dr;

        public Ubah_Password(string nip_nrp)
        {
            InitializeComponent();
            t_nip_nrp.Text = nip_nrp;
            t_nip_nrp.Enabled = false;
        }

        private void p_update_Click(object sender, EventArgs e)
        {
            SqlCommand perintahLogin = new SqlCommand();
            conn = Connection.connect();
            perintahLogin.Connection = conn;

            perintahLogin.CommandType = CommandType.Text;
            perintahLogin.CommandText = "select * from dbo.Manajement_User where nip_nrp=@nip_nrp and password=@password";

            perintahLogin.Parameters.Add("@nip_nrp", SqlDbType.VarChar);
            perintahLogin.Parameters.Add("@password", SqlDbType.VarChar);
            perintahLogin.Parameters["@nip_nrp"].Value = t_nip_nrp.Text.Trim();
            perintahLogin.Parameters["@password"].Value = t_pass_lama.Text.Trim();

            conn.Open();
            dr = perintahLogin.ExecuteReader();

            if (dr.Read() == true)
            {
                //MessageBox.Show("Berhasil");

                this.UpdatePassword(t_pass_baru.Text.Trim());

            }
            else
            {
                MessageBox.Show("Pastikan Password lama anda benar.!");
            }

            conn.Close();
        }

        private void UpdatePassword(string password_baru)
        {
            string pass_br = password_baru;  
            SqlCommand perintahUbah = new SqlCommand();
            conn = Connection.connect();
            perintahUbah.Connection = conn;

            perintahUbah.CommandType = CommandType.Text;
            perintahUbah.CommandText = "update dbo.Manajement_User set password='" + pass_br + "' where nip_nrp=@nip_nrp";
            perintahUbah.Parameters.Add("@nip_nrp", SqlDbType.VarChar);
            perintahUbah.Parameters["@nip_nrp"].Value = t_nip_nrp.Text.Trim();

            conn.Open();
            int result = perintahUbah.ExecuteNonQuery();
            MessageBox.Show("Password Berhasil DiUbah...");
            conn.Close();     
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
    }
}
