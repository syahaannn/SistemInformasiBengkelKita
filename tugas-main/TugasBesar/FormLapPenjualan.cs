using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar
{
    public partial class FormLapPenjualan : Form
    {
        protected String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;
        public FormLapPenjualan()
        {
            InitializeComponent();
        }

        private void panelPenj_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPenj_Click(object sender, EventArgs e)
        {            
            panelPenj.Visible = true;
            labelServ.Enabled = false;
            labelTotPenj.Enabled = false;
            labelTotServ.Enabled = false;
        }

        private void ComboboxPenj()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT id_transaksi FROM penjualan WHERE tgl_jual = '"+ dateTimePickerPenj.Value.ToString("yyyyMMdd") + "'", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    comboBoxPenj.Items.Add(nama);
                }
            }
            catch { }
        }

        private void FormLapPenjualan_Load(object sender, EventArgs e)
        {
            ComboboxPenj();
            ComboboxServ();
            ComboboxTotPenj();
            ReadTotPenj();
            ComboboxTotServ();
            ReadTotServ();
        }

        private void dateTimePickerPenj_ValueChanged(object sender, EventArgs e)
        {
            comboBoxPenj.Items.Clear();
            ComboboxPenj();
        }

        private void ReadPenj()
        {
            Penjualan tabelStruk = new Penjualan();
            DataTable dt = new DataTable();
            tabelStruk.struk = comboBoxPenj.Text;
            dt = tabelStruk.ReadStruk();
            dataGridViewPenj.DataSource = dt;
            dataGridViewPenj.Show();
        }

        private void comboBoxPenj_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadPenj();
        }

        private void buttonCetakPenj_Click(object sender, EventArgs e)
        {
            FormCetakPenjualan form = new FormCetakPenjualan(comboBoxPenj.Text);
            form.Show();
        }

        private void labelServ_Click(object sender, EventArgs e)
        {
            panelServ.Visible = true;
            labelPenj.Enabled = false;
            labelTotPenj.Enabled = false;
            labelTotServ.Enabled = false;
        }

        private void ComboboxServ()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT id_service FROM service WHERE tgl_service = '" + dateTimePickerServ.Value.ToString("yyyyMMdd") + "'", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    comboBoxServ.Items.Add(nama);
                }
            }
            catch { }
        }

        private void dateTimePickerServ_ValueChanged(object sender, EventArgs e)
        {
            comboBoxServ.Items.Clear();
            ComboboxServ();
        }

        private void comboBoxServ_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadServ();
        }

        private void ReadServ()
        {
            Service tabelStruk = new Service();
            DataTable dt = new DataTable();
            tabelStruk.struk = comboBoxServ.Text;
            dt = tabelStruk.ReadStruk();
            dataGridViewServ.DataSource = dt;
            dataGridViewServ.Show();
        }

        private void buttonCetakServ_Click(object sender, EventArgs e)
        {
            FormCetakBuktiService form = new FormCetakBuktiService(comboBoxServ.Text);
            form.Show();
        }

        private void labelTotPenj_Click(object sender, EventArgs e)
        {
            panelTotPenj.Visible = true;
            labelServ.Enabled = false;
            labelPenj.Enabled = false;
            labelTotServ.Enabled = false;
        }

        private void ComboboxTotPenj()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT SUM(total) FROM penjualan WHERE (tgl_jual " +
                "BETWEEN '" + dateTimePickerTotPenj1.Value.ToString("yyyyMMdd") + "' " +
                "AND '" + dateTimePickerTotPenj2.Value.ToString("yyyyMMdd") + "')", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    textBoxTotPenj.Text = nama;
                }
            }
            catch { }
        }

        private void ReadTotPenj()
        {
            Penjualan tabelStruk = new Penjualan();
            DataTable dt = new DataTable();
            tabelStruk.tgl_awal = dateTimePickerTotPenj1.Value.ToString("yyyyMMdd");
            tabelStruk.tgl_akhir = dateTimePickerTotPenj2.Value.ToString("yyyyMMdd");
            dt = tabelStruk.ReadSUM();
            dataGridViewTotPenj.DataSource = dt;
            dataGridViewTotPenj.Show();
        }

        private void dateTimePickerTotPenj1_ValueChanged(object sender, EventArgs e)
        {
            ComboboxTotPenj();
            ReadTotPenj();
        }

        private void dateTimePickerTotPenj2_ValueChanged(object sender, EventArgs e)
        {
            ComboboxTotPenj();
            ReadTotPenj();
        }

        private void buttonCetakTotPenj_Click(object sender, EventArgs e)
        {
            FormCetakTotPenj form = new FormCetakTotPenj(dateTimePickerTotPenj1.Value.ToString("yyyyMMdd"), dateTimePickerTotPenj2.Value.ToString("yyyyMMdd"));
            form.Show();
        }

        private void ComboboxTotServ()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT SUM(total_biaya) FROM service WHERE (tgl_service " +
                "BETWEEN '" + dateTimePickerTotPenj1.Value.ToString("yyyyMMdd") + "' " +
                "AND '" + dateTimePickerTotPenj2.Value.ToString("yyyyMMdd") + "')", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    textBoxTotServ.Text = nama;
                }
            }
            catch { }
        }

        private void ReadTotServ()
        {
            Service tabelStruk = new Service();
            DataTable dt = new DataTable();
            tabelStruk.tgl_awal = dateTimePickerTotServ1.Value.ToString("yyyyMMdd");
            tabelStruk.tgl_akhir = dateTimePickerTotServ2.Value.ToString("yyyyMMdd");
            dt = tabelStruk.ReadSUM();
            dataGridViewTotServ.DataSource = dt;
            dataGridViewTotServ.Show();
        }

        private void dateTimePickerTotServ1_ValueChanged(object sender, EventArgs e)
        {
            ReadTotServ();
        }

        private void dateTimePickerTotServ2_ValueChanged(object sender, EventArgs e)
        {
            ReadTotServ();
        }

        private void labelTotServ_Click(object sender, EventArgs e)
        {
            panelTotServ.Visible = true;
            labelServ.Enabled = false;
            labelPenj.Enabled = false;
            labelTotPenj.Enabled = false;
        }

        private void buttonCetakTotServ_Click(object sender, EventArgs e)
        {
            FormCetakTotServ form = new FormCetakTotServ(dateTimePickerTotServ1.Value.ToString("yyyyMMdd"), dateTimePickerTotServ2.Value.ToString("yyyyMMdd"));
            form.Show();
        }

        private void buttonTutupServ_Click(object sender, EventArgs e)
        {
            FormLapPenjualan form1 = new FormLapPenjualan();
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
        }

        private void buttonTutupPenj_Click(object sender, EventArgs e)
        {
            FormLapPenjualan form1 = new FormLapPenjualan();
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
        }

        private void buttonTutupTotPenj_Click(object sender, EventArgs e)
        {
            FormLapPenjualan form1 = new FormLapPenjualan();
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
        }

        private void buttonTutupTotServ_Click(object sender, EventArgs e)
        {
            FormLapPenjualan form1 = new FormLapPenjualan();
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
        }
    }
}
