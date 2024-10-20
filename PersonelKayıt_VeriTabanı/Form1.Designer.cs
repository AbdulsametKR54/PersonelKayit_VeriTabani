namespace PersonelKayıt_VeriTabanı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPerId = new System.Windows.Forms.TextBox();
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.txtPerSoyad = new System.Windows.Forms.TextBox();
            this.cmbPerSehir = new System.Windows.Forms.ComboBox();
            this.msbPerMaas = new System.Windows.Forms.MaskedTextBox();
            this.btnEvli = new System.Windows.Forms.RadioButton();
            this.btnBekar = new System.Windows.Forms.RadioButton();
            this.txtPerMeslek = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vTYSDeneyselDataSet = new PersonelKayıt_VeriTabanı.VTYSDeneyselDataSet();
            this.tbl_PersonelTableAdapter = new PersonelKayıt_VeriTabanı.VTYSDeneyselDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.vTYSDeneyselDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.meslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSDeneyselDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSDeneyselDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPerId
            // 
            this.txtPerId.Location = new System.Drawing.Point(185, 24);
            this.txtPerId.Name = "txtPerId";
            this.txtPerId.Size = new System.Drawing.Size(147, 36);
            this.txtPerId.TabIndex = 0;
            // 
            // txtPerAd
            // 
            this.txtPerAd.Location = new System.Drawing.Point(185, 66);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(147, 36);
            this.txtPerAd.TabIndex = 1;
            // 
            // txtPerSoyad
            // 
            this.txtPerSoyad.Location = new System.Drawing.Point(185, 108);
            this.txtPerSoyad.Name = "txtPerSoyad";
            this.txtPerSoyad.Size = new System.Drawing.Size(147, 36);
            this.txtPerSoyad.TabIndex = 2;
            // 
            // cmbPerSehir
            // 
            this.cmbPerSehir.FormattingEnabled = true;
            this.cmbPerSehir.Location = new System.Drawing.Point(185, 150);
            this.cmbPerSehir.Name = "cmbPerSehir";
            this.cmbPerSehir.Size = new System.Drawing.Size(147, 36);
            this.cmbPerSehir.TabIndex = 3;
            // 
            // msbPerMaas
            // 
            this.msbPerMaas.Location = new System.Drawing.Point(185, 192);
            this.msbPerMaas.Mask = "0000000";
            this.msbPerMaas.Name = "msbPerMaas";
            this.msbPerMaas.Size = new System.Drawing.Size(147, 36);
            this.msbPerMaas.TabIndex = 4;
            // 
            // btnEvli
            // 
            this.btnEvli.AutoSize = true;
            this.btnEvli.Location = new System.Drawing.Point(184, 234);
            this.btnEvli.Name = "btnEvli";
            this.btnEvli.Size = new System.Drawing.Size(69, 32);
            this.btnEvli.TabIndex = 5;
            this.btnEvli.TabStop = true;
            this.btnEvli.Text = "Evli";
            this.btnEvli.UseVisualStyleBackColor = true;
            this.btnEvli.CheckedChanged += new System.EventHandler(this.btnEvli_CheckedChanged);
            // 
            // btnBekar
            // 
            this.btnBekar.AutoSize = true;
            this.btnBekar.Location = new System.Drawing.Point(259, 234);
            this.btnBekar.Name = "btnBekar";
            this.btnBekar.Size = new System.Drawing.Size(89, 32);
            this.btnBekar.TabIndex = 6;
            this.btnBekar.TabStop = true;
            this.btnBekar.Text = "Bekar";
            this.btnBekar.UseVisualStyleBackColor = true;
            this.btnBekar.CheckedChanged += new System.EventHandler(this.btnBekar_CheckedChanged);
            // 
            // txtPerMeslek
            // 
            this.txtPerMeslek.Location = new System.Drawing.Point(185, 272);
            this.txtPerMeslek.Name = "txtPerMeslek";
            this.txtPerMeslek.Size = new System.Drawing.Size(147, 36);
            this.txtPerMeslek.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnBekar);
            this.groupBox1.Controls.Add(this.txtPerMeslek);
            this.groupBox1.Controls.Add(this.btnEvli);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.msbPerMaas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbPerSehir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPerSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPerId);
            this.groupBox1.Controls.Add(this.txtPerAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 331);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgisi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Meslek:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehirler:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(389, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 43);
            this.label8.TabIndex = 9;
            this.label8.Text = "Personel Bilgi Ekranı";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.btnGrafikler);
            this.groupBox2.Controls.Add(this.btnIstatistik);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Location = new System.Drawing.Point(397, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 331);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.Location = new System.Drawing.Point(63, 285);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(153, 41);
            this.btnGrafikler.TabIndex = 6;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = true;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(63, 238);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(153, 41);
            this.btnIstatistik.TabIndex = 5;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(63, 199);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(153, 33);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(63, 156);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(153, 37);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(63, 111);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(153, 39);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(63, 66);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(153, 39);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(63, 27);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(153, 33);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.vTYSDeneyselDataSet;
            // 
            // vTYSDeneyselDataSet
            // 
            this.vTYSDeneyselDataSet.DataSetName = "VTYSDeneyselDataSet";
            this.vTYSDeneyselDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // vTYSDeneyselDataSetBindingSource
            // 
            this.vTYSDeneyselDataSetBindingSource.DataSource = this.vTYSDeneyselDataSet;
            this.vTYSDeneyselDataSetBindingSource.Position = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(814, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "label9";
            this.label9.TextChanged += new System.EventHandler(this.label9_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIdDataGridViewTextBoxColumn,
            this.personelAdDataGridViewTextBoxColumn,
            this.personelSoyadDataGridViewTextBoxColumn,
            this.personelSehirDataGridViewTextBoxColumn,
            this.maasDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn,
            this.meslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(936, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // personelIdDataGridViewTextBoxColumn
            // 
            this.personelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.HeaderText = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIdDataGridViewTextBoxColumn.Name = "personelIdDataGridViewTextBoxColumn";
            this.personelIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIdDataGridViewTextBoxColumn.Width = 95;
            // 
            // personelAdDataGridViewTextBoxColumn
            // 
            this.personelAdDataGridViewTextBoxColumn.DataPropertyName = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.HeaderText = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelAdDataGridViewTextBoxColumn.Name = "personelAdDataGridViewTextBoxColumn";
            this.personelAdDataGridViewTextBoxColumn.Width = 180;
            // 
            // personelSoyadDataGridViewTextBoxColumn
            // 
            this.personelSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelSoyad";
            this.personelSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelSoyad";
            this.personelSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelSoyadDataGridViewTextBoxColumn.Name = "personelSoyadDataGridViewTextBoxColumn";
            this.personelSoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // personelSehirDataGridViewTextBoxColumn
            // 
            this.personelSehirDataGridViewTextBoxColumn.DataPropertyName = "PersonelSehir";
            this.personelSehirDataGridViewTextBoxColumn.HeaderText = "PersonelSehir";
            this.personelSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelSehirDataGridViewTextBoxColumn.Name = "personelSehirDataGridViewTextBoxColumn";
            this.personelSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // maasDataGridViewTextBoxColumn
            // 
            this.maasDataGridViewTextBoxColumn.DataPropertyName = "Maas";
            this.maasDataGridViewTextBoxColumn.HeaderText = "Maas";
            this.maasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maasDataGridViewTextBoxColumn.Name = "maasDataGridViewTextBoxColumn";
            this.maasDataGridViewTextBoxColumn.Width = 75;
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            this.durumDataGridViewCheckBoxColumn.Width = 70;
            // 
            // meslekDataGridViewTextBoxColumn
            // 
            this.meslekDataGridViewTextBoxColumn.DataPropertyName = "Meslek";
            this.meslekDataGridViewTextBoxColumn.HeaderText = "Meslek";
            this.meslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meslekDataGridViewTextBoxColumn.Name = "meslekDataGridViewTextBoxColumn";
            this.meslekDataGridViewTextBoxColumn.Width = 180;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(942, 219);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.Location = new System.Drawing.Point(55, 41);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(153, 41);
            this.btnRaporlama.TabIndex = 7;
            this.btnRaporlama.Text = "Raporlama";
            this.btnRaporlama.UseVisualStyleBackColor = true;
            this.btnRaporlama.Click += new System.EventHandler(this.btnRaporlama_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Controls.Add(this.btnRaporlama);
            this.groupBox4.Location = new System.Drawing.Point(708, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 100);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Raporlama İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(967, 614);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Personel Bilgi Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSDeneyselDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSDeneyselDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPerId;
        private System.Windows.Forms.TextBox txtPerAd;
        private System.Windows.Forms.TextBox txtPerSoyad;
        private System.Windows.Forms.ComboBox cmbPerSehir;
        private System.Windows.Forms.MaskedTextBox msbPerMaas;
        private System.Windows.Forms.RadioButton btnEvli;
        private System.Windows.Forms.RadioButton btnBekar;
        private System.Windows.Forms.TextBox txtPerMeslek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private VTYSDeneyselDataSet vTYSDeneyselDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private VTYSDeneyselDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.BindingSource vTYSDeneyselDataSetBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRaporlama;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

