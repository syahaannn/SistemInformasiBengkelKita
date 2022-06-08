using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar
{
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void kryptonButtonPenjualan_Click(object sender, EventArgs e)
        {
            FormPenjualan form31 = new FormPenjualan();
            form31.TopLevel = false;
            form31.AutoScroll = true;
            this.panelKonten.Controls.Clear();
            this.panelKonten.Controls.Add(form31);
            form31.Show();
            //labelTitle.Text = "Penjualan";
        }

        private void kryptonButtonService_Click(object sender, EventArgs e)
        {
            FormService form32 = new FormService();
            form32.TopLevel = false;
            form32.AutoScroll = true;
            this.panelKonten.Controls.Clear();
            this.panelKonten.Controls.Add(form32);
            form32.Show();
            //labelTitle.Text = "Service";
        }

    }
}
