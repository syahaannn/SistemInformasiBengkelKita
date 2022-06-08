using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar
{
    public partial class FormDashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );

        Akun akun;
        Pegawai pegawai;
        protected String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;
        public FormDashboard(Akun akun)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.akun = akun;
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            pegawai = new Pegawai();
            pegawai = Pegawai.Select(akun.id_pegawai);
            if (pegawai.role == 1)
            {
                labelNama.Text = "Admin "+pegawai.nama_pegawai;
                FormBeranda form1 = new FormBeranda();
                form1.TopLevel = false;
                form1.AutoScroll = true;
                this.panelContent.Controls.Clear();
                this.panelContent.Controls.Add(form1);
                form1.Show();
                labelJudul.Text = "DASHBOARD";
            }
            else if (pegawai.role == 2)
            {
                labelNama.Text = "Kasir " + pegawai.nama_pegawai;
                ButtonDashboard.Visible = false;
                ButtonKelolaData.Visible = false;
                ButtonLaporan.Visible = false;
                FormTransaksi form1 = new FormTransaksi();
                form1.TopLevel = false;
                form1.AutoScroll = true;
                this.panelContent.Controls.Clear();
                this.panelContent.Controls.Add(form1);
                form1.Show();
                labelJudul.Text = "TRANSAKSI";

            }
        }


        private void ButtonKelolaData_Click(object sender, EventArgs e)
        {
            FormKelolaData form2 = new FormKelolaData();
            form2.TopLevel = false;
            form2.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2);
            form2.Show();
            labelJudul.Text = "KELOLA DATA";
        }

        private void ButtonDashboard_Click_1(object sender, EventArgs e)
        {
            FormBeranda form1 = new FormBeranda();
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
            labelJudul.Text = "DASHBOARD";
        }

       

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            FormLoginAkun formlogout = new FormLoginAkun();
            formlogout.Show();
            this.Hide();
        }

        private void ButtonTransaksi_Click(object sender, EventArgs e)
        {
            FormTransaksi form1 = new FormTransaksi();
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
            labelJudul.Text = "TRANSAKSI";
        }

        private void ButtonLaporan_Click(object sender, EventArgs e)
        {
            FormLapPenjualan form1 = new FormLapPenjualan();
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
            labelJudul.Text = "LAPORAN";
        }

        private void pictureBoxProfil_Click(object sender, EventArgs e)
        {
            FormProfil form1 = new FormProfil(akun);
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
            labelJudul.Text = "KELOLA PROFIL";
        }

        private void labelNama_Click(object sender, EventArgs e)
        {
            FormProfil form1 = new FormProfil(akun);
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
            labelJudul.Text = "KELOLA PROFIL";
        }
    }
}
