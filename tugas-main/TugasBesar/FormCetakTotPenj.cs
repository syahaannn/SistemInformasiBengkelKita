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
    public partial class FormCetakTotPenj : Form
    {
        String tgl_awal, tgl_akhir;
        public FormCetakTotPenj(String tgl_awal, String tgl_akhir)
        {
            InitializeComponent();
            this.tgl_awal = tgl_awal;
            this.tgl_akhir = tgl_akhir;
        }

        private void crystalReportViewerTotPenj_Load(object sender, EventArgs e)
        {
            DataTable dtTotPenj = new DataTable();
            dtTotPenj.Columns.Add("id_transaksi", typeof(String));
            dtTotPenj.Columns.Add("tgl_jual", typeof(DateTime));
            dtTotPenj.Columns.Add("total", typeof(long));
            dtTotPenj = Detail_Transaksi.SelectSUM(this.tgl_awal, this.tgl_akhir);

            crTotPenj cr = new crTotPenj();
            cr.Database.Tables["penjualan"].SetDataSource(dtTotPenj);
            crystalReportViewerTotPenj.ReportSource = null;
            crystalReportViewerTotPenj.ReportSource = cr;
        }
    }
}
