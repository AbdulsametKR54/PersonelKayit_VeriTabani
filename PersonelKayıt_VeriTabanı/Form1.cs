using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayıt_VeriTabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ABDULSAMETKR\\SQLEXPRESS;Initial Catalog=VTYSDeneysel;Integrated Security=True;Encrypt=False");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.vTYSDeneyselDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PersonelAd,PersonelSoyad,PersonelSehir,Maas,Meslek,Durum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtPerAd.Text);
            komut.Parameters.AddWithValue("@p2", txtPerSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbPerSehir.Text);
            komut.Parameters.AddWithValue("@p4", msbPerMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtPerMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label9.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgileri Eklendi!");
        }

        private void btnEvli_CheckedChanged(object sender, EventArgs e)
        {
            if(btnEvli.Checked==true)
            {
                label9.Text = "True";
            }
        }

        private void btnBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (btnBekar.Checked == true)
            {
                label9.Text = "False";
            }
        }
        public void temizle()
        {
            txtPerAd.Text = "";
            txtPerSoyad.Text = "";
            cmbPerSehir.Text = "";
            msbPerMaas.Text = "";
            txtPerMeslek.Text = "";
            btnBekar.Checked = false;
            btnEvli.Checked = false;
            txtPerAd.Focus();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtPerId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtPerAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtPerSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbPerSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msbPerMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label9.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtPerMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if(label9.Text=="True")
            {
                btnEvli.Checked = true;
            }
            if (label9.Text == "False")
            {
                btnBekar.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kommutsil = new SqlCommand("Delete From Tbl_Personel Where PersonelId=@k1", baglanti);
            kommutsil.Parameters.AddWithValue("@k1", txtPerId.Text);
            kommutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgileri Silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgüncelle = new SqlCommand("Update Tbl_Personel Set PersonelAd=@z1, PersonelSoyad=@z2, PersonelSehir=@z3, Maas=@z4, Durum=@z5, Meslek=@z6 Where PersonelId=@z0", baglanti);
            komutgüncelle.Parameters.AddWithValue("@z0", txtPerId.Text);
            komutgüncelle.Parameters.AddWithValue("@z1", txtPerAd.Text);
            komutgüncelle.Parameters.AddWithValue("@z2", txtPerSoyad.Text);
            komutgüncelle.Parameters.AddWithValue("@z3", cmbPerSehir.Text);
            komutgüncelle.Parameters.AddWithValue("@z4", msbPerMaas.Text);
            komutgüncelle.Parameters.AddWithValue("@z5", label9.Text);
            komutgüncelle.Parameters.AddWithValue("@z6", txtPerMeslek.Text);
            komutgüncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgileri Güncellendi!");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistikForm formIstatistik = new FrmIstatistikForm();
            formIstatistik.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafiklerForm formGrafikler=new FrmGrafiklerForm();
            formGrafikler.Show();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            FrmRaporlamaForm frmRapor=new FrmRaporlamaForm();
            frmRapor.Show();
        }
    }
}
