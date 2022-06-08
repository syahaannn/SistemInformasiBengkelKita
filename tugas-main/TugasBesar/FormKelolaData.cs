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
    public partial class FormKelolaData : Form
    {
        public FormKelolaData()
        {
            InitializeComponent();
        }

        private void kryptonButtonProduk_Click(object sender, EventArgs e)
        {
            FormProduk form2a = new FormProduk();
            form2a.TopLevel = false;
            form2a.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2a);
            form2a.Show();
        }

        private void kryptonButtonPegawai_Click(object sender, EventArgs e)
        {
            FormPegawai form2b = new FormPegawai();
            form2b.TopLevel = false;
            form2b.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2b);
            form2b.Show();
        }
    }
}
