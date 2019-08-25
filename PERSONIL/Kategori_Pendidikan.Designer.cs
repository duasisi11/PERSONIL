namespace PERSONIL
{
    partial class Kategori_Pendidikan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kategori_Pendidikan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_home = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.t_nama_kategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategori_PendidikanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Data_Personil = new PERSONIL.DS_Data_Personil();
            this.kategori_PendidikanTableAdapter = new PERSONIL.DS_Data_PersonilTableAdapters.Kategori_PendidikanTableAdapter();
            this.tableAdapterManager = new PERSONIL.DS_Data_PersonilTableAdapters.TableAdapterManager();
            this.p_hapus = new System.Windows.Forms.Panel();
            this.p_ubah = new System.Windows.Forms.Panel();
            this.p_tambah = new System.Windows.Forms.Panel();
            this.p_refresh = new System.Windows.Forms.Panel();
            this.b_manajement_user = new System.Windows.Forms.Button();
            this.b_kategori_pend = new System.Windows.Forms.Button();
            this.b_satker = new System.Windows.Forms.Button();
            this.b_rekap_data = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategori_PendidikanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Data_Personil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Pendidikan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistem Pengelolahan data Personil";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(176, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 72);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b_home
            // 
            this.b_home.FlatAppearance.BorderSize = 0;
            this.b_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_home.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_home.ForeColor = System.Drawing.Color.White;
            this.b_home.Image = ((System.Drawing.Image)(resources.GetObject("b_home.Image")));
            this.b_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_home.Location = new System.Drawing.Point(9, 124);
            this.b_home.Name = "b_home";
            this.b_home.Size = new System.Drawing.Size(167, 38);
            this.b_home.TabIndex = 32;
            this.b_home.Text = "Home";
            this.b_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_home.UseVisualStyleBackColor = true;
            this.b_home.Click += new System.EventHandler(this.b_home_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 313);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 38);
            this.panel5.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 118);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(176, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(678, 46);
            this.panel4.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.b_manajement_user);
            this.panel1.Controls.Add(this.b_kategori_pend);
            this.panel1.Controls.Add(this.b_satker);
            this.panel1.Controls.Add(this.b_rekap_data);
            this.panel1.Controls.Add(this.b_home);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 609);
            this.panel1.TabIndex = 6;
            // 
            // t_nama_kategori
            // 
            this.t_nama_kategori.Location = new System.Drawing.Point(417, 192);
            this.t_nama_kategori.Name = "t_nama_kategori";
            this.t_nama_kategori.Size = new System.Drawing.Size(278, 20);
            this.t_nama_kategori.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "Nama Kategori";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 257);
            this.dataGridView1.TabIndex = 128;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kategori_PendidikanBindingSource
            // 
            this.kategori_PendidikanBindingSource.DataMember = "Kategori_Pendidikan";
            this.kategori_PendidikanBindingSource.DataSource = this.dS_Data_Personil;
            // 
            // dS_Data_Personil
            // 
            this.dS_Data_Personil.DataSetName = "DS_Data_Personil";
            this.dS_Data_Personil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategori_PendidikanTableAdapter
            // 
            this.kategori_PendidikanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BahasaTableAdapter = null;
            this.tableAdapterManager.DokumenTableAdapter = null;
            this.tableAdapterManager.Kartu_IdentitasTableAdapter = null;
            this.tableAdapterManager.Kategori_PendidikanTableAdapter = this.kategori_PendidikanTableAdapter;
            this.tableAdapterManager.PersonilTableAdapter = null;
            this.tableAdapterManager.Riwayat_JabatanTableAdapter = null;
            this.tableAdapterManager.Riwayat_KeluargaTableAdapter = null;
            this.tableAdapterManager.Riwayat_PangkatTableAdapter = null;
            this.tableAdapterManager.Riwayat_PendidikanTableAdapter = null;
            this.tableAdapterManager.Riwayat_PenugasanTableAdapter = null;
            this.tableAdapterManager.Riwayat_Tanda_JasaTableAdapter = null;
            this.tableAdapterManager.SatkerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PERSONIL.DS_Data_PersonilTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p_hapus
            // 
            this.p_hapus.BackgroundImage = global::PERSONIL.Properties.Resources.Male_user_remove_icon;
            this.p_hapus.Location = new System.Drawing.Point(538, 268);
            this.p_hapus.Name = "p_hapus";
            this.p_hapus.Size = new System.Drawing.Size(49, 49);
            this.p_hapus.TabIndex = 132;
            this.p_hapus.Click += new System.EventHandler(this.p_hapus_Click);
            // 
            // p_ubah
            // 
            this.p_ubah.BackgroundImage = global::PERSONIL.Properties.Resources.Male_user_edit_icon;
            this.p_ubah.Location = new System.Drawing.Point(401, 268);
            this.p_ubah.Name = "p_ubah";
            this.p_ubah.Size = new System.Drawing.Size(49, 49);
            this.p_ubah.TabIndex = 131;
            this.p_ubah.Click += new System.EventHandler(this.p_ubah_Click);
            // 
            // p_tambah
            // 
            this.p_tambah.BackgroundImage = global::PERSONIL.Properties.Resources.Male_user_add_icon;
            this.p_tambah.Location = new System.Drawing.Point(255, 268);
            this.p_tambah.Name = "p_tambah";
            this.p_tambah.Size = new System.Drawing.Size(49, 49);
            this.p_tambah.TabIndex = 130;
            this.p_tambah.Click += new System.EventHandler(this.p_tambah_Click);
            // 
            // p_refresh
            // 
            this.p_refresh.BackgroundImage = global::PERSONIL.Properties.Resources.Button_Refresh_icon;
            this.p_refresh.Location = new System.Drawing.Point(661, 268);
            this.p_refresh.Name = "p_refresh";
            this.p_refresh.Size = new System.Drawing.Size(49, 49);
            this.p_refresh.TabIndex = 131;
            this.p_refresh.Click += new System.EventHandler(this.p_refresh_Click);
            // 
            // b_manajement_user
            // 
            this.b_manajement_user.FlatAppearance.BorderSize = 0;
            this.b_manajement_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_manajement_user.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_manajement_user.ForeColor = System.Drawing.Color.White;
            this.b_manajement_user.Image = ((System.Drawing.Image)(resources.GetObject("b_manajement_user.Image")));
            this.b_manajement_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_manajement_user.Location = new System.Drawing.Point(9, 174);
            this.b_manajement_user.Name = "b_manajement_user";
            this.b_manajement_user.Size = new System.Drawing.Size(167, 38);
            this.b_manajement_user.TabIndex = 44;
            this.b_manajement_user.Text = "Manajement User";
            this.b_manajement_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_manajement_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_manajement_user.UseVisualStyleBackColor = true;
            this.b_manajement_user.Click += new System.EventHandler(this.b_manajement_user_Click);
            // 
            // b_kategori_pend
            // 
            this.b_kategori_pend.FlatAppearance.BorderSize = 0;
            this.b_kategori_pend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_kategori_pend.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_kategori_pend.ForeColor = System.Drawing.Color.White;
            this.b_kategori_pend.Image = ((System.Drawing.Image)(resources.GetObject("b_kategori_pend.Image")));
            this.b_kategori_pend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_kategori_pend.Location = new System.Drawing.Point(9, 313);
            this.b_kategori_pend.Name = "b_kategori_pend";
            this.b_kategori_pend.Size = new System.Drawing.Size(167, 38);
            this.b_kategori_pend.TabIndex = 43;
            this.b_kategori_pend.Text = "Kategori Pendidikan";
            this.b_kategori_pend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_kategori_pend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_kategori_pend.UseVisualStyleBackColor = true;
            // 
            // b_satker
            // 
            this.b_satker.FlatAppearance.BorderSize = 0;
            this.b_satker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_satker.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_satker.ForeColor = System.Drawing.Color.White;
            this.b_satker.Image = ((System.Drawing.Image)(resources.GetObject("b_satker.Image")));
            this.b_satker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_satker.Location = new System.Drawing.Point(9, 268);
            this.b_satker.Name = "b_satker";
            this.b_satker.Size = new System.Drawing.Size(167, 38);
            this.b_satker.TabIndex = 42;
            this.b_satker.Text = "Satuan Kerja";
            this.b_satker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_satker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_satker.UseVisualStyleBackColor = true;
            this.b_satker.Click += new System.EventHandler(this.b_satker_Click);
            // 
            // b_rekap_data
            // 
            this.b_rekap_data.FlatAppearance.BorderSize = 0;
            this.b_rekap_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_rekap_data.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_rekap_data.ForeColor = System.Drawing.Color.White;
            this.b_rekap_data.Image = ((System.Drawing.Image)(resources.GetObject("b_rekap_data.Image")));
            this.b_rekap_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_rekap_data.Location = new System.Drawing.Point(9, 222);
            this.b_rekap_data.Name = "b_rekap_data";
            this.b_rekap_data.Size = new System.Drawing.Size(167, 38);
            this.b_rekap_data.TabIndex = 41;
            this.b_rekap_data.Text = "Rekap Data Personil";
            this.b_rekap_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_rekap_data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_rekap_data.UseVisualStyleBackColor = true;
            this.b_rekap_data.Click += new System.EventHandler(this.b_rekap_data_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Admin";
            // 
            // Kategori_Pendidikan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 609);
            this.Controls.Add(this.p_refresh);
            this.Controls.Add(this.p_hapus);
            this.Controls.Add(this.p_ubah);
            this.Controls.Add(this.p_tambah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t_nama_kategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kategori_Pendidikan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori_Pendidikan";
            this.Load += new System.EventHandler(this.Kategori_Pendidikan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategori_PendidikanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Data_Personil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_home;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox t_nama_kategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DS_Data_Personil dS_Data_Personil;
        private System.Windows.Forms.BindingSource kategori_PendidikanBindingSource;
        private DS_Data_PersonilTableAdapters.Kategori_PendidikanTableAdapter kategori_PendidikanTableAdapter;
        private DS_Data_PersonilTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel p_hapus;
        private System.Windows.Forms.Panel p_ubah;
        private System.Windows.Forms.Panel p_tambah;
        private System.Windows.Forms.Panel p_refresh;
        private System.Windows.Forms.Button b_manajement_user;
        private System.Windows.Forms.Button b_kategori_pend;
        private System.Windows.Forms.Button b_satker;
        private System.Windows.Forms.Button b_rekap_data;
        private System.Windows.Forms.Label label4;
    }
}