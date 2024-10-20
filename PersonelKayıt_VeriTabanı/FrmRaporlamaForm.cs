using PersonelKayıt_VeriTabanı.PersonelDataSetTableAdapters; // Doğru namespace
using Microsoft.Reporting.WinForms; // ReportDataSource için gerekli
using System;
using System.Windows.Forms;
using System.Data;

namespace PersonelKayıt_VeriTabanı
{
    public partial class FrmRaporlamaForm : Form
    {
        public FrmRaporlamaForm()
        {
            InitializeComponent();
        }

        private void FrmRaporlamaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDataSet.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter.Fill(this.personelDataSet.Tbl_Personel);
            // DataSet ve TableAdapter'ı oluşturun
            PersonelDataSet personelDataSet = new PersonelDataSet();
            Tbl_PersonelTableAdapter adapter = new Tbl_PersonelTableAdapter();

            // Verileri yükleyin
            int rowsAffected = adapter.Fill(personelDataSet.Tbl_Personel);

            // Verilerin yüklendiğini kontrol edin
            if (rowsAffected == 0)
            {
                MessageBox.Show("Veri yüklenmedi!");
                return;
            }

            // ReportViewer verilerini ayarlayın
            reportViewer1.LocalReport.DataSources.Clear();
            // DataTable'ı açıkça belirtin
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)personelDataSet.Tbl_Personel));

            // Raporu yenileyin
            this.reportViewer1.RefreshReport();
        }
    }
}
