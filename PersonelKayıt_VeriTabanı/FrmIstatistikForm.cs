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
    public partial class FrmIstatistikForm : Form
    {
        public FrmIstatistikForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ABDULSAMETKR\\SQLEXPRESS;Initial Catalog=VTYSDeneysel;Integrated Security=True;Encrypt=False");
        private void FrmIstatistikForm_Load(object sender, EventArgs e)
        {
            //Toplam Personel
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamPer.Text = dr1[0].ToString();
            }
            baglanti.Close();

            //Toplam Evli
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where Durum=1 ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvliPer.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Toplam Bekar
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where Durum=0 ", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekarPer.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Şehir Sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PersonelSehir)) From Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehirler.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam Maaş
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(Maas) From Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamMaas.Text = dr5[0] + " TL";
            }
            baglanti.Close();

            //Ortalama Maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(Maas) From Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblOrtMaas.Text = dr6[0] + " TL";
            }
            baglanti.Close();
        }
    }
}
