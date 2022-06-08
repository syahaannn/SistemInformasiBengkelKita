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
    public partial class FormPenjualan : Form
    {
        int harga;
        int kuantitas = 0;
        int tot;
        int total = 0;

        int qty_awal;
        int qty_jual;
        int qty_akhir;

        int jml_awal;
        int jml_jual;
        int jml_akhir;

        String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        public FormPenjualan()
        {
            InitializeComponent();
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {
            Combobox();
        }

        public void Combobox()
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT kode_barang, nama_barang FROM data_barang", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(1);
                    string kode = rdr.GetString(0);
                    comboBoxBarang.Items.Add(nama);
                    comboBoxKode.Items.Add(kode);
                }
            }
            catch
            {

            }
        }

        private void comboBoxBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT kode_barang, harga_jual FROM data_barang WHERE nama_barang = '" + comboBoxBarang.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string kode = rdr.GetString(0);
                    string harga = rdr.GetInt32(1).ToString();
                    textBoxHarga.Text = harga;
                    comboBoxKode.Text = kode;
                }
            }
            catch
            {

            }
        }

        private void comboBoxKode_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT nama_barang, harga_jual FROM data_barang WHERE kode_barang = '" + comboBoxKode.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string _harga = rdr.GetInt32(1).ToString();
                    string nama = rdr.GetString(0);
                    comboBoxBarang.Text = nama;
                    textBoxHarga.Text = _harga;
                    textBoxKuantitas.Text = "1";
                    buttonSubmit.Enabled = false;
                    harga = Convert.ToInt32(textBoxHarga.Text);

                    if (textBoxKuantitas.Text == "")
                    {
                        kuantitas = 0;
                    }
                    else
                    {
                        kuantitas = Convert.ToInt32(textBoxKuantitas.Text);
                    }
                    tot = kuantitas * harga;
                    textBoxHargaTot.Text = tot.ToString();
                }
            }
            catch
            {

            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            total = total + tot;
            textBoxTotal.Text = total.ToString();            
            Kurang();
            Tambah();

            string response;
            Penjualan inputTransaksi = new Penjualan();
            inputTransaksi.id_transaksi = textBoxIDJual.Text;
            inputTransaksi.kode_barang = comboBoxKode.SelectedItem.ToString();
            inputTransaksi.nama_barang = comboBoxBarang.SelectedItem.ToString();
            inputTransaksi.kuantitas_beli = Convert.ToInt32(textBoxKuantitas.Text);
            inputTransaksi.harga_satuan = Convert.ToInt32(textBoxHarga.Text);
            inputTransaksi.harga_total = Convert.ToInt32(textBoxHargaTot.Text);
            response = inputTransaksi.InsertStruk();
            if (response == null)
            {
                buttonSubmit.Enabled = true;
                ReadData();
            }
            else MessageBox.Show(response);

            string responses;
            Penjualan inputKuantitas = new Penjualan();
            inputKuantitas.struk = comboBoxKode.Text;
            inputKuantitas.kuantitas_jual = Convert.ToInt32(jml_akhir);
            responses = inputKuantitas.KuantitasTerjual();
            if (responses == null)
            {
                
            }
            else MessageBox.Show(responses);

            string respon;
            Penjualan inputKurang = new Penjualan();
            inputKurang.kurang = qty_akhir;
            inputKurang.struk = comboBoxKode.Text;
            respon = inputKurang.KuantitasKurang();
            if (respon == null)
            {
                
            }
            else MessageBox.Show(respon);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string response;
            Penjualan inputTransaksi = new Penjualan();
            inputTransaksi.id_transaksi = textBoxIDJual.Text;
            inputTransaksi.tgl_jual = dateTimePickerTanggal.Value.ToString("yyyyMMdd");
            inputTransaksi.total = Convert.ToInt32(textBoxTotal.Text);
            response = inputTransaksi.Insert();
            if (response == null)
            {
                comboBoxBarang.Text = null;
                comboBoxKode.Text = null;
                textBoxKuantitas.Text = null;
                textBoxHarga.Text = null;
                textBoxHargaTot.Text = null;

                comboBoxBarang.Enabled = false;
                comboBoxKode.Enabled = false;
                textBoxKuantitas.ReadOnly = true;
                buttonTambah.Enabled = false;
                buttonSubmit.Enabled = false;
                buttonCetak.Enabled = true;

                MessageBox.Show("Input data sukses");                
            }
            else MessageBox.Show(response);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            comboBoxBarang.Enabled = true;
            comboBoxKode.Enabled = true;
            textBoxKuantitas.ReadOnly = false;
            buttonTambah.Enabled = true;
            textBoxIDJual.Text = null;
            textBoxTotal.Text = null;
            dataGridViewDaftar.DataSource = null;
            total = 0;

            var isi = "1234567890";
            var random = new char[8];
            var acak = new Random();

            for (int i = 0;i < random.Length; i++)
            {
                random[i] = isi[acak.Next(isi.Length)];
            }

            textBoxIDJual.Text = new string(random);            
        }

        private void textBoxKuantitas_TextChanged(object sender, EventArgs e)
        {
            harga = Convert.ToInt32(textBoxHarga.Text);

            if (textBoxKuantitas.Text == "")
            {
                kuantitas = 0;
            }
            else
            {
                kuantitas = Convert.ToInt32(textBoxKuantitas.Text);
            }            
            tot = kuantitas * harga;
            textBoxHargaTot.Text = tot.ToString();
        }

        private void ReadData()
        {
            Penjualan tabelStruk = new Penjualan();
            DataTable dt = new DataTable();
            tabelStruk.struk = textBoxIDJual.Text;
            dt = tabelStruk.ReadStruk();
            dataGridViewDaftar.DataSource = dt;
            dataGridViewDaftar.Show();
        }

        private void Kurang()
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT kuantitas_barang FROM data_barang WHERE kode_barang = '" + comboBoxKode.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string qty = rdr.GetInt32(0).ToString();
                    qty_awal = Convert.ToInt32(qty);
                }
            }
            catch
            {

            }

            qty_jual = Convert.ToInt32(textBoxKuantitas.Text);
            qty_akhir = qty_awal - qty_jual;
        }

        private void Tambah()
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT kuantitas_jual FROM data_barang WHERE kode_barang = '" + comboBoxKode.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string qty = rdr.GetInt32(0).ToString();
                    jml_awal = Convert.ToInt32(qty);
                }
            }
            catch
            {

            }

            jml_jual = Convert.ToInt32(textBoxKuantitas.Text);
            jml_akhir = jml_awal + jml_jual;
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            FormCetakPenjualan form = new FormCetakPenjualan(textBoxIDJual.Text);
            form.Show();
        }
    }
}
