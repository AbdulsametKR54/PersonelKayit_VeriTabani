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
    public partial class FrmGirisForm : Form
    {
        public FrmGirisForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ABDULSAMETKR\\SQLEXPRESS;Initial Catalog=VTYSDeneysel;Integrated Security=True;Encrypt=False");

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand giriskont = new SqlCommand("Select * From Tbl_Yonetici where KullanıcıAdı=@k1 and Sifre=@k2", baglanti);
            giriskont.Parameters.AddWithValue("@k1", txtKullanıcıAdı.Text);
            giriskont.Parameters.AddWithValue("@k2", msbSifre.Text);
            SqlDataReader grd = giriskont.ExecuteReader();
            if (grd.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            baglanti.Close();
        }
    }
}
