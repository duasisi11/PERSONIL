namespace PERSONIL
{
    partial class Riwayat_Tanda_Jasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Riwayat_Tanda_Jasa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.riwayat_PendidikanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Data_Personil = new PERSONIL.DS_Data_Personil();
            this.riwayat_PendidikanTableAdapter = new PERSONIL.DS_Data_PersonilTableAdapters.Riwayat_PendidikanTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableAdapterManager = new PERSONIL.DS_Data_PersonilTableAdapters.TableAdapterManager();
            this.satkerTableAdapter = new PERSONIL.DS_Data_PersonilTableAdapters.SatkerTableAdapter();
            this.satkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt_tgl_skep = new System.Windows.Forms.DateTimePicker();
            this.t_no_skep = new System.Windows.Forms.TextBox();
            this.t_nama_tanda = new System.Windows.Forms.TextBox();
            this.t_nip_nrp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_insert = new System.Windows.Forms.Panel();
            this.p_update = new System.Windows.Forms.Panel();
            this.p_refresh = new System.Windows.Forms.Panel();
            this.p_delete = new System.Windows.Forms.Panel();
            this.b_dokumen = new System.Windows.Forms.Button();
            this.b_ubah_password = new System.Windows.Forms.Button();
            this.b_r_keluarga = new System.Windows.Forms.Button();
            this.b_bahasa = new System.Windows.Forms.Button();
            this.b_r_tanda_jasa = new System.Windows.Forms.Button();
            this.b_r_penugasan = new System.Windows.Forms.Button();
            this.b_r_pendidikan = new System.Windows.Forms.Button();
            this.b_r_jabatan = new System.Windows.Forms.Button();
            this.b_r_pangkat = new System.Windows.Forms.Button();
            this.b_kartu_identitas = new System.Windows.Forms.Button();
            this.b_data_pokok = new System.Windows.Forms.Button();
            this.b_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riwayat_PendidikanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Data_Personil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satkerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Riwayat Tanda Jasa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistem Pengelolahan data Personil";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(176, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1134, 73);
            this.panel4.TabIndex = 155;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 45);
            this.panel2.TabIndex = 154;
            // 
            // riwayat_PendidikanBindingSource
            // 
            this.riwayat_PendidikanBindingSource.DataMember = "Riwayat_Pendidikan";
            this.riwayat_PendidikanBindingSource.DataSource = this.dS_Data_Personil;
            // 
            // dS_Data_Personil
            // 
            this.dS_Data_Personil.DataSetName = "DS_Data_Personil";
            this.dS_Data_Personil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // riwayat_PendidikanTableAdapter
            // 
            this.riwayat_PendidikanTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(425, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 225);
            this.dataGridView1.TabIndex = 153;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BahasaTableAdapter = null;
            this.tableAdapterManager.DokumenTableAdapter = null;
            this.tableAdapterManager.Kartu_IdentitasTableAdapter = null;
            this.tableAdapterManager.Kategori_PendidikanTableAdapter = null;
            this.tableAdapterManager.PersonilTableAdapter = null;
            this.tableAdapterManager.Riwayat_JabatanTableAdapter = null;
            this.tableAdapterManager.Riwayat_KeluargaTableAdapter = null;
            this.tableAdapterManager.Riwayat_PangkatTableAdapter = null;
            this.tableAdapterManager.Riwayat_PendidikanTableAdapter = null;
            this.tableAdapterManager.Riwayat_PenugasanTableAdapter = null;
            this.tableAdapterManager.Riwayat_Tanda_JasaTableAdapter = null;
            this.tableAdapterManager.SatkerTableAdapter = this.satkerTableAdapter;
            this.tableAdapterManager.UpdateOrder = PERSONIL.DS_Data_PersonilTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // satkerTableAdapter
            // 
            this.satkerTableAdapter.ClearBeforeFill = true;
            // 
            // satkerBindingSource
            // 
            this.satkerBindingSource.DataMember = "Satker";
            this.satkerBindingSource.DataSource = this.dS_Data_Personil;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.b_dokumen);
            this.panel1.Controls.Add(this.b_ubah_password);
            this.panel1.Controls.Add(this.b_r_keluarga);
            this.panel1.Controls.Add(this.b_bahasa);
            this.panel1.Controls.Add(this.b_r_tanda_jasa);
            this.panel1.Controls.Add(this.b_r_penugasan);
            this.panel1.Controls.Add(this.b_r_pendidikan);
            this.panel1.Controls.Add(this.b_r_jabatan);
            this.panel1.Controls.Add(this.b_r_pangkat);
            this.panel1.Controls.Add(this.b_kartu_identitas);
            this.panel1.Controls.Add(this.b_data_pokok);
            this.panel1.Controls.Add(this.b_home);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 666);
            this.panel1.TabIndex = 138;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 434);
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
            // dt_tgl_skep
            // 
            this.dt_tgl_skep.Location = new System.Drawing.Point(676, 300);
            this.dt_tgl_skep.Name = "dt_tgl_skep";
            this.dt_tgl_skep.Size = new System.Drawing.Size(282, 20);
            this.dt_tgl_skep.TabIndex = 159;
            // 
            // t_no_skep
            // 
            this.t_no_skep.Location = new System.Drawing.Point(676, 258);
            this.t_no_skep.Name = "t_no_skep";
            this.t_no_skep.Size = new System.Drawing.Size(282, 20);
            this.t_no_skep.TabIndex = 158;
            // 
            // t_nama_tanda
            // 
            this.t_nama_tanda.Location = new System.Drawing.Point(676, 212);
            this.t_nama_tanda.Name = "t_nama_tanda";
            this.t_nama_tanda.Size = new System.Drawing.Size(282, 20);
            this.t_nama_tanda.TabIndex = 157;
            // 
            // t_nip_nrp
            // 
            this.t_nip_nrp.Location = new System.Drawing.Point(676, 166);
            this.t_nip_nrp.Name = "t_nip_nrp";
            this.t_nip_nrp.Size = new System.Drawing.Size(282, 20);
            this.t_nip_nrp.TabIndex = 156;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 163;
            this.label6.Text = "Tanggal Skep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 162;
            this.label5.Text = "No. Skep";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 161;
            this.label4.Text = "Nama Tanda Jasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 160;
            this.label3.Text = "NIP/NRP";
            // 
            // p_insert
            // 
            this.p_insert.BackgroundImage = global::PERSONIL.Properties.Resources.Male_user_add_icon;
            this.p_insert.Location = new System.Drawing.Point(475, 356);
            this.p_insert.Name = "p_insert";
            this.p_insert.Size = new System.Drawing.Size(49, 49);
            this.p_insert.TabIndex = 145;
            this.p_insert.Click += new System.EventHandler(this.p_insert_Click);
            // 
            // p_update
            // 
            this.p_update.BackgroundImage = global::PERSONIL.Properties.Resources.Male_user_edit_icon;
            this.p_update.Location = new System.Drawing.Point(777, 356);
            this.p_update.Name = "p_update";
            this.p_update.Size = new System.Drawing.Size(49, 49);
            this.p_update.TabIndex = 146;
            this.p_update.Click += new System.EventHandler(this.p_update_Click);
            // 
            // p_refresh
            // 
            this.p_refresh.BackgroundImage = global::PERSONIL.Properties.Resources.Button_Refresh_icon;
            this.p_refresh.Location = new System.Drawing.Point(932, 356);
            this.p_refresh.Name = "p_refresh";
            this.p_refresh.Size = new System.Drawing.Size(49, 49);
            this.p_refresh.TabIndex = 148;
            this.p_refresh.Click += new System.EventHandler(this.p_refresh_Click);
            // 
            // p_delete
            // 
            this.p_delete.BackgroundImage = global::PERSONIL.Properties.Resources.Male_user_remove_icon;
            this.p_delete.Location = new System.Drawing.Point(634, 356);
            this.p_delete.Name = "p_delete";
            this.p_delete.Size = new System.Drawing.Size(49, 49);
            this.p_delete.TabIndex = 147;
            this.p_delete.Click += new System.EventHandler(this.p_delete_Click);
            // 
            // b_dokumen
            // 
            this.b_dokumen.FlatAppearance.BorderSize = 0;
            this.b_dokumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_dokumen.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_dokumen.ForeColor = System.Drawing.Color.White;
            this.b_dokumen.Image = ((System.Drawing.Image)(resources.GetObject("b_dokumen.Image")));
            this.b_dokumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_dokumen.Location = new System.Drawing.Point(10, 570);
            this.b_dokumen.Name = "b_dokumen";
            this.b_dokumen.Size = new System.Drawing.Size(167, 38);
            this.b_dokumen.TabIndex = 165;
            this.b_dokumen.Text = "Dokumen";
            this.b_dokumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_dokumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_dokumen.UseVisualStyleBackColor = true;
            this.b_dokumen.Click += new System.EventHandler(this.b_dokumen_Click);
            // 
            // b_ubah_password
            // 
            this.b_ubah_password.FlatAppearance.BorderSize = 0;
            this.b_ubah_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ubah_password.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ubah_password.ForeColor = System.Drawing.Color.White;
            this.b_ubah_password.Image = ((System.Drawing.Image)(resources.GetObject("b_ubah_password.Image")));
            this.b_ubah_password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_ubah_password.Location = new System.Drawing.Point(10, 613);
            this.b_ubah_password.Name = "b_ubah_password";
            this.b_ubah_password.Size = new System.Drawing.Size(167, 38);
            this.b_ubah_password.TabIndex = 164;
            this.b_ubah_password.Text = "Ubah Password";
            this.b_ubah_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_ubah_password.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_ubah_password.UseVisualStyleBackColor = true;
            this.b_ubah_password.Click += new System.EventHandler(this.b_ubah_password_Click);
            // 
            // b_r_keluarga
            // 
            this.b_r_keluarga.FlatAppearance.BorderSize = 0;
            this.b_r_keluarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_r_keluarga.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_r_keluarga.ForeColor = System.Drawing.Color.White;
            this.b_r_keluarga.Image = ((System.Drawing.Image)(resources.GetObject("b_r_keluarga.Image")));
            this.b_r_keluarga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_r_keluarga.Location = new System.Drawing.Point(10, 525);
            this.b_r_keluarga.Name = "b_r_keluarga";
            this.b_r_keluarga.Size = new System.Drawing.Size(167, 38);
            this.b_r_keluarga.TabIndex = 46;
            this.b_r_keluarga.Text = "Riwayat Keluarga";
            this.b_r_keluarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_r_keluarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_r_keluarga.UseVisualStyleBackColor = true;
            this.b_r_keluarga.Click += new System.EventHandler(this.b_r_keluarga_Click);
            // 
            // b_bahasa
            // 
            this.b_bahasa.FlatAppearance.BorderSize = 0;
            this.b_bahasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_bahasa.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_bahasa.ForeColor = System.Drawing.Color.White;
            this.b_bahasa.Image = ((System.Drawing.Image)(resources.GetObject("b_bahasa.Image")));
            this.b_bahasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_bahasa.Location = new System.Drawing.Point(10, 479);
            this.b_bahasa.Name = "b_bahasa";
            this.b_bahasa.Size = new System.Drawing.Size(167, 38);
            this.b_bahasa.TabIndex = 45;
            this.b_bahasa.Text = "Penguasaan Bahasa";
            this.b_bahasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_bahasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_bahasa.UseVisualStyleBackColor = true;
            this.b_bahasa.Click += new System.EventHandler(this.b_bahasa_Click);
            // 
            // b_r_tanda_jasa
            // 
            this.b_r_tanda_jasa.FlatAppearance.BorderSize = 0;
            this.b_r_tanda_jasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_r_tanda_jasa.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_r_tanda_jasa.ForeColor = System.Drawing.Color.White;
            this.b_r_tanda_jasa.Image = ((System.Drawing.Image)(resources.GetObject("b_r_tanda_jasa.Image")));
            this.b_r_tanda_jasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_r_tanda_jasa.Location = new System.Drawing.Point(10, 434);
            this.b_r_tanda_jasa.Name = "b_r_tanda_jasa";
            this.b_r_tanda_jasa.Size = new System.Drawing.Size(167, 38);
            this.b_r_tanda_jasa.TabIndex = 44;
            this.b_r_tanda_jasa.Text = "Riwayat Tanda Jasa";
            this.b_r_tanda_jasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_r_tanda_jasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_r_tanda_jasa.UseVisualStyleBackColor = true;
            // 
            // b_r_penugasan
            // 
            this.b_r_penugasan.FlatAppearance.BorderSize = 0;
            this.b_r_penugasan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_r_penugasan.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_r_penugasan.ForeColor = System.Drawing.Color.White;
            this.b_r_penugasan.Image = ((System.Drawing.Image)(resources.GetObject("b_r_penugasan.Image")));
            this.b_r_penugasan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_r_penugasan.Location = new System.Drawing.Point(10, 389);
            this.b_r_penugasan.Name = "b_r_penugasan";
            this.b_r_penugasan.Size = new System.Drawing.Size(167, 38);
            this.b_r_penugasan.TabIndex = 43;
            this.b_r_penugasan.Text = "Riwayat Penugasan";
            this.b_r_penugasan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_r_penugasan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_r_penugasan.UseVisualStyleBackColor = true;
            this.b_r_penugasan.Click += new System.EventHandler(this.b_r_penugasan_Click);
            // 
            // b_r_pendidikan
            // 
            this.b_r_pendidikan.FlatAppearance.BorderSize = 0;
            this.b_r_pendidikan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_r_pendidikan.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_r_pendidikan.ForeColor = System.Drawing.Color.White;
            this.b_r_pendidikan.Image = ((System.Drawing.Image)(resources.GetObject("b_r_pendidikan.Image")));
            this.b_r_pendidikan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_r_pendidikan.Location = new System.Drawing.Point(10, 344);
            this.b_r_pendidikan.Name = "b_r_pendidikan";
            this.b_r_pendidikan.Size = new System.Drawing.Size(167, 38);
            this.b_r_pendidikan.TabIndex = 42;
            this.b_r_pendidikan.Text = "Riwayat Pendidikan";
            this.b_r_pendidikan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_r_pendidikan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_r_pendidikan.UseVisualStyleBackColor = true;
            this.b_r_pendidikan.Click += new System.EventHandler(this.b_r_pendidikan_Click);
            // 
            // b_r_jabatan
            // 
            this.b_r_jabatan.FlatAppearance.BorderSize = 0;
            this.b_r_jabatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_r_jabatan.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_r_jabatan.ForeColor = System.Drawing.Color.White;
            this.b_r_jabatan.Image = ((System.Drawing.Image)(resources.GetObject("b_r_jabatan.Image")));
            this.b_r_jabatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_r_jabatan.Location = new System.Drawing.Point(10, 300);
            this.b_r_jabatan.Name = "b_r_jabatan";
            this.b_r_jabatan.Size = new System.Drawing.Size(167, 38);
            this.b_r_jabatan.TabIndex = 41;
            this.b_r_jabatan.Text = "Riwayat Jabatan";
            this.b_r_jabatan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_r_jabatan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_r_jabatan.UseVisualStyleBackColor = true;
            this.b_r_jabatan.Click += new System.EventHandler(this.b_r_jabatan_Click);
            // 
            // b_r_pangkat
            // 
            this.b_r_pangkat.FlatAppearance.BorderSize = 0;
            this.b_r_pangkat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_r_pangkat.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_r_pangkat.ForeColor = System.Drawing.Color.White;
            this.b_r_pangkat.Image = ((System.Drawing.Image)(resources.GetObject("b_r_pangkat.Image")));
            this.b_r_pangkat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_r_pangkat.Location = new System.Drawing.Point(9, 256);
            this.b_r_pangkat.Name = "b_r_pangkat";
            this.b_r_pangkat.Size = new System.Drawing.Size(167, 38);
            this.b_r_pangkat.TabIndex = 40;
            this.b_r_pangkat.Text = "Riwayat Pangkat";
            this.b_r_pangkat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_r_pangkat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_r_pangkat.UseVisualStyleBackColor = true;
            this.b_r_pangkat.Click += new System.EventHandler(this.b_r_pangkat_Click);
            // 
            // b_kartu_identitas
            // 
            this.b_kartu_identitas.FlatAppearance.BorderSize = 0;
            this.b_kartu_identitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_kartu_identitas.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_kartu_identitas.ForeColor = System.Drawing.Color.White;
            this.b_kartu_identitas.Image = ((System.Drawing.Image)(resources.GetObject("b_kartu_identitas.Image")));
            this.b_kartu_identitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_kartu_identitas.Location = new System.Drawing.Point(9, 211);
            this.b_kartu_identitas.Name = "b_kartu_identitas";
            this.b_kartu_identitas.Size = new System.Drawing.Size(167, 38);
            this.b_kartu_identitas.TabIndex = 34;
            this.b_kartu_identitas.Text = "Kartu Identitas";
            this.b_kartu_identitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_kartu_identitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_kartu_identitas.UseVisualStyleBackColor = true;
            this.b_kartu_identitas.Click += new System.EventHandler(this.b_kartu_identitas_Click);
            // 
            // b_data_pokok
            // 
            this.b_data_pokok.FlatAppearance.BorderSize = 0;
            this.b_data_pokok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_data_pokok.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_data_pokok.ForeColor = System.Drawing.Color.White;
            this.b_data_pokok.Image = ((System.Drawing.Image)(resources.GetObject("b_data_pokok.Image")));
            this.b_data_pokok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_data_pokok.Location = new System.Drawing.Point(9, 166);
            this.b_data_pokok.Name = "b_data_pokok";
            this.b_data_pokok.Size = new System.Drawing.Size(167, 38);
            this.b_data_pokok.TabIndex = 33;
            this.b_data_pokok.Text = "Data Pokok";
            this.b_data_pokok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_data_pokok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_data_pokok.UseVisualStyleBackColor = true;
            this.b_data_pokok.Click += new System.EventHandler(this.b_data_pokok_Click);
            // 
            // b_home
            // 
            this.b_home.FlatAppearance.BorderSize = 0;
            this.b_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_home.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_home.ForeColor = System.Drawing.Color.White;
            this.b_home.Image = ((System.Drawing.Image)(resources.GetObject("b_home.Image")));
            this.b_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_home.Location = new System.Drawing.Point(9, 121);
            this.b_home.Name = "b_home";
            this.b_home.Size = new System.Drawing.Size(167, 38);
            this.b_home.TabIndex = 32;
            this.b_home.Text = "Home";
            this.b_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_home.UseVisualStyleBackColor = true;
            this.b_home.Click += new System.EventHandler(this.b_home_Click);
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
            // Riwayat_Tanda_Jasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 666);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_tgl_skep);
            this.Controls.Add(this.t_no_skep);
            this.Controls.Add(this.t_nama_tanda);
            this.Controls.Add(this.t_nip_nrp);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.p_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.p_update);
            this.Controls.Add(this.p_refresh);
            this.Controls.Add(this.p_delete);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Riwayat_Tanda_Jasa";
            this.Text = "Riwayat_Tanda_Jasa";
            this.Load += new System.EventHandler(this.Riwayat_Tanda_Jasa_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riwayat_PendidikanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Data_Personil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satkerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel p_insert;
        private System.Windows.Forms.BindingSource riwayat_PendidikanBindingSource;
        private DS_Data_Personil dS_Data_Personil;
        private DS_Data_PersonilTableAdapters.Riwayat_PendidikanTableAdapter riwayat_PendidikanTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel p_update;
        private DS_Data_PersonilTableAdapters.TableAdapterManager tableAdapterManager;
        private DS_Data_PersonilTableAdapters.SatkerTableAdapter satkerTableAdapter;
        private System.Windows.Forms.Panel p_refresh;
        private System.Windows.Forms.BindingSource satkerBindingSource;
        private System.Windows.Forms.Panel p_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_r_keluarga;
        private System.Windows.Forms.Button b_bahasa;
        private System.Windows.Forms.Button b_r_tanda_jasa;
        private System.Windows.Forms.Button b_r_penugasan;
        private System.Windows.Forms.Button b_r_pendidikan;
        private System.Windows.Forms.Button b_r_jabatan;
        private System.Windows.Forms.Button b_r_pangkat;
        private System.Windows.Forms.Button b_kartu_identitas;
        private System.Windows.Forms.Button b_data_pokok;
        private System.Windows.Forms.Button b_home;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dt_tgl_skep;
        private System.Windows.Forms.TextBox t_no_skep;
        private System.Windows.Forms.TextBox t_nama_tanda;
        private System.Windows.Forms.TextBox t_nip_nrp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_dokumen;
        private System.Windows.Forms.Button b_ubah_password;

    }
}