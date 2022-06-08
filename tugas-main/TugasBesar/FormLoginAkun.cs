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
    public partial class FormLoginAkun : Form
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

        protected String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        public FormLoginAkun()
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void kryptonButtonLogin_Click(object sender, EventArgs e)
        {
            string response;
            Akun akun = new Akun();
            akun.username = kryptonTextBoxUsername.Text;
            response = akun.Login();
            if (kryptonTextBoxUsername.Text == akun.username && kryptonTextBoxPassword.Text == akun.password)
            {
                FormDashboard form1 = new FormDashboard(akun);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah");
                kryptonTextBoxUsername.Text = null;
                kryptonTextBoxPassword.Text = null;
            }
        }

        private void kryptonButtonTutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
