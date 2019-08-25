namespace PERSONIL
{
    partial class Satuan_Kerja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satuan_Kerja));
            this.p_update = new System.Windows.Forms.Panel();
            this.p_insert = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t_no_telp = new System.Windows.Forms.TextBox();
            this.t_alamat_sat = new System.Windows.Forms.TextBox();
            this.t_satuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_home = new System.Windows.Forms.Button();
            this.p_delete = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.satkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Data_Personil = new PERSONIL.DS_Data_Personil();
            this.satkerTableAdapter = new PERSONIL.DS_Data_PersonilTableAdapters.SatkerTableAdapter();
            this.tableAdapterManager = new PERSONIL.DS_Data_PersonilTableAdapters.TableAdapterManager();
            this.p_refresh = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.b_manajement_user = new System.Windows.Forms.Button();
            this.b_kategori_pend = new System.Windows.Forms.Button();
            this.b_satker = new System.Windows.Forms.Button();
            this.b_rekap_data = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satkerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Data_Personil)).BeginInit();
            this.SuspendLayout();
            // 
            // p_update
            // 
            this.p_update.BackgroundImage = global::PERSONIL.Properties.Resources.Male_user_edit_icon;
            this.p_update.Location = new System.Drawing.Point(425, 371);
            this.p_update.Name = "p_update";
            this.p_update.Size = new System.Drawing.Size(49, 49);
            this.p_update.TabIndex = 110;
            this.p_update.Click += new System.EventHandler(this.p_update_Click);
            // 
            // p_insert
            // 
            this.p_insert.BackgroundImage = global::PERSONIL.Properties.Resources.Male_user_add_icon;
            this.p_insert.Location = new System.Drawing.Point(290, 371);
            this.p_insert.Name = "p_insert";
            this.p_insert.Size = new System.Drawing.Size(49, 49);
            this.p_insert.TabIndex = 109;
            this.p_insert.Click += new System.EventHandler(this.p_insert_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 266);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // t_no_telp
            // 
            this.t_no_telp.Location = new System.Drawing.Point(444, 300);
            this.t_no_telp.Name = "t_no_telp";
            this.t_no_telp.Size = new System.Drawing.Size(290, 20);
            this.t_no_telp.TabIndex = 105;
            // 
            // t_alamat_sat
            // 
            this.t_alamat_sat.Location = new System.Drawing.Point(444, 197);
            this.t_alamat_sat.Multiline = true;
            this.t_alamat_sat.Name = "t_alamat_sat";
            this.t_alamat_sat.Size = new System.Drawing.Size(290, 86);
            this.t_alamat_sat.TabIndex = 101;
            // 
            // t_satuan
            // 
            this.t_satuan.Location = new System.Drawing.Point(444, 162);
            this.t_satuan.Name = "t_satuan";
            this.t_satuan.Size = new System.Drawing.Size(290, 20);
            this.t_satuan.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistem Pengelolahan data Personil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "No Telp / Fax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Nama Satuan Kerja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Alamat Satuan";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(176, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(678, 73);
            this.panel4.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satuan Kerja";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 45);
            this.panel2.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(739, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Admin";
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
            this.panel1.TabIndex = 87;
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
            // p_delete
            // 
            this.p_delete.BackgroundImage = global::PERSONIL.Properties.Resources.Male_user_remove_icon;
            this.p_delete.Location = new System.Drawing.Point(554, 371);
            this.p_delete.Name = "p_delete";
            this.p_delete.Size = new System.Drawing.Size(49, 49);
            this.p_delete.TabIndex = 111;
            this.p_delete.Click += new System.EventHandler(this.p_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 170);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // satkerBindingSource
            // 
            this.satkerBindingSource.DataMember = "Satker";
            this.satkerBindingSource.DataSource = this.dS_Data_Personil;
            // 
            // dS_Data_Personil
            // 
            this.dS_Data_Personil.DataSetName = "DS_Data_Personil";
            this.dS_Data_Personil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satkerTableAdapter
            // 
            this.satkerTableAdapter.ClearBeforeFill = true;
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
            // p_refresh
            // 
            this.p_refresh.BackgroundImage = global::PERSONIL.Properties.Resources.Button_Refresh_icon;
            this.p_refresh.Location = new System.Drawing.Point(685, 371);
            this.p_refresh.Name = "p_refresh";
            this.p_refresh.Size = new System.Drawing.Size(49, 49);
            this.p_refresh.TabIndex = 115;
            this.p_refresh.Click += new System.EventHandler(this.p_refresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(623, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Admin";
            // 
            // b_manajement_user
            // 
            this.b_manajement_user.FlatAppearance.BorderSize = 0;
            this.b_manajement_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_manajement_user.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_manajement_user.ForeColor = System.Drawing.Color.White;
            this.b_manajement_user.Image = ((System.Drawing.Image)(resources.GetObject("b_manajement_user.Image")));
            this.b_manajement_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_manajement_user.Location = new System.Drawing.Point(9, 172);
            this.b_manajement_user.Name = "b_manajement_user";
            this.b_manajement_user.Size = new System.Drawing.Size(167, 38);
            this.b_manajement_user.TabIndex = 52;
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
            this.b_kategori_pend.Location = new System.Drawing.Point(9, 311);
            this.b_kategori_pend.Name = "b_kategori_pend";
            this.b_kategori_pend.Size = new System.Drawing.Size(167, 38);
            this.b_kategori_pend.TabIndex = 51;
            this.b_kategori_pend.Text = "Kategori Pendidikan";
            this.b_kategori_pend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_kategori_pend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_kategori_pend.UseVisualStyleBackColor = true;
            this.b_kategori_pend.Click += new System.EventHandler(this.b_kategori_pend_Click);
            // 
            // b_satker
            // 
            this.b_satker.FlatAppearance.BorderSize = 0;
            this.b_satker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_satker.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_satker.ForeColor = System.Drawing.Color.White;
            this.b_satker.Image = ((System.Drawing.Image)(resources.GetObject("b_satker.Image")));
            this.b_satker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_satker.Location = new System.Drawing.Point(9, 266);
            this.b_satker.Name = "b_satker";
            this.b_satker.Size = new System.Drawing.Size(167, 38);
            this.b_satker.TabIndex = 50;
            this.b_satker.Text = "Satuan Kerja";
            this.b_satker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_satker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_satker.UseVisualStyleBackColor = true;
            // 
            // b_rekap_data
            // 
            this.b_rekap_data.FlatAppearance.BorderSize = 0;
            this.b_rekap_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_rekap_data.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_rekap_data.ForeColor = System.Drawing.Color.White;
            this.b_rekap_data.Image = ((System.Drawing.Image)(resources.GetObject("b_rekap_data.Image")));
            this.b_rekap_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_rekap_data.Location = new System.Drawing.Point(9, 220);
            this.b_rekap_data.Name = "b_rekap_data";
            this.b_rekap_data.Size = new System.Drawing.Size(167, 38);
            this.b_rekap_data.TabIndex = 49;
            this.b_rekap_data.Text = "Rekap Data Personil";
            this.b_rekap_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_rekap_data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_rekap_data.UseVisualStyleBackColor = true;
            this.b_rekap_data.Click += new System.EventHandler(this.b_rekap_data_Click);
            // 
            // Satuan_Kerja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 609);
            this.Controls.Add(this.p_refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.p_delete);
            this.Controls.Add(this.p_update);
            this.Controls.Add(this.p_insert);
            this.Controls.Add(this.t_no_telp);
            this.Controls.Add(this.t_alamat_sat);
            this.Controls.Add(this.t_satuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Satuan_Kerja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satuan_Kerja";
            this.Load += new System.EventHandler(this.Satuan_Kerja_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satkerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Data_Personil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_update;
        private System.Windows.Forms.Panel p_insert;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox t_no_telp;
        private System.Windows.Forms.TextBox t_alamat_sat;
        private System.Windows.Forms.TextBox t_satuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_home;
        private System.Windows.Forms.Panel p_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DS_Data_Personil dS_Data_Personil;
        private System.Windows.Forms.BindingSource satkerBindingSource;
        private DS_Data_PersonilTableAdapters.SatkerTableAdapter satkerTableAdapter;
        private DS_Data_PersonilTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel p_refresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_manajement_user;
        private System.Windows.Forms.Button b_kategori_pend;
        private System.Windows.Forms.Button b_satker;
        private System.Windows.Forms.Button b_rekap_data;
    }
}