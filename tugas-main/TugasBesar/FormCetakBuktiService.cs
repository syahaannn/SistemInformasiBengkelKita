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
    public partial class FormCetakBuktiService : Form
    {
        String id_service;
        public FormCetakBuktiService(String id_service)
        {
            InitializeComponent();
            this.id_service = id_service;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dtService = new DataTable();
            dtService.Columns.Add("id_service", typeof(String));
            dtService.Columns.Add("tgl_service", typeof(DateTime));
            dtService.Columns.Add("total_biaya", typeof(int));
            dtService = Detail_Service.Select(this.id_service);

            DataTable dtDetailService = new DataTable();
            dtDetailService.Columns.Add("id_service", typeof(String));
            dtDetailService.Columns.Add("nama_service", typeof(String));
            dtDetailService.Columns.Add("biaya", typeof(int));
            dtDetailService = Detail_Service.SelectDetail(this.id_service);

            StrukService struk = new StrukService();
            struk.Database.Tables["service"].SetDataSource(dtService);
            struk.Database.Tables["daftar_service"].SetDataSource(dtDetailService);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = struk;
        }
    }
}
