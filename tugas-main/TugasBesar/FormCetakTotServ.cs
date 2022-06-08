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
    public partial class FormCetakTotServ : Form
    {
        String tgl_awal, tgl_akhir;
        public FormCetakTotServ(String tgl_awal, String tgl_akhir)
        {
            InitializeComponent();
            this.tgl_awal = tgl_awal;
            this.tgl_akhir = tgl_akhir;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dtTotServ = new DataTable();
            dtTotServ.Columns.Add("id_service", typeof(String));
            dtTotServ.Columns.Add("tgl_service", typeof(DateTime));
            dtTotServ.Columns.Add("total_biaya", typeof(long));
            dtTotServ = Detail_Service.SelectSUM(this.tgl_awal, this.tgl_akhir);

            crTotServ cr = new crTotServ();
            cr.Database.Tables["service"].SetDataSource(dtTotServ);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
