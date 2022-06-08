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
    public partial class FormProduk : Form
    {
        int qty_awal, qty_beli, qty_akhir, id_barang;

        String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        
        public FormProduk()
        {
            InitializeComponent();
        }

        private void buttonTambahStok_Click(object sender, EventArgs e)
        {
            panelTambahStok.Visible = true;
            textBoxKuantitas.ReadOnly = false;
            textBoxKuantitas.Text = null;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonTambahStok.Enabled = false;
            buttonTambahData.Enabled = false;
            labelKuantitas.Text = "Kuantitas Tambah";
            comboBoxKode.Enabled = false;
            comboBoxSearch.Enabled = false;
        }

        private void buttonTambahData_Click(object sender, EventArgs e)
        {
            panelTambah.Visible = true;
            buttonTambahData.Enabled = false;
            NewInput();
            NewLine();
            comboBoxKode.Enabled = false;
            comboBoxSearch.Enabled = false;
            buttonDelete.Enabled=false;
            buttonUpdate.Enabled=false;
            buttonTambahStok.Enabled=false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = true;
            NewInput();
            buttonTambahData.Enabled = false;
            buttonTambahStok.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            comboBoxKode.Enabled = false;
            comboBoxSearch.Enabled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
            buttonTambahData.Enabled = false;
            buttonTambahStok.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            comboBoxKode.Enabled = false;
            comboBoxSearch.Enabled = false;
        }

        private void buttonStokOK_Click(object sender, EventArgs e)
        {
            Tambah();
            Barang dataBarang = new Barang();
            dataBarang.kuantitas_barang = qty_akhir;
            dataBarang.id_barang = id_barang;

            String response;
            response = dataBarang.Tambah();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);

            DataLoad();
        }

        private void buttonStokCancel_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void buttonTambahOK_Click(object sender, EventArgs e)
        {
            Barang dataBarang = new Barang();
            dataBarang.kode_barang = textBoxKode.Text;
            dataBarang.nama_barang = textBoxNama.Text;
            dataBarang.harga_beli = Convert.ToInt32(textBoxHargaBeli.Text);
            dataBarang.harga_jual = Convert.ToInt32(textBoxHargaJual.Text);
            dataBarang.kuantitas_barang = Convert.ToInt32(textBoxKuantitas.Text);
            dataBarang.satuan_barang = comboBoxSatuan.Text;

            String response;
            response = dataBarang.Insert();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);

            DataLoad();
        }

        private void buttonTambahCancel_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void buttonUpdateOK_Click(object sender, EventArgs e)
        {
            Barang dataBarang = new Barang();
            dataBarang.kode_barang = textBoxKode.Text;
            dataBarang.nama_barang = textBoxNama.Text;
            dataBarang.harga_beli = Convert.ToInt32(textBoxHargaBeli.Text);
            dataBarang.harga_jual = Convert.ToInt32(textBoxHargaJual.Text);
            dataBarang.kuantitas_barang = Convert.ToInt32(textBoxKuantitas.Text);
            dataBarang.satuan_barang = comboBoxSatuan.Text;
            dataBarang.id_barang = id_barang;

            String response;
            response = dataBarang.Update();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);

            DataLoad();
        }

        private void buttonUpdateCancel_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void buttonDeleteOK_Click(object sender, EventArgs e)
        {
            Barang dataBarang = new Barang();
            dataBarang.id_barang = id_barang;

            String response;
            response = dataBarang.Delete();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);

            DataLoad();
        }

        private void buttonDeleteCancel_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        public void Combobox()
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT nama_barang, kode_barang, id_barang FROM data_barang", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    string kode = rdr.GetString(1);
                    string id = rdr.GetInt32(2).ToString();
                    comboBoxSearch.Items.Add(nama);
                    comboBoxKode.Items.Add(kode);
                }
            }
            catch
            {

            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT id_barang, kode_barang " +
                "FROM data_barang WHERE nama_barang = '" + comboBoxSearch.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id_barang = rdr.GetInt32(0);
                    string kode = rdr.GetString(1);
                    comboBoxKode.Text = kode;
                    SelectID(id_barang);
                }
            }
            catch
            {

            }
        }

        private void comboBoxKode_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT nama_barang, id_barang " +
                "FROM data_barang WHERE kode_barang = '" + comboBoxKode.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id_barang = rdr.GetInt32(1);
                    string nama = rdr.GetString(0);
                    comboBoxSearch.Text = nama;
                    SelectID(id_barang);
                }
            }
            catch
            {

            }
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            Combobox();
            ReadData();
        }

        private void NewInput()
        {
            textBoxKode.ReadOnly = false;
            textBoxNama.ReadOnly = false;
            textBoxHargaBeli.ReadOnly = false;
            textBoxHargaJual.ReadOnly = false;
            textBoxKuantitas.ReadOnly = false;
            comboBoxSatuan.Enabled = true;
        }

        private void NewLine()
        {
            textBoxKode.Text = null;
            textBoxNama.Text = null;
            textBoxHargaBeli.Text = null;
            textBoxHargaJual.Text = null;
            textBoxKuantitas.Text = null;
            comboBoxSatuan.Text = null;
            comboBoxKode.Text = null;
            comboBoxSearch.Text = null;
        }

        private void Tambah()
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT kuantitas_barang FROM data_barang WHERE id_barang = '" + id_barang + "';", conn);
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

            qty_beli = Convert.ToInt32(textBoxKuantitas.Text);
            qty_akhir = qty_awal + qty_beli;
        }

        private void DataLoad()
        {
            FormProduk form2b = new FormProduk();
            form2b.TopLevel = false;
            form2b.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2b);
            form2b.Show();
        }

        private void ReadData()
        {
            Barang tabelStruk = new Barang();
            DataTable dt = new DataTable();
            dt = tabelStruk.Read();
            dataGridViewDaftar.DataSource = dt;
            dataGridViewDaftar.Show();
        }

        private void SelectID(int id)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT kode_barang, nama_barang, harga_beli, harga_jual, kuantitas_barang, satuan_barang " +
                "FROM data_barang WHERE id_barang = '" + id + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string kode = rdr.GetString(0);
                    string nama = rdr.GetString(1);
                    string beli = rdr.GetInt32(2).ToString();
                    string jual = rdr.GetInt32(3).ToString();
                    string qty = rdr.GetInt32(4).ToString();
                    string satuan = rdr.GetString(5);
                    textBoxKode.Text = kode;
                    textBoxNama.Text = nama;
                    textBoxHargaBeli.Text = beli;
                    textBoxHargaJual.Text = jual;
                    textBoxKuantitas.Text = qty;
                    comboBoxSatuan.Text = satuan;
                }
            }
            catch
            {

            }
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonTambahStok.Enabled = true;
        }
    }
}
