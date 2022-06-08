using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasBesar.ReportGenerator.CrystalReport;

namespace TugasBesar
{
    public partial class FormCetakPenjualan : Form
    {
        String id_transaksi;
        public FormCetakPenjualan(String id_transaksi)
        {
            InitializeComponent();
            this.id_transaksi = id_transaksi;
        }

        private void crystalReportViewerPenjualan_Load(object sender, EventArgs e)
        {
            DataTable dtPenjualan = new DataTable();
            dtPenjualan.Columns.Add("id_transaksi", typeof(String));
            dtPenjualan.Columns.Add("tgl_jual", typeof(DateTime));
            dtPenjualan.Columns.Add("total", typeof(int));
            dtPenjualan = Detail_Transaksi.Select(this.id_transaksi);

            DataTable dtDetailPenjualan = new DataTable();
            dtDetailPenjualan.Columns.Add("id_transaksi", typeof(String));
            dtDetailPenjualan.Columns.Add("kode_barang", typeof(String));
            dtDetailPenjualan.Columns.Add("nama_barang", typeof(String));
            dtDetailPenjualan.Columns.Add("harga_satuan", typeof(int));
            dtDetailPenjualan.Columns.Add("kuantitas_beli", typeof(int));
            dtDetailPenjualan.Columns.Add("harga_total", typeof(int));
            dtDetailPenjualan = Detail_Transaksi.SelectDetail(this.id_transaksi);

            StrukPenjualan struk = new StrukPenjualan();
            struk.Database.Tables["penjualan"].SetDataSource(dtPenjualan);
            struk.Database.Tables["daftar_transaksi"].SetDataSource(dtDetailPenjualan);
            crystalReportViewerPenjualan.ReportSource = null;
            crystalReportViewerPenjualan.ReportSource = struk;
        }
    }
}
