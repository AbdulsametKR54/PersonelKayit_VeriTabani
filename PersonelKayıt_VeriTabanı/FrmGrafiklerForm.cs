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
    public partial class FrmGrafiklerForm : Form
    {
        public FrmGrafiklerForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ABDULSAMETKR\\SQLEXPRESS;Initial Catalog=VTYSDeneysel;Integrated Security=True;Encrypt=False");
        private void FrmGrafiklerForm_Load(object sender, EventArgs e)
        {
            //Grafik-1
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PersonelSehir,COUNT(*) From Tbl_Personel group by PersonelSehir", baglanti);
            SqlDataReader drg1 = komutg1.ExecuteReader();
            while (drg1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(drg1[0], drg1[1]);
            }
            baglanti.Close();

            //Grafik-2
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select PersonelSehir,Avg(Maas) From Tbl_Personel group by PersonelSehir", baglanti);
            SqlDataReader drg2 = komutg2.ExecuteReader();
            while (drg2.Read())
            {
                chart2.Series["Sehir-Maas"].Points.AddXY(drg2[0], drg2[1]);
            }
            baglanti.Close();
        }
    }
}
